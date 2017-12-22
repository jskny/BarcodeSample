namespace BarcodeSample
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
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panelBarcode = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.panelQRCode = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input Form";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(8, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(246, 31);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panelBarcode);
			this.groupBox2.Location = new System.Drawing.Point(13, 95);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(259, 115);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Barcode";
			// 
			// panelBarcode
			// 
			this.panelBarcode.BackColor = System.Drawing.Color.Cornsilk;
			this.panelBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBarcode.Cursor = System.Windows.Forms.Cursors.Default;
			this.panelBarcode.Location = new System.Drawing.Point(7, 19);
			this.panelBarcode.Name = "panelBarcode";
			this.panelBarcode.Size = new System.Drawing.Size(246, 90);
			this.panelBarcode.TabIndex = 0;
			this.panelBarcode.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarcode_Paint);
			this.panelBarcode.Resize += new System.EventHandler(this.panelBarcode_Resize);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.helpHToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(457, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileFToolStripMenuItem
			// 
			this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitEToolStripMenuItem});
			this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
			this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.fileFToolStripMenuItem.Text = "File(&F)";
			// 
			// exitEToolStripMenuItem
			// 
			this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
			this.exitEToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.exitEToolStripMenuItem.Text = "Exit(&E)";
			this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
			// 
			// helpHToolStripMenuItem
			// 
			this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
			this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
			this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.helpHToolStripMenuItem.Text = "Help(&H)";
			// 
			// aboutAToolStripMenuItem
			// 
			this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
			this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.aboutAToolStripMenuItem.Text = "About(&A)";
			this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panelQRCode);
			this.groupBox3.Location = new System.Drawing.Point(278, 27);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(172, 183);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "QR Code";
			// 
			// panelQRCode
			// 
			this.panelQRCode.BackColor = System.Drawing.Color.AliceBlue;
			this.panelQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelQRCode.Cursor = System.Windows.Forms.Cursors.Default;
			this.panelQRCode.Location = new System.Drawing.Point(6, 18);
			this.panelQRCode.Name = "panelQRCode";
			this.panelQRCode.Size = new System.Drawing.Size(158, 158);
			this.panelQRCode.TabIndex = 0;
			this.panelQRCode.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQRCode_Paint);
			this.panelQRCode.Resize += new System.EventHandler(this.panelQRCode_Resize);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 217);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Barcode Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panelBarcode;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panelQRCode;
	}
}

