namespace ManoharanV_SplashScreen_FP
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
			this.btnMap = new System.Windows.Forms.Button();
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
			this.picTHought.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.dialogue;
			this.picTHought.Location = new System.Drawing.Point(2, 331);
			this.picTHought.Name = "picTHought";
			this.picTHought.Size = new System.Drawing.Size(496, 140);
			this.picTHought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTHought.TabIndex = 0;
			this.picTHought.TabStop = false;
			this.picTHought.Visible = false;
			// 
			// btnMap
			// 
			this.btnMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMap.Location = new System.Drawing.Point(662, 430);
			this.btnMap.Name = "btnMap";
			this.btnMap.Size = new System.Drawing.Size(167, 55);
			this.btnMap.TabIndex = 1;
			this.btnMap.Text = "Back to A.C.M.E Travel Agency";
			this.btnMap.UseVisualStyleBackColor = false;
			this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
			// 
			// frmGraffitiWall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.graffiti;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(884, 497);
			this.Controls.Add(this.btnMap);
			this.Controls.Add(this.picTHought);
			this.Name = "frmGraffitiWall";
			this.Text = "Where in the World is Carmen Sandiego";
			this.Load += new System.EventHandler(this.frmGraffitiWall_Load);
			this.Click += new System.EventHandler(this.frmGraffitiWall_Click);
			((System.ComponentModel.ISupportInitialize)(this.picTHought)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.PictureBox picTHought;
		private System.Windows.Forms.Button btnMap;
	}
}