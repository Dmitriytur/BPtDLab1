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
			this.SuspendLayout();
			// 
			// mainTextBox
			// 
			this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mainTextBox.Location = new System.Drawing.Point(0, 0);
			this.mainTextBox.Name = "mainTextBox";
			this.mainTextBox.Size = new System.Drawing.Size(756, 452);
			this.mainTextBox.TabIndex = 0;
			this.mainTextBox.Text = "";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 452);
			this.Controls.Add(this.mainTextBox);
			this.Name = "MainWindow";
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox mainTextBox;
	}
}

