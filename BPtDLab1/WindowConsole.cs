using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	static class WindowConsole
	{
		public static RichTextBox textBox { set; get; }

		public static void WriteLine(string value)
		{
			textBox.Text += value + '\n';
		}
	}
}
