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
			byte[] message = new byte[32];
			for (int i = 0; i < message.Length; i++)
			{
				message[i] = (byte)(i+1);
			}
			//long key = BitConverter.ToInt64(BitConverter.GetBytes(0xaabb09182736ccdd), 0);
			long key = 10001241012350000;
	
			byte[] cryptogram = DESProvider.Encrypt(message, key);
			
			for (int i = 0; i < cryptogram.Length; i++)
			{
				//WindowConsole.Write(cryptogram[i].ToString() + ' ');
			}
			message = DESProvider.Decrypt(cryptogram, key);

			//WindowConsole.WriteLine("");
			for (int i = 0; i < cryptogram.Length; i++)
			{
				WindowConsole.Write(message[i].ToString() + ' ');
			}
			WindowConsole.WriteLine("");
		}
	}
}
