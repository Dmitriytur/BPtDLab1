﻿using System;
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
	public partial class ChatWindow : Form
	{
		public ChatWindow()
		{
			InitializeComponent();
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			chatBox.Text += "You >> " + messageBox.Text + '\n';
			messageBox.Clear();
		}
	}
}