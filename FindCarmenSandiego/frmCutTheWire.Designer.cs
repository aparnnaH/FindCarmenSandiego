namespace CutTheWire
{
    partial class frmCutTheWire
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
			this.lblTime = new System.Windows.Forms.Label();
			this.pbC4 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pbBlack = new System.Windows.Forms.PictureBox();
			this.pbGreyConect = new System.Windows.Forms.PictureBox();
			this.pbGreen = new System.Windows.Forms.PictureBox();
			this.pbBlue = new System.Windows.Forms.PictureBox();
			this.pbRed = new System.Windows.Forms.PictureBox();
			this.tmrTick = new System.Windows.Forms.Timer(this.components);
			this.lblInstruction = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbC4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreyConect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.Gray;
			this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.Red;
			this.lblTime.Location = new System.Drawing.Point(28, 26);
			this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(428, 127);
			this.lblTime.TabIndex = 1;
			this.lblTime.Text = "10:00";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
			// 
			// pbC4
			// 
			this.pbC4.BackColor = System.Drawing.Color.Transparent;
			this.pbC4.Image = global::FindCarmenSandiego.Properties.Resources.C4;
			this.pbC4.Location = new System.Drawing.Point(16, 156);
			this.pbC4.Margin = new System.Windows.Forms.Padding(4);
			this.pbC4.Name = "pbC4";
			this.pbC4.Size = new System.Drawing.Size(455, 353);
			this.pbC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbC4.TabIndex = 7;
			this.pbC4.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBox4.Location = new System.Drawing.Point(31, 482);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(425, 27);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// pbBlack
			// 
			this.pbBlack.BackColor = System.Drawing.Color.Black;
			this.pbBlack.Location = new System.Drawing.Point(16, 15);
			this.pbBlack.Margin = new System.Windows.Forms.Padding(4);
			this.pbBlack.Name = "pbBlack";
			this.pbBlack.Size = new System.Drawing.Size(455, 151);
			this.pbBlack.TabIndex = 0;
			this.pbBlack.TabStop = false;
			// 
			// pbGreyConect
			// 
			this.pbGreyConect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pbGreyConect.Location = new System.Drawing.Point(31, 156);
			this.pbGreyConect.Margin = new System.Windows.Forms.Padding(4);
			this.pbGreyConect.Name = "pbGreyConect";
			this.pbGreyConect.Size = new System.Drawing.Size(425, 44);
			this.pbGreyConect.TabIndex = 2;
			this.pbGreyConect.TabStop = false;
			// 
			// pbGreen
			// 
			this.pbGreen.BackColor = System.Drawing.Color.Transparent;
			this.pbGreen.Image = global::FindCarmenSandiego.Properties.Resources.GreenV2;
			this.pbGreen.Location = new System.Drawing.Point(372, 174);
			this.pbGreen.Margin = new System.Windows.Forms.Padding(4);
			this.pbGreen.Name = "pbGreen";
			this.pbGreen.Size = new System.Drawing.Size(24, 313);
			this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbGreen.TabIndex = 5;
			this.pbGreen.TabStop = false;
			this.pbGreen.Click += new System.EventHandler(this.pbGreen_Click);
			// 
			// pbBlue
			// 
			this.pbBlue.BackColor = System.Drawing.Color.Transparent;
			this.pbBlue.Image = global::FindCarmenSandiego.Properties.Resources.BlueV2;
			this.pbBlue.Location = new System.Drawing.Point(213, 174);
			this.pbBlue.Margin = new System.Windows.Forms.Padding(4);
			this.pbBlue.Name = "pbBlue";
			this.pbBlue.Size = new System.Drawing.Size(24, 313);
			this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbBlue.TabIndex = 4;
			this.pbBlue.TabStop = false;
			this.pbBlue.Click += new System.EventHandler(this.pbBlue_Click);
			// 
			// pbRed
			// 
			this.pbRed.BackColor = System.Drawing.Color.Transparent;
			this.pbRed.Image = global::FindCarmenSandiego.Properties.Resources.RedV2;
			this.pbRed.Location = new System.Drawing.Point(108, 174);
			this.pbRed.Margin = new System.Windows.Forms.Padding(4);
			this.pbRed.Name = "pbRed";
			this.pbRed.Size = new System.Drawing.Size(24, 313);
			this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbRed.TabIndex = 3;
			this.pbRed.TabStop = false;
			this.pbRed.Click += new System.EventHandler(this.pbRed_Click);
			// 
			// tmrTick
			// 
			this.tmrTick.Interval = 1;
			this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
			// 
			// lblInstruction
			// 
			this.lblInstruction.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction.Location = new System.Drawing.Point(14, 513);
			this.lblInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstruction.Name = "lblInstruction";
			this.lblInstruction.Size = new System.Drawing.Size(460, 162);
			this.lblInstruction.TabIndex = 132;
			this.lblInstruction.Text = "Ahhhh... I don\'t know what colour wire to cut?!?!? What\'s Carmen\'s favorite colou" +
    "r? What colous does she always wears?\r\n";
			this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmCutTheWire
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(487, 682);
			this.Controls.Add(this.lblInstruction);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.pbBlack);
			this.Controls.Add(this.pbGreyConect);
			this.Controls.Add(this.pbGreen);
			this.Controls.Add(this.pbBlue);
			this.Controls.Add(this.pbRed);
			this.Controls.Add(this.pbC4);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCutTheWire";
			this.Text = "frmCutTheWire";
			this.Load += new System.EventHandler(this.frmCutTheWire_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbC4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreyConect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pbGreyConect;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbC4;
        private System.Windows.Forms.Timer tmrTick;
		private System.Windows.Forms.Label lblInstruction;
	}
}