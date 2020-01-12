namespace frmIndia
{
    partial class frmTajMahal
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
			this.btnTourist = new System.Windows.Forms.Button();
			this.btnLady = new System.Windows.Forms.Button();
			this.btnChild = new System.Windows.Forms.Button();
			this.lblInstruction = new System.Windows.Forms.Label();
			this.btnMap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTourist
			// 
			this.btnTourist.BackColor = System.Drawing.Color.Transparent;
			this.btnTourist.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.tourguide;
			this.btnTourist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTourist.FlatAppearance.BorderSize = 0;
			this.btnTourist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnTourist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnTourist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTourist.Location = new System.Drawing.Point(440, 338);
			this.btnTourist.Name = "btnTourist";
			this.btnTourist.Size = new System.Drawing.Size(162, 180);
			this.btnTourist.TabIndex = 0;
			this.btnTourist.UseVisualStyleBackColor = false;
			this.btnTourist.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnLady
			// 
			this.btnLady.BackColor = System.Drawing.Color.Transparent;
			this.btnLady.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.sareeLady;
			this.btnLady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLady.FlatAppearance.BorderSize = 0;
			this.btnLady.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnLady.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnLady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLady.Location = new System.Drawing.Point(348, 279);
			this.btnLady.Name = "btnLady";
			this.btnLady.Size = new System.Drawing.Size(97, 196);
			this.btnLady.TabIndex = 1;
			this.btnLady.UseVisualStyleBackColor = false;
			this.btnLady.Click += new System.EventHandler(this.btnLady_Click);
			// 
			// btnChild
			// 
			this.btnChild.BackColor = System.Drawing.Color.Transparent;
			this.btnChild.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.child;
			this.btnChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnChild.FlatAppearance.BorderSize = 0;
			this.btnChild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnChild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChild.Location = new System.Drawing.Point(539, 303);
			this.btnChild.Name = "btnChild";
			this.btnChild.Size = new System.Drawing.Size(92, 191);
			this.btnChild.TabIndex = 2;
			this.btnChild.UseVisualStyleBackColor = false;
			this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
			// 
			// lblInstruction
			// 
			this.lblInstruction.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction.Location = new System.Drawing.Point(28, -5);
			this.lblInstruction.Name = "lblInstruction";
			this.lblInstruction.Size = new System.Drawing.Size(716, 62);
			this.lblInstruction.TabIndex = 3;
			this.lblInstruction.Text = "Hmmm...maybe I can interrogate some of the tourists to see if they have informati" +
    "on on Carmen Sandiego.";
			this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnMap
			// 
			this.btnMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMap.Location = new System.Drawing.Point(524, 51);
			this.btnMap.Name = "btnMap";
			this.btnMap.Size = new System.Drawing.Size(167, 55);
			this.btnMap.TabIndex = 4;
			this.btnMap.Text = "Back to A.C.M.E Travel Agency";
			this.btnMap.UseVisualStyleBackColor = false;
			this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
			// 
			// frmTajMahal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.tajMahalScene;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(775, 516);
			this.Controls.Add(this.btnMap);
			this.Controls.Add(this.btnChild);
			this.Controls.Add(this.btnTourist);
			this.Controls.Add(this.lblInstruction);
			this.Controls.Add(this.btnLady);
			this.Name = "frmTajMahal";
			this.Text = "Where in the World is Carmen Sandiego";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTourist;
        private System.Windows.Forms.Button btnLady;
        private System.Windows.Forms.Button btnChild;
		private System.Windows.Forms.Label lblInstruction;
		private System.Windows.Forms.Button btnMap;
	}
}

