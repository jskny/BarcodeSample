using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeSample
{
	public partial class Form1 : Form
	{
		protected DotNetBarcode bc1 = null;
		protected DotNetBarcode bcQR = null;

		public Form1()
		{
			InitializeComponent();

			this.bc1 = new DotNetBarcode();
			this.bcQR = new DotNetBarcode();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.bc1.Type = DotNetBarcode.Types.Code39;
			this.bc1.PrintCheckDigitChar = true;

			this.bcQR.Type = DotNetBarcode.Types.QRCode;
			this.bcQR.PrintCheckDigitChar = true;
		}

		private void panelBarcode_Paint(object sender, PaintEventArgs e)
		{
			this.bc1.WriteBar(this.textBox1.Text, 0, 0, this.panelBarcode.Size.Width, this.panelBarcode.Size.Height, e.Graphics);
		}

		private void panelBarcode_Resize(object sender, EventArgs e)
		{
			this.panelBarcode.Refresh();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.panelBarcode.Refresh();
			this.panelQRCode.Refresh();
		}

		private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Version beta.\n" +
				"\n" +
				"This App was created by jskny at 2017.\n" +
				"\n" +
				"And this app is using DotNetBarcode."
				, "Version info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void panelQRCode_Paint(object sender, PaintEventArgs e)
		{
			// QRコードを中央に表示したいのだが、うまくいかない
			// this.bcQR.QRWriteBar(this.textBox1.Text, this.panelQRCode.Size.Width, this.panelQRCode.Size.Height, 4, e.Graphics);
			this.bcQR.WriteBar(this.textBox1.Text, 0, 0, this.panelQRCode.Size.Width, this.panelQRCode.Size.Height, e.Graphics);
		}

		private void panelQRCode_Resize(object sender, EventArgs e)
		{
			this.panelQRCode.Refresh();
		}
	}
}
