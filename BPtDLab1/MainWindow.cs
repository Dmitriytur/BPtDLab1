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
			byte[] message = { 1, 2, 3, 4, 5, 6, 7, 8 };
			byte[] cryptogram = DESProvider.Encrypt(message, 0);
			for (int i = 0; i < cryptogram.Length; i++)
			{
				WindowConsole.WriteLine(cryptogram[i].ToString());
			}
			
		}
	}
}
