namespace ManoharanV_SplashScreen_FP
{
    partial class frmChiefExplainingCarmen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiefExplainingCarmen));
			this.wmpChiefIntro = new AxWMPLib.AxWindowsMediaPlayer();
			this.picLoading = new System.Windows.Forms.PictureBox();
			this.tmr3 = new System.Windows.Forms.Timer(this.components);
			this.lblCover = new System.Windows.Forms.Label();
			this.lblCaption = new System.Windows.Forms.Label();
			this.picStartVideo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.wmpChiefIntro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picStartVideo)).BeginInit();
			this.SuspendLayout();
			// 
			// wmpChiefIntro
			// 
			this.wmpChiefIntro.Enabled = true;
			this.wmpChiefIntro.Location = new System.Drawing.Point(130, 34);
			this.wmpChiefIntro.Name = "wmpChiefIntro";
			this.wmpChiefIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpChiefIntro.OcxState")));
			this.wmpChiefIntro.Size = new System.Drawing.Size(606, 324);
			this.wmpChiefIntro.TabIndex = 11;
			// 
			// picLoading
			// 
			this.picLoading.BackColor = System.Drawing.Color.Transparent;
			this.picLoading.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.loading;
			this.picLoading.Location = new System.Drawing.Point(130, 34);
			this.picLoading.Name = "picLoading";
			this.picLoading.Size = new System.Drawing.Size(606, 324);
			this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLoading.TabIndex = 12;
			this.picLoading.TabStop = false;
			// 
			// tmr3
			// 
			this.tmr3.Interval = 1000;
			this.tmr3.Tick += new System.EventHandler(this.tmr3_Tick);
			// 
			// lblCover
			// 
			this.lblCover.BackColor = System.Drawing.Color.Black;
			this.lblCover.Location = new System.Drawing.Point(127, 34);
			this.lblCover.Name = "lblCover";
			this.lblCover.Size = new System.Drawing.Size(88, 324);
			this.lblCover.TabIndex = 13;
			this.lblCover.Text = "label1";
			// 
			// lblCaption
			// 
			this.lblCaption.BackColor = System.Drawing.Color.Black;
			this.lblCaption.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCaption.Location = new System.Drawing.Point(130, 299);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(597, 59);
			this.lblCaption.TabIndex = 14;
			this.lblCaption.Text = "Who is Carmen Sandiego you may ask? Watch this video to learn her story.";
			this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCaption.Visible = false;
			this.lblCaption.Click += new System.EventHandler(this.lblCaption_Click);
			// 
			// picStartVideo
			// 
			this.picStartVideo.Location = new System.Drawing.Point(396, 184);
			this.picStartVideo.Name = "picStartVideo";
			this.picStartVideo.Size = new System.Drawing.Size(17, 12);
			this.picStartVideo.TabIndex = 15;
			this.picStartVideo.TabStop = false;
			this.picStartVideo.Visible = false;
			this.picStartVideo.Click += new System.EventHandler(this.picStartVideo_Click);
			// 
			// frmChiefExplainingCarmen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.computerScreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(867, 526);
			this.Controls.Add(this.picStartVideo);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.lblCover);
			this.Controls.Add(this.picLoading);
			this.Controls.Add(this.wmpChiefIntro);
			this.Name = "frmChiefExplainingCarmen";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.wmpChiefIntro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picStartVideo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer wmpChiefIntro;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox picStartVideo;
    }
}