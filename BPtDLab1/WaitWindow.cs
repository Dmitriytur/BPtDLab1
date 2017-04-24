﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPtDLab1
{
	public partial class WaitWindow : Form
	{
		Socket sListener;
		string address;
		int port;
		long key;
		bool stop;

		public WaitWindow(string address, int port, long key)
		{
			InitializeComponent();
			this.address = address;
			this.port = port;
			this.key = key;
			stop = false;
			Thread listenerThread = new Thread(new ThreadStart(WaitForConnection));
			listenerThread.Start();
		}

		private void WaitForConnection()
		{
			IPHostEntry ipHost = Dns.GetHostEntry(address);
			IPAddress ipAddr = ipHost.AddressList[0];
			IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

			sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			sListener.Bind(ipEndPoint);
			sListener.Listen(10);
			while (true)
			{
				Thread.Sleep(100);
				Socket handler = sListener.Accept();
			
				var chatWindow = new ChatWindow(handler, key);
				Action action = () => chatWindow.Show();
				Invoke(action);

				if (stop)
				{
					sListener.Shutdown(SocketShutdown.Both);
					sListener.Close();
					break;
				}
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			stop = true;
			sListener.Shutdown(SocketShutdown.Both);
			sListener.Close();
			Close();
		}
	}
}