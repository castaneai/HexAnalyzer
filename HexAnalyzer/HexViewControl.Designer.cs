namespace HexAnalyzer
{
	partial class HexViewControl
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.hexTextBox = new System.Windows.Forms.RichTextBox();
			this.quickViewToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
			this.searchContentComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.byteViewButton = new System.Windows.Forms.Button();
			this.int16ViewButton = new System.Windows.Forms.Button();
			this.int32ViewButton = new System.Windows.Forms.Button();
			this.hexSplitContainer = new System.Windows.Forms.SplitContainer();
			this.stringTextBox = new System.Windows.Forms.RichTextBox();
			this.offViewButton = new System.Windows.Forms.Button();
			this.int64ViewButton = new System.Windows.Forms.Button();
			this.singleViewButton = new System.Windows.Forms.Button();
			this.byteContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyByteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAsByteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.int16ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyAsInt16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAsUInt16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.int32AndSingleContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyAsInt32ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAsUInt32ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAsSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.int64ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyAsInt64ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAsUInt64ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.singleContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyAsSingleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.hexSplitContainer)).BeginInit();
			this.hexSplitContainer.Panel1.SuspendLayout();
			this.hexSplitContainer.Panel2.SuspendLayout();
			this.hexSplitContainer.SuspendLayout();
			this.byteContextMenuStrip.SuspendLayout();
			this.int16ContextMenuStrip.SuspendLayout();
			this.int32AndSingleContextMenuStrip.SuspendLayout();
			this.int64ContextMenuStrip.SuspendLayout();
			this.singleContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// hexTextBox
			// 
			this.hexTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.hexTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.hexTextBox.ForeColor = System.Drawing.SystemColors.Window;
			this.hexTextBox.Location = new System.Drawing.Point(0, 0);
			this.hexTextBox.Name = "hexTextBox";
			this.hexTextBox.ReadOnly = true;
			this.hexTextBox.Size = new System.Drawing.Size(292, 269);
			this.hexTextBox.TabIndex = 0;
			this.hexTextBox.Text = "0A 0B 1C FF 65 32 99 10 30 31 31 31 32 33 34 46 11";
			this.hexTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hexTextBox_MouseDown);
			this.hexTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hexTextBox_MouseMove);
			// 
			// searchTypeComboBox
			// 
			this.searchTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchTypeComboBox.FormattingEnabled = true;
			this.searchTypeComboBox.Location = new System.Drawing.Point(342, 35);
			this.searchTypeComboBox.Name = "searchTypeComboBox";
			this.searchTypeComboBox.Size = new System.Drawing.Size(95, 20);
			this.searchTypeComboBox.TabIndex = 1;
			this.searchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.searchTypeComboBox_SelectedIndexChanged);
			// 
			// searchContentComboBox
			// 
			this.searchContentComboBox.FormattingEnabled = true;
			this.searchContentComboBox.Location = new System.Drawing.Point(46, 35);
			this.searchContentComboBox.Name = "searchContentComboBox";
			this.searchContentComboBox.Size = new System.Drawing.Size(290, 20);
			this.searchContentComboBox.TabIndex = 2;
			this.searchContentComboBox.TextUpdate += new System.EventHandler(this.searchContentComboBox_TextUpdate);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Quick View: ";
			// 
			// byteViewButton
			// 
			this.byteViewButton.Location = new System.Drawing.Point(134, 64);
			this.byteViewButton.Name = "byteViewButton";
			this.byteViewButton.Size = new System.Drawing.Size(55, 23);
			this.byteViewButton.TabIndex = 5;
			this.byteViewButton.Text = "Byte";
			this.byteViewButton.UseVisualStyleBackColor = true;
			this.byteViewButton.Click += new System.EventHandler(this.byteViewButton_Click);
			// 
			// int16ViewButton
			// 
			this.int16ViewButton.Location = new System.Drawing.Point(195, 64);
			this.int16ViewButton.Name = "int16ViewButton";
			this.int16ViewButton.Size = new System.Drawing.Size(55, 23);
			this.int16ViewButton.TabIndex = 6;
			this.int16ViewButton.Text = "Int16";
			this.int16ViewButton.UseVisualStyleBackColor = true;
			this.int16ViewButton.Click += new System.EventHandler(this.int16ViewButton_Click);
			// 
			// int32ViewButton
			// 
			this.int32ViewButton.Location = new System.Drawing.Point(256, 64);
			this.int32ViewButton.Name = "int32ViewButton";
			this.int32ViewButton.Size = new System.Drawing.Size(55, 23);
			this.int32ViewButton.TabIndex = 7;
			this.int32ViewButton.Text = "Int32";
			this.int32ViewButton.UseVisualStyleBackColor = true;
			this.int32ViewButton.Click += new System.EventHandler(this.int32ViewButton_Click);
			// 
			// hexSplitContainer
			// 
			this.hexSplitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.hexSplitContainer.Location = new System.Drawing.Point(0, 90);
			this.hexSplitContainer.Name = "hexSplitContainer";
			// 
			// hexSplitContainer.Panel1
			// 
			this.hexSplitContainer.Panel1.Controls.Add(this.hexTextBox);
			// 
			// hexSplitContainer.Panel2
			// 
			this.hexSplitContainer.Panel2.Controls.Add(this.stringTextBox);
			this.hexSplitContainer.Size = new System.Drawing.Size(440, 269);
			this.hexSplitContainer.SplitterDistance = 292;
			this.hexSplitContainer.TabIndex = 9;
			// 
			// stringTextBox
			// 
			this.stringTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.stringTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stringTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.stringTextBox.ForeColor = System.Drawing.SystemColors.Window;
			this.stringTextBox.Location = new System.Drawing.Point(0, 0);
			this.stringTextBox.Name = "stringTextBox";
			this.stringTextBox.ReadOnly = true;
			this.stringTextBox.Size = new System.Drawing.Size(144, 269);
			this.stringTextBox.TabIndex = 1;
			this.stringTextBox.Text = "俺はキルミーを名作だと思ってるけど ";
			// 
			// offViewButton
			// 
			this.offViewButton.BackColor = System.Drawing.Color.LightCoral;
			this.offViewButton.Location = new System.Drawing.Point(73, 64);
			this.offViewButton.Name = "offViewButton";
			this.offViewButton.Size = new System.Drawing.Size(55, 23);
			this.offViewButton.TabIndex = 10;
			this.offViewButton.Text = "OFF";
			this.offViewButton.UseVisualStyleBackColor = false;
			this.offViewButton.Click += new System.EventHandler(this.offViewButton_Click);
			// 
			// int64ViewButton
			// 
			this.int64ViewButton.Location = new System.Drawing.Point(317, 64);
			this.int64ViewButton.Name = "int64ViewButton";
			this.int64ViewButton.Size = new System.Drawing.Size(55, 23);
			this.int64ViewButton.TabIndex = 11;
			this.int64ViewButton.Text = "Int64";
			this.int64ViewButton.UseVisualStyleBackColor = true;
			this.int64ViewButton.Click += new System.EventHandler(this.int64ViewButton_Click);
			// 
			// singleViewButton
			// 
			this.singleViewButton.Location = new System.Drawing.Point(378, 64);
			this.singleViewButton.Name = "singleViewButton";
			this.singleViewButton.Size = new System.Drawing.Size(55, 23);
			this.singleViewButton.TabIndex = 12;
			this.singleViewButton.Text = "Single";
			this.singleViewButton.UseVisualStyleBackColor = true;
			this.singleViewButton.Click += new System.EventHandler(this.singleViewButton_Click);
			// 
			// byteContextMenuStrip
			// 
			this.byteContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyByteToolStripMenuItem,
            this.copyAsByteToolStripMenuItem});
			this.byteContextMenuStrip.Name = "byteContextMenuStrip";
			this.byteContextMenuStrip.Size = new System.Drawing.Size(160, 48);
			// 
			// copyByteToolStripMenuItem
			// 
			this.copyByteToolStripMenuItem.Name = "copyByteToolStripMenuItem";
			this.copyByteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.copyByteToolStripMenuItem.Text = "Copy as SByte";
			this.copyByteToolStripMenuItem.Click += new System.EventHandler(this.copyAsSByteToolStripMenuItem_Click);
			// 
			// copyAsByteToolStripMenuItem
			// 
			this.copyAsByteToolStripMenuItem.Name = "copyAsByteToolStripMenuItem";
			this.copyAsByteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.copyAsByteToolStripMenuItem.Text = "Copy as Byte";
			this.copyAsByteToolStripMenuItem.Click += new System.EventHandler(this.copyAsByteToolStripMenuItem_Click);
			// 
			// int16ContextMenuStrip
			// 
			this.int16ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsInt16ToolStripMenuItem,
            this.copyAsUInt16ToolStripMenuItem});
			this.int16ContextMenuStrip.Name = "byteContextMenuStrip";
			this.int16ContextMenuStrip.Size = new System.Drawing.Size(165, 48);
			// 
			// copyAsInt16ToolStripMenuItem
			// 
			this.copyAsInt16ToolStripMenuItem.Name = "copyAsInt16ToolStripMenuItem";
			this.copyAsInt16ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copyAsInt16ToolStripMenuItem.Text = "Copy as Int16";
			this.copyAsInt16ToolStripMenuItem.Click += new System.EventHandler(this.copyAsInt16ToolStripMenuItem_Click);
			// 
			// copyAsUInt16ToolStripMenuItem
			// 
			this.copyAsUInt16ToolStripMenuItem.Name = "copyAsUInt16ToolStripMenuItem";
			this.copyAsUInt16ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copyAsUInt16ToolStripMenuItem.Text = "Copy as UInt16";
			this.copyAsUInt16ToolStripMenuItem.Click += new System.EventHandler(this.copyAsUInt16ToolStripMenuItem_Click);
			// 
			// int32AndSingleContextMenuStrip
			// 
			this.int32AndSingleContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsInt32ToolStripMenuItem1,
            this.copyAsUInt32ToolStripMenuItem2,
            this.copyAsSingleToolStripMenuItem});
			this.int32AndSingleContextMenuStrip.Name = "byteContextMenuStrip";
			this.int32AndSingleContextMenuStrip.Size = new System.Drawing.Size(165, 70);
			// 
			// copyAsInt32ToolStripMenuItem1
			// 
			this.copyAsInt32ToolStripMenuItem1.Name = "copyAsInt32ToolStripMenuItem1";
			this.copyAsInt32ToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
			this.copyAsInt32ToolStripMenuItem1.Text = "Copy as Int32";
			this.copyAsInt32ToolStripMenuItem1.Click += new System.EventHandler(this.copyAsInt32ToolStripMenuItem1_Click);
			// 
			// copyAsUInt32ToolStripMenuItem2
			// 
			this.copyAsUInt32ToolStripMenuItem2.Name = "copyAsUInt32ToolStripMenuItem2";
			this.copyAsUInt32ToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
			this.copyAsUInt32ToolStripMenuItem2.Text = "Copy as UInt32";
			this.copyAsUInt32ToolStripMenuItem2.Click += new System.EventHandler(this.copyAsUInt32ToolStripMenuItem2_Click);
			// 
			// copyAsSingleToolStripMenuItem
			// 
			this.copyAsSingleToolStripMenuItem.Name = "copyAsSingleToolStripMenuItem";
			this.copyAsSingleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copyAsSingleToolStripMenuItem.Text = "Copy as Single";
			this.copyAsSingleToolStripMenuItem.Click += new System.EventHandler(this.copyAsSingleToolStripMenuItem_Click);
			// 
			// int64ContextMenuStrip
			// 
			this.int64ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsInt64ToolStripMenuItem1,
            this.copyAsUInt64ToolStripMenuItem2});
			this.int64ContextMenuStrip.Name = "byteContextMenuStrip";
			this.int64ContextMenuStrip.Size = new System.Drawing.Size(165, 48);
			// 
			// copyAsInt64ToolStripMenuItem1
			// 
			this.copyAsInt64ToolStripMenuItem1.Name = "copyAsInt64ToolStripMenuItem1";
			this.copyAsInt64ToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
			this.copyAsInt64ToolStripMenuItem1.Text = "Copy as Int64";
			this.copyAsInt64ToolStripMenuItem1.Click += new System.EventHandler(this.copyAsInt64ToolStripMenuItem1_Click);
			// 
			// copyAsUInt64ToolStripMenuItem2
			// 
			this.copyAsUInt64ToolStripMenuItem2.Name = "copyAsUInt64ToolStripMenuItem2";
			this.copyAsUInt64ToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
			this.copyAsUInt64ToolStripMenuItem2.Text = "Copy as UInt64";
			this.copyAsUInt64ToolStripMenuItem2.Click += new System.EventHandler(this.copyAsUInt64ToolStripMenuItem2_Click);
			// 
			// singleContextMenuStrip1
			// 
			this.singleContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsSingleToolStripMenuItem1});
			this.singleContextMenuStrip1.Name = "byteContextMenuStrip";
			this.singleContextMenuStrip1.Size = new System.Drawing.Size(160, 26);
			// 
			// copyAsSingleToolStripMenuItem1
			// 
			this.copyAsSingleToolStripMenuItem1.Name = "copyAsSingleToolStripMenuItem1";
			this.copyAsSingleToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
			this.copyAsSingleToolStripMenuItem1.Text = "Copy as Single";
			// 
			// HexViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.singleViewButton);
			this.Controls.Add(this.int64ViewButton);
			this.Controls.Add(this.offViewButton);
			this.Controls.Add(this.hexSplitContainer);
			this.Controls.Add(this.int32ViewButton);
			this.Controls.Add(this.int16ViewButton);
			this.Controls.Add(this.byteViewButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.searchContentComboBox);
			this.Controls.Add(this.searchTypeComboBox);
			this.Name = "HexViewControl";
			this.Size = new System.Drawing.Size(440, 359);
			this.Load += new System.EventHandler(this.HexViewControl_Load);
			this.Leave += new System.EventHandler(this.HexViewControl_Leave);
			this.hexSplitContainer.Panel1.ResumeLayout(false);
			this.hexSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hexSplitContainer)).EndInit();
			this.hexSplitContainer.ResumeLayout(false);
			this.byteContextMenuStrip.ResumeLayout(false);
			this.int16ContextMenuStrip.ResumeLayout(false);
			this.int32AndSingleContextMenuStrip.ResumeLayout(false);
			this.int64ContextMenuStrip.ResumeLayout(false);
			this.singleContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox hexTextBox;
		private System.Windows.Forms.ToolTip quickViewToolTip;
		private System.Windows.Forms.ComboBox searchTypeComboBox;
		private System.Windows.Forms.ComboBox searchContentComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button byteViewButton;
		private System.Windows.Forms.Button int16ViewButton;
		private System.Windows.Forms.Button int32ViewButton;
		private System.Windows.Forms.SplitContainer hexSplitContainer;
		private System.Windows.Forms.RichTextBox stringTextBox;
		private System.Windows.Forms.Button offViewButton;
		private System.Windows.Forms.Button int64ViewButton;
		private System.Windows.Forms.Button singleViewButton;
		private System.Windows.Forms.ContextMenuStrip byteContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyByteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyAsByteToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip int16ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyAsInt16ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyAsUInt16ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip int32AndSingleContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyAsInt32ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyAsUInt32ToolStripMenuItem2;
		private System.Windows.Forms.ContextMenuStrip int64ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyAsInt64ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyAsUInt64ToolStripMenuItem2;
		private System.Windows.Forms.ContextMenuStrip singleContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem copyAsSingleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyAsSingleToolStripMenuItem;
	}
}
