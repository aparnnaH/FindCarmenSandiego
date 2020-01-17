namespace SplashScreen_FP
{
	partial class frmGraffitiWall
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
			this.components = new System.ComponentModel.Container();
			this.tmr1 = new System.Windows.Forms.Timer(this.components);
			this.picTHought = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picTHought)).BeginInit();
			this.SuspendLayout();
			// 
			// tmr1
			// 
			this.tmr1.Interval = 1000;
			this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
			// 
			// picTHought
			// 
			this.picTHought.BackColor = System.Drawing.Color.Transparent;
			this.picTHought.Image = global::FindCarmenSandiego.Properties.Resources.dialogue;
			this.picTHought.Location = new System.Drawing.Point(3, 407);
			this.picTHought.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picTHought.Name = "picTHought";
			this.picTHought.Size = new System.Drawing.Size(661, 172);
			this.picTHought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTHought.TabIndex = 0;
			this.picTHought.TabStop = false;
			this.picTHought.Visible = false;
			this.picTHought.Click += new System.EventHandler(this.picTHought_Click);
			// 
			// frmGraffitiWall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.graffiti;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1179, 612);
			this.Controls.Add(this.picTHought);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmGraffitiWall";
			this.Text = "frmGraffitiWall";
			this.Click += new System.EventHandler(this.frmGraffitiWall_Click);
			((System.ComponentModel.ISupportInitialize)(this.picTHought)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmr1;
		private System.Windows.Forms.PictureBox picTHought;
	}
}