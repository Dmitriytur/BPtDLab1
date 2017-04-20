namespace BPtDLab1
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainTextBox = new System.Windows.Forms.RichTextBox();
			this.testButton = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTextBox
			// 
			this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mainTextBox.Location = new System.Drawing.Point(0, 0);
			this.mainTextBox.Name = "mainTextBox";
			this.mainTextBox.Size = new System.Drawing.Size(1126, 362);
			this.mainTextBox.TabIndex = 0;
			this.mainTextBox.Text = "";
			// 
			// testButton
			// 
			this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.testButton.Location = new System.Drawing.Point(348, 24);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(101, 31);
			this.testButton.TabIndex = 1;
			this.testButton.Text = "Test";
			this.testButton.UseVisualStyleBackColor = true;
			this.testButton.Click += new System.EventHandler(this.testButton_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.mainTextBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.testButton);
			this.splitContainer1.Size = new System.Drawing.Size(1126, 452);
			this.splitContainer1.SplitterDistance = 362;
			this.splitContainer1.TabIndex = 2;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1126, 452);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MainWindow";
			this.Text = "Main";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox mainTextBox;
		private System.Windows.Forms.Button testButton;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

