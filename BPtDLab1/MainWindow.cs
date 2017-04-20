using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			WindowConsole.textBox = mainTextBox;
		}

		private void testButton_Click(object sender, EventArgs e)
		{
			byte[] message = new byte[30];
			for (int i = 0; i < 30; i++)
			{
				message[i] = (byte)i;
			}
			long key = KeyGenerator.GenerateKey();
			byte[] cryptogram = DESProvider.Encrypt(message, key);
			
			for (int i = 0; i < cryptogram.Length; i++)
			{
				WindowConsole.Write(cryptogram[i].ToString() + ' ');
			}
			message = DESProvider.Decrypt(cryptogram, key);

			WindowConsole.WriteLine("");
			for (int i = 0; i < cryptogram.Length; i++)
			{
				WindowConsole.Write(message[i].ToString() + ' ');
			}
			WindowConsole.WriteLine("");
		}
	}
}
