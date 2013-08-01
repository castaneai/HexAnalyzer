using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexAnalyzer
{
	public partial class HexViewControl : UserControl
	{
		/// <summary>
        /// バイトデータを文字列表示する場合に使用する文字エンコーディング
		/// </summary>
        private Encoding textEncoding = Encoding.GetEncoding(932);

        /// <summary>
        /// バイトデータを文字列表示する場合に使用する文字エンコーディング
        /// デフォルトはSjis-win (cp932)
        /// これを変更すると自動的に文字列表示ボックスも更新される
        /// </summary>
        public Encoding TextEncoding
        {
            get
            {
                return textEncoding;
            }

            set
            {
                textEncoding = value;
                updateStringTextBox();
            }
        }

        /// <summary>
        /// 現在表示しているバイトデータ
        /// </summary>
        private byte[] bytes;

        /// <summary>
        /// 現在表示しているバイトデータ
        /// これを変更すると自動的にテキストボックスも更新される
        /// </summary>
		public byte[] Bytes
		{
			get
			{
                return bytes;
			}

			set
			{
                updateHexTextBox();
                updateStringTextBox();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public HexViewControl()
		{
			InitializeComponent();
		}

        /// <summary>
        /// 16進数バイト表示ボックスの内容を更新する
        /// </summary>
        private void updateHexTextBox()
        {
            hexTextBox.Text = HexConverter.ToHex(this.Bytes);
        }

        /// <summary>
        /// 文字列表示ボックスの内容を更新する
        /// </summary>
        private void updateStringTextBox()
        {
            stringTextBox.Text = TextHelper.GetPrintableText(this.Bytes, this.TextEncoding);
        }

		/// <summary>
		/// 指定位置に一番近いHexバイトの先頭の文字位置を取得する
		/// </summary>
		/// <param name="point">hexTextBox内のクライアント座標</param>
		private int getHeadCharIndexFromPosition(Point point)
		{
			var charIndex = hexTextBox.GetCharIndexFromPosition(point);
			if (charIndex % 3 != 0) {
				charIndex -= charIndex % 3;
			}
			return charIndex;
		}

		/// <summary>
		/// 現在ヘキサビューで選択している部分のバイト配列を取得する
		/// 1byte分も選択されていない場合は要素数0のバイト配列を返す
		/// nullを返すわけではないので注意
		/// </summary>
		/// <returns></returns>
		private byte[] getSelectedBytes()
		{
			var selectedText = hexTextBox.SelectedText.Trim();
			if (selectedText.Length < 2) {
				return new byte[0];
			}

			return HexConverter.ToBytes(hexTextBox.SelectedText);
		}

		#region クイックビュー関連

		/// <summary>
		/// クイックビューのタイプ
		/// </summary>
		private enum QuickViewType
		{
			Off,
			Byte,
			Int16,
			Int32,
			Int64,
			Single,
		}

		/// <summary>
		/// 前のバイト配列のインデックスを記憶するフィールド
		/// </summary>
		private int oldByteIndex = -1;

		/// <summary>
		/// 現在のクイックビュータイプ
		/// </summary>
		private QuickViewType currentQuickViewType = QuickViewType.Off;

		/// <summary>
		/// ヘキサビューの上をマウスカーソルが動いたとき
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void hexTextBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (currentQuickViewType == QuickViewType.Off) {
				if (quickViewToolTip.Active) {
					quickViewToolTip.Hide(hexTextBox);
				}
				return;
			}

			// Off以外のクイックビュー状態のときはツールチップに情報を表示する
			var charIndex = getHeadCharIndexFromPosition(e.Location);
			var byteIndex = charIndex / 3;
			if (byteIndex == oldByteIndex) {
				return;
			}
			oldByteIndex = byteIndex;

			hexTextBox.Focus();
			showQuickView(byteIndex, currentQuickViewType);
		}

		/// <summary>
		/// ヘキサビューが非アクティブになったときツールチップを隠す
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HexViewControl_Leave(object sender, EventArgs e)
		{
			if (quickViewToolTip.Active) {
				quickViewToolTip.Hide(hexTextBox);
			}
		}

		/// <summary>
		/// クイックビュータイプを切り替える
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="type"></param>
		private void setQuickView(Button sender, QuickViewType type)
		{
			offViewButton.BackColor = SystemColors.Control;
			byteViewButton.BackColor = SystemColors.Control;
			int16ViewButton.BackColor = SystemColors.Control;
			int32ViewButton.BackColor = SystemColors.Control;
			int64ViewButton.BackColor = SystemColors.Control;
			singleViewButton.BackColor = SystemColors.Control;

			sender.BackColor = Color.LightCoral;
			currentQuickViewType = type;
		}

		/// <summary>
		/// クイックビューを表示
		/// </summary>
		/// <param name="startIndex"></param>
		/// <param name="type"></param>
		private void showQuickView(int startIndex, QuickViewType type)
		{
			var source = Bytes.Skip(startIndex).ToArray();
			var showString = string.Empty;

			switch (type) {
			case QuickViewType.Byte:
				if (source.Length < sizeof(Byte))
					return;
				hexTextBox.Select(startIndex * 3, sizeof(Byte) * 3);
				showString = string.Format("{0:#,0} (unsigned: {1:#,0})",
					(SByte)source[0],
					(Byte)source[0]);
				break;

			case QuickViewType.Int16:
				if (source.Length < sizeof(Int16))
					return;
				hexTextBox.Select(startIndex * 3, sizeof(Int16) * 3);
				showString = string.Format("{0:#,0} (unsigned: {1:#,0})",
					BitConverter.ToInt16(source, 0),
					BitConverter.ToUInt16(source, 0));
				break;

			case QuickViewType.Int32:
				if (source.Length < sizeof(Int32))
					return;
				hexTextBox.Select(startIndex * 3, sizeof(Int32) * 3);
				showString = string.Format("{0:#,0} (unsigned: {1:#,0})",
					BitConverter.ToInt32(source, 0),
					BitConverter.ToUInt32(source, 0));
				break;

			case QuickViewType.Int64:
				if (source.Length < sizeof(Int64))
					return;
				hexTextBox.Select(startIndex * 3, sizeof(Int64) * 3);
				showString = string.Format("{0:#,0} (unsigned: {1:#,0})",
					BitConverter.ToInt64(source, 0),
					BitConverter.ToUInt64(source, 0));
				break;

			case QuickViewType.Single:
				if (source.Length < sizeof(Single))
					return;
				hexTextBox.Select(startIndex * 3, sizeof(Single) * 3);
				showString = string.Format("{0}", BitConverter.ToSingle(source, 0));
				break;
			}

			var point = hexTextBox.PointToClient(Cursor.Position);
			point.Offset(0, 15);
			quickViewToolTip.Show(showString, hexTextBox, point);
		}

		#region 各種クイックビューボタンをクリックしたとき

		private void offViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(offViewButton, QuickViewType.Off);
		}

		private void byteViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(byteViewButton, QuickViewType.Byte);
		}

		private void int16ViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(int16ViewButton, QuickViewType.Int16);
		}

		private void int32ViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(int32ViewButton, QuickViewType.Int32);
		}

		private void int64ViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(int64ViewButton, QuickViewType.Int64);
		}

		private void singleViewButton_Click(object sender, EventArgs e)
		{
			setQuickView(singleViewButton, QuickViewType.Single);
		}

		#endregion 

		#endregion 

		#region 検索関連

		/// <summary>
		/// 検索のタイプ
		/// </summary>
		private enum SearchType
		{
			Hex,
			SByte,
			Byte,
			Int16,
			UInt16,
			Int32,
			UInt32,
			Int64,
			UInt64,
			Single,
		}

		/// <summary>
		/// このコントロールが読み込まれたとき
		/// 検索のタイプを選択できるボックスを作る
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HexViewControl_Load(object sender, EventArgs e)
		{
			foreach (var type in Enum.GetValues(typeof(SearchType))) {
				searchTypeComboBox.Items.Add((SearchType)type);
			}
			searchTypeComboBox.SelectedIndex = 0;
		}

		/// <summary>
		/// 検索ボックスのテキストが更新されたとき
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void searchContentComboBox_TextUpdate(object sender, EventArgs e)
		{
			doSearch();
		}

		/// <summary>
		/// 検索タイプが変更されたとき
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void searchTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			doSearch();
		}

		/// <summary>
		/// 検索を実行
		/// </summary>
		private void doSearch()
		{
			var currentSearchType = (SearchType)searchTypeComboBox.SelectedItem;
			byte[] searchBytes = null;

			try {
				switch (currentSearchType) {
				case SearchType.Hex:
					searchBytes = HexConverter.ToBytes(searchContentComboBox.Text);
					break;

				case SearchType.Byte:
					searchBytes = new byte[] { byte.Parse(searchContentComboBox.Text) };
					break;

				case SearchType.Int16:
					searchBytes = BitConverter.GetBytes(Int16.Parse(searchContentComboBox.Text));
					break;

				case SearchType.UInt16:
					searchBytes = BitConverter.GetBytes(UInt16.Parse(searchContentComboBox.Text));
					break;

				case SearchType.Int32:
					searchBytes = BitConverter.GetBytes(Int32.Parse(searchContentComboBox.Text));
					break;

				case SearchType.UInt32:
					searchBytes = BitConverter.GetBytes(UInt32.Parse(searchContentComboBox.Text));
					break;

				case SearchType.Int64:
					searchBytes = BitConverter.GetBytes(Int64.Parse(searchContentComboBox.Text));
					break;

				case SearchType.UInt64:
					searchBytes = BitConverter.GetBytes(UInt64.Parse(searchContentComboBox.Text));
					break;

				case SearchType.Single:
					searchBytes = BitConverter.GetBytes(Single.Parse(searchContentComboBox.Text));
					break;
				}

				if (searchBytes != null) {
					highlightHex(HexConverter.ToHex(searchBytes));
				}
			}
			catch {
				clearHighlight();
				return;
			}
		}

		/// <summary>
		/// 指定したヘキサテキストをハイライトする
		/// </summary>
		/// <param name="keyword"></param>
		private void highlightHex(string keyword)
		{
			var regex = new Regex(keyword);
			clearHighlight();
			foreach (Match match in regex.Matches(hexTextBox.Text)) {
				hexTextBox.Select(match.Index, match.Length);
				hexTextBox.SelectionBackColor = Color.LightCoral;
			}
		}

		/// <summary>
		/// ハイライトを全て解除する
		/// </summary>
		private void clearHighlight()
		{
			hexTextBox.SelectAll();
			hexTextBox.SelectionBackColor = hexTextBox.BackColor;
			hexTextBox.SelectionColor = hexTextBox.ForeColor;
			hexTextBox.SelectionLength = 0;
		}

		#endregion

		#region 右クリックメニュー関連

		/// <summary>
		/// ヘキサ表示ボックスの中でクリックしたときのイベント
		/// 右クリックメニューを出す処理
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void hexTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (getSelectedBytes().Length < 2) {
				var charIndex = getHeadCharIndexFromPosition(e.Location);
				hexTextBox.Select(charIndex, 3);
			}

			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				var selectedBytes = getSelectedBytes();
				var showPosition = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 10);
				switch (selectedBytes.Length) {
				case sizeof(Byte):
					byteContextMenuStrip.Show(showPosition);
					break;

				case sizeof(Int16):
					int16ContextMenuStrip.Show(showPosition);
					break;

				case sizeof(Int32):
					int32AndSingleContextMenuStrip.Show(showPosition);
					break;

				case sizeof(Int64):
					int64ContextMenuStrip.Show(showPosition);
					break;
				}
			}
		}

		#region 各種右クリックメニューをクリックしたとき

		private void copyAsSByteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(((SByte)getSelectedBytes()[0]).ToString());
		}

		private void copyAsByteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(getSelectedBytes()[0].ToString());
		}

		private void copyAsInt16ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToInt16(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsUInt16ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToUInt16(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsInt32ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToInt32(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsUInt32ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToUInt32(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsInt64ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToInt64(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsUInt64ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToUInt64(getSelectedBytes(), 0).ToString()
			);
		}

		private void copyAsSingleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(
				BitConverter.ToSingle(getSelectedBytes(), 0).ToString()
			);
		}

		#endregion





		#endregion 
	}
}
