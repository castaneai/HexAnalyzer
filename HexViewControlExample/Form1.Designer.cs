namespace HexViewControlExample
{
	partial class Form1
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.hexViewControl1 = new HexAnalyzer.HexViewControl();
			this.SuspendLayout();
			// 
			// hexViewControl1
			// 
			this.hexViewControl1.Bytes = new byte[] {
        ((byte)(10)),
        ((byte)(11)),
        ((byte)(28)),
        ((byte)(255)),
        ((byte)(101)),
        ((byte)(50)),
        ((byte)(153)),
        ((byte)(16)),
        ((byte)(48)),
        ((byte)(49)),
        ((byte)(49)),
        ((byte)(49)),
        ((byte)(50)),
        ((byte)(51)),
        ((byte)(52)),
        ((byte)(70)),
        ((byte)(17))};
			this.hexViewControl1.Location = new System.Drawing.Point(12, 10);
			this.hexViewControl1.Name = "hexViewControl1";
			this.hexViewControl1.Size = new System.Drawing.Size(461, 359);
			this.hexViewControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 381);
			this.Controls.Add(this.hexViewControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private HexAnalyzer.HexViewControl hexViewControl1;





	}
}

