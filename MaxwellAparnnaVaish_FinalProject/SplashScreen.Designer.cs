namespace ManoharanV_SplashScreen_FP
{
    partial class SplashScreen
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
			this.picSplash = new System.Windows.Forms.PictureBox();
			this.pBarLoading = new System.Windows.Forms.ProgressBar();
			this.tmrSplash = new System.Windows.Forms.Timer(this.components);
			this.lblLoading = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
			this.SuspendLayout();
			// 
			// picSplash
			// 
			this.picSplash.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.closeup_CarmenSandiego;
			this.picSplash.Location = new System.Drawing.Point(-4, -10);
			this.picSplash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picSplash.Name = "picSplash";
			this.picSplash.Size = new System.Drawing.Size(1199, 753);
			this.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picSplash.TabIndex = 0;
			this.picSplash.TabStop = false;
			this.picSplash.Click += new System.EventHandler(this.picSplash_Click);
			// 
			// pBarLoading
			// 
			this.pBarLoading.BackColor = System.Drawing.Color.Maroon;
			this.pBarLoading.ForeColor = System.Drawing.SystemColors.Control;
			this.pBarLoading.Location = new System.Drawing.Point(631, 634);
			this.pBarLoading.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pBarLoading.Name = "pBarLoading";
			this.pBarLoading.Size = new System.Drawing.Size(320, 38);
			this.pBarLoading.Step = 1;
			this.pBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pBarLoading.TabIndex = 1;
			// 
			// tmrSplash
			// 
			this.tmrSplash.Interval = 50;
			this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
			// 
			// lblLoading
			// 
			this.lblLoading.AutoSize = true;
			this.lblLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(13)))), ((int)(((byte)(5)))));
			this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLoading.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLoading.Location = new System.Drawing.Point(639, 594);
			this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLoading.Name = "lblLoading";
			this.lblLoading.Size = new System.Drawing.Size(261, 39);
			this.lblLoading.TabIndex = 2;
			this.lblLoading.Text = "L O A D I N G ...";
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1192, 735);
			this.Controls.Add(this.lblLoading);
			this.Controls.Add(this.pBarLoading);
			this.Controls.Add(this.picSplash);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "SplashScreen";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.ProgressBar pBarLoading;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblLoading;
    }
}

