namespace ManoharanV_SplashScreen_FP
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
			((System.ComponentModel.ISupportInitialize)(this.wmpCarmenHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// wmpCarmenHistory
			// 
			this.wmpCarmenHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wmpCarmenHistory.Enabled = true;
			this.wmpCarmenHistory.Location = new System.Drawing.Point(0, 0);
			this.wmpCarmenHistory.Name = "wmpCarmenHistory";
			this.wmpCarmenHistory.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpCarmenHistory.OcxState")));
			this.wmpCarmenHistory.Size = new System.Drawing.Size(678, 428);
			this.wmpCarmenHistory.TabIndex = 0;
			// 
			// lblSubtitles
			// 
			this.lblSubtitles.BackColor = System.Drawing.Color.Black;
			this.lblSubtitles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtitles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblSubtitles.Location = new System.Drawing.Point(0, 341);
			this.lblSubtitles.Name = "lblSubtitles";
			this.lblSubtitles.Size = new System.Drawing.Size(678, 87);
			this.lblSubtitles.TabIndex = 1;
			this.lblSubtitles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSubtitles.Click += new System.EventHandler(this.lblSubtitles_Click);
			// 
			// tmr1
			// 
			this.tmr1.Interval = 1000;
			this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
			// 
			// frmCarmenHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 428);
			this.Controls.Add(this.lblSubtitles);
			this.Controls.Add(this.wmpCarmenHistory);
			this.Name = "frmCarmenHistory";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.wmpCarmenHistory)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpCarmenHistory;
        private System.Windows.Forms.Label lblSubtitles;
        private System.Windows.Forms.Timer tmr1;
    }
}