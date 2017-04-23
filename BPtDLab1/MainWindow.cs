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
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void generateKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new KeyGenWindow().Show();
		}

		private void openChatButton_Click(object sender, EventArgs e)
		{
			new ChatWindow().Show();
		}
	}
}
