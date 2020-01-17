namespace Phone_call
{
	partial class frmPhoneCall
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.picAcceptCall = new System.Windows.Forms.PictureBox();
			this.picEndCall = new System.Windows.Forms.PictureBox();
			this.lblTime = new System.Windows.Forms.Label();
			this.tmrTime = new System.Windows.Forms.Timer(this.components);
			this.lblText = new System.Windows.Forms.Label();
			this.picThought = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picAcceptCall)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEndCall)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picThought)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(55, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Carmen Sandeigo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(168, 92);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mobile";
			// 
			// picAcceptCall
			// 
			this.picAcceptCall.BackColor = System.Drawing.Color.Transparent;
			this.picAcceptCall.Location = new System.Drawing.Point(259, 489);
			this.picAcceptCall.Margin = new System.Windows.Forms.Padding(4);
			this.picAcceptCall.Name = "picAcceptCall";
			this.picAcceptCall.Size = new System.Drawing.Size(133, 122);
			this.picAcceptCall.TabIndex = 4;
			this.picAcceptCall.TabStop = false;
			this.picAcceptCall.Click += new System.EventHandler(this.picAcceptCall_Click);
			// 
			// picEndCall
			// 
			this.picEndCall.BackColor = System.Drawing.Color.Transparent;
			this.picEndCall.Location = new System.Drawing.Point(149, 480);
			this.picEndCall.Margin = new System.Windows.Forms.Padding(4);
			this.picEndCall.Name = "picEndCall";
			this.picEndCall.Size = new System.Drawing.Size(133, 122);
			this.picEndCall.TabIndex = 5;
			this.picEndCall.TabStop = false;
			this.picEndCall.Visible = false;
			this.picEndCall.Click += new System.EventHandler(this.picEndCall_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.BackColor = System.Drawing.Color.Transparent;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(156, 5);
			this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(0, 17);
			this.lblTime.TabIndex = 6;
			// 
			// tmrTime
			// 
			this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
			// 
			// lblText
			// 
			this.lblText.BackColor = System.Drawing.Color.White;
			this.lblText.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblText.Location = new System.Drawing.Point(44, 133);
			this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(350, 65);
			this.lblText.TabIndex = 7;
			this.lblText.Text = "Catch me in Brazil";
			this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblText.Visible = false;
			// 
			// picThought
			// 
			this.picThought.BackColor = System.Drawing.Color.Transparent;
			this.picThought.Image = global::FindCarmenSandiego.Properties.Resources.fieldThought;
			this.picThought.Location = new System.Drawing.Point(34, 130);
			this.picThought.Margin = new System.Windows.Forms.Padding(4);
			this.picThought.Name = "picThought";
			this.picThought.Size = new System.Drawing.Size(368, 93);
			this.picThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picThought.TabIndex = 8;
			this.picThought.TabStop = false;
			this.picThought.Visible = false;
			this.picThought.Click += new System.EventHandler(this.picThought_Click);
			// 
			// frmPhoneCall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.LightGray;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.Phone_calling;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(437, 658);
			this.Controls.Add(this.picThought);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.picEndCall);
			this.Controls.Add(this.picAcceptCall);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmPhoneCall";
			this.Text = "Phone call";
			this.Load += new System.EventHandler(this.frmPhoneCall_Load);
			((System.ComponentModel.ISupportInitialize)(this.picAcceptCall)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEndCall)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picThought)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox picAcceptCall;
		private System.Windows.Forms.PictureBox picEndCall;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer tmrTime;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.PictureBox picThought;
	}
}

