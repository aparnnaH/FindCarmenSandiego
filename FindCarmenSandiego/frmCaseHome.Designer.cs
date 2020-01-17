namespace SplashScreen_FP
{
    partial class frmCaseHome
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
            this.lblCover = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNewYork = new System.Windows.Forms.Label();
            this.txtNotebook = new System.Windows.Forms.TextBox();
            this.btnTravel = new System.Windows.Forms.Button();
            this.picChief = new System.Windows.Forms.PictureBox();
            this.picAcme = new System.Windows.Forms.PictureBox();
            this.txtNotebook1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picChief)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCover
            // 
            this.lblCover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCover.Location = new System.Drawing.Point(199, 239);
            this.lblCover.Name = "lblCover";
            this.lblCover.Size = new System.Drawing.Size(161, 39);
            this.lblCover.TabIndex = 0;
            this.lblCover.Text = "label1";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(244, 211);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(116, 15);
            this.lblUserName.TabIndex = 2;
            // 
            // lblNewYork
            // 
            this.lblNewYork.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewYork.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewYork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNewYork.Location = new System.Drawing.Point(181, 401);
            this.lblNewYork.Name = "lblNewYork";
            this.lblNewYork.Size = new System.Drawing.Size(208, 64);
            this.lblNewYork.TabIndex = 3;
            this.lblNewYork.Text = "We have intel Carmen Sandiego was last seen in New York. Click on the travel butt" +
    "on.";
            this.lblNewYork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNotebook
            // 
            this.txtNotebook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotebook.Location = new System.Drawing.Point(425, 388);
            this.txtNotebook.Multiline = true;
            this.txtNotebook.Name = "txtNotebook";
            this.txtNotebook.Size = new System.Drawing.Size(190, 96);
            this.txtNotebook.TabIndex = 4;
            // 
            // btnTravel
            // 
            this.btnTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTravel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravel.Location = new System.Drawing.Point(36, 273);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(105, 77);
            this.btnTravel.TabIndex = 5;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = false;
            this.btnTravel.Click += new System.EventHandler(this.button1_Click);
            // 
            // picChief
            // 
            this.picChief.Image = global::FindCarmenSandiego.Properties.Resources.chiefgif;
            this.picChief.Location = new System.Drawing.Point(27, 51);
            this.picChief.Name = "picChief";
            this.picChief.Size = new System.Drawing.Size(121, 101);
            this.picChief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChief.TabIndex = 6;
            this.picChief.TabStop = false;
            // 
            // picAcme
            // 
            this.picAcme.Image = global::FindCarmenSandiego.Properties.Resources.ACMEwhite;
            this.picAcme.Location = new System.Drawing.Point(425, 338);
            this.picAcme.Name = "picAcme";
            this.picAcme.Size = new System.Drawing.Size(71, 54);
            this.picAcme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAcme.TabIndex = 7;
            this.picAcme.TabStop = false;
            // 
            // txtNotebook1
            // 
            this.txtNotebook1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotebook1.Location = new System.Drawing.Point(493, 338);
            this.txtNotebook1.Multiline = true;
            this.txtNotebook1.Name = "txtNotebook1";
            this.txtNotebook1.Size = new System.Drawing.Size(122, 54);
            this.txtNotebook1.TabIndex = 8;
            // 
            // frmCaseHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.dossier;
            this.ClientSize = new System.Drawing.Size(641, 505);
            this.Controls.Add(this.txtNotebook1);
            this.Controls.Add(this.picAcme);
            this.Controls.Add(this.picChief);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.txtNotebook);
            this.Controls.Add(this.lblNewYork);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblCover);
            this.Name = "frmCaseHome";
            this.Text = "frmCaseHome";
            ((System.ComponentModel.ISupportInitialize)(this.picChief)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAcme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCover;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblNewYork;
        private System.Windows.Forms.TextBox txtNotebook;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.PictureBox picChief;
        private System.Windows.Forms.PictureBox picAcme;
        private System.Windows.Forms.TextBox txtNotebook1;
    }
}