namespace ManoharanV_SplashScreen_FP
{
    partial class frmSignIn
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
            this.picSignIn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // picSignIn
            // 
            this.picSignIn.BackColor = System.Drawing.Color.Transparent;
            this.picSignIn.Location = new System.Drawing.Point(189, 239);
            this.picSignIn.Name = "picSignIn";
            this.picSignIn.Size = new System.Drawing.Size(260, 109);
            this.picSignIn.TabIndex = 0;
            this.picSignIn.TabStop = false;
            this.picSignIn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.signIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 422);
            this.Controls.Add(this.picSignIn);
            this.Name = "frmUserInfo";
            this.Text = "Where in the World is Carmen Sandiego?";
            ((System.ComponentModel.ISupportInitialize)(this.picSignIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSignIn;
    }
}