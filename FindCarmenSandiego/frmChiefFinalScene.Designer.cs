namespace ChiefFinalScene_FP
{
    partial class frmChiefFinalScene
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiefFinalScene));
			this.wmpFinal = new AxWMPLib.AxWindowsMediaPlayer();
			this.lblCredits = new System.Windows.Forms.Label();
			this.lblCC = new System.Windows.Forms.Label();
			this.tmrSubtitles = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.wmpFinal)).BeginInit();
			this.SuspendLayout();
			// 
			// wmpFinal
			// 
			this.wmpFinal.Enabled = true;
			this.wmpFinal.Location = new System.Drawing.Point(61, 36);
			this.wmpFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.wmpFinal.Name = "wmpFinal";
			this.wmpFinal.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpFinal.OcxState")));
			this.wmpFinal.Size = new System.Drawing.Size(668, 340);
			this.wmpFinal.TabIndex = 0;
			this.wmpFinal.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpFinal_PlayStateChange);
			// 
			// lblCredits
			// 
			this.lblCredits.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCredits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCredits.Location = new System.Drawing.Point(-9, 0);
			this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCredits.Name = "lblCredits";
			this.lblCredits.Size = new System.Drawing.Size(1079, 681);
			this.lblCredits.TabIndex = 1;
			this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCredits.Visible = false;
			this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
			// 
			// lblCC
			// 
			this.lblCC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCC.Location = new System.Drawing.Point(77, 423);
			this.lblCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCC.Name = "lblCC";
			this.lblCC.Size = new System.Drawing.Size(895, 55);
			this.lblCC.TabIndex = 2;
			this.lblCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tmrSubtitles
			// 
			this.tmrSubtitles.Interval = 1000;
			this.tmrSubtitles.Tick += new System.EventHandler(this.tmrSubtitles_Tick);
			// 
			// frmChiefFinalScene
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.computerScreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1067, 673);
			this.Controls.Add(this.lblCC);
			this.Controls.Add(this.lblCredits);
			this.Controls.Add(this.wmpFinal);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmChiefFinalScene";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.wmpFinal)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpFinal;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Timer tmrSubtitles;
    }
}

