namespace SplashScreen_FP
{
    partial class frmCarmenHistory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarmenHistory));
			this.wmpCarmenHistory = new AxWMPLib.AxWindowsMediaPlayer();
			this.lblSubtitles = new System.Windows.Forms.Label();
			this.tmr1 = new System.Windows.Forms.Timer(this.components);
			this.picEnd = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.wmpCarmenHistory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEnd)).BeginInit();
			this.SuspendLayout();
			// 
			// wmpCarmenHistory
			// 
			this.wmpCarmenHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wmpCarmenHistory.Enabled = true;
			this.wmpCarmenHistory.Location = new System.Drawing.Point(0, 0);
			this.wmpCarmenHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.wmpCarmenHistory.Name = "wmpCarmenHistory";
			this.wmpCarmenHistory.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpCarmenHistory.OcxState")));
			this.wmpCarmenHistory.Size = new System.Drawing.Size(904, 527);
			this.wmpCarmenHistory.TabIndex = 0;
			// 
			// lblSubtitles
			// 
			this.lblSubtitles.BackColor = System.Drawing.Color.Black;
			this.lblSubtitles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSubtitles.Location = new System.Drawing.Point(0, 420);
			this.lblSubtitles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubtitles.Name = "lblSubtitles";
			this.lblSubtitles.Size = new System.Drawing.Size(904, 107);
			this.lblSubtitles.TabIndex = 1;
			this.lblSubtitles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tmr1
			// 
			this.tmr1.Interval = 1000;
			this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
			// 
			// picEnd
			// 
			this.picEnd.Image = global::FindCarmenSandiego.Properties.Resources.carmenStanding;
			this.picEnd.Location = new System.Drawing.Point(87, 36);
			this.picEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picEnd.Name = "picEnd";
			this.picEnd.Size = new System.Drawing.Size(759, 401);
			this.picEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEnd.TabIndex = 2;
			this.picEnd.TabStop = false;
			this.picEnd.Visible = false;
			this.picEnd.Click += new System.EventHandler(this.picEnd_Click);
			// 
			// frmCarmenHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 527);
			this.Controls.Add(this.picEnd);
			this.Controls.Add(this.lblSubtitles);
			this.Controls.Add(this.wmpCarmenHistory);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmCarmenHistory";
			this.Text = "CaseIntro";
			((System.ComponentModel.ISupportInitialize)(this.wmpCarmenHistory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEnd)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpCarmenHistory;
        private System.Windows.Forms.Label lblSubtitles;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox picEnd;
    }
}