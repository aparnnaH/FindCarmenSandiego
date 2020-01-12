namespace MaxwellMcLaughlin_G12FP_PigLatinGame
{
    partial class frmPigLatGame
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
			this.lblIntruction = new System.Windows.Forms.Label();
			this.pbKey = new System.Windows.Forms.PictureBox();
			this.lblEnter = new System.Windows.Forms.Label();
			this.txtEnter = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrPuzzle = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIntruction
			// 
			this.lblIntruction.BackColor = System.Drawing.Color.Black;
			this.lblIntruction.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntruction.ForeColor = System.Drawing.Color.Yellow;
			this.lblIntruction.Location = new System.Drawing.Point(0, -2);
			this.lblIntruction.Name = "lblIntruction";
			this.lblIntruction.Size = new System.Drawing.Size(1177, 32);
			this.lblIntruction.TabIndex = 1;
			this.lblIntruction.Text = "** I knew it. This is one of Carmen\'s tricks. I think I have to decode the messag" +
    "e from Pig-Latin to English**";
			this.lblIntruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbKey
			// 
			this.pbKey.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.PigLatin;
			this.pbKey.Location = new System.Drawing.Point(866, 227);
			this.pbKey.Name = "pbKey";
			this.pbKey.Size = new System.Drawing.Size(257, 210);
			this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbKey.TabIndex = 3;
			this.pbKey.TabStop = false;
			// 
			// lblEnter
			// 
			this.lblEnter.AutoSize = true;
			this.lblEnter.BackColor = System.Drawing.Color.Yellow;
			this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnter.Location = new System.Drawing.Point(581, 453);
			this.lblEnter.Name = "lblEnter";
			this.lblEnter.Size = new System.Drawing.Size(261, 25);
			this.lblEnter.TabIndex = 4;
			this.lblEnter.Text = "The Secret Message is:";
			// 
			// txtEnter
			// 
			this.txtEnter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEnter.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnter.Location = new System.Drawing.Point(464, 478);
			this.txtEnter.Name = "txtEnter";
			this.txtEnter.Size = new System.Drawing.Size(638, 31);
			this.txtEnter.TabIndex = 5;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(916, 340);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(0, 0);
			this.btnEnter.TabIndex = 6;
			this.btnEnter.Text = "You shouldent be able to see this";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Yellow;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(1005, 82);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(97, 46);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(968, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 47);
			this.label1.TabIndex = 10;
			this.label1.Text = "Pig-Latin Decoder from A.C.M.E";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmPigLatGame
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.pigLatinBrazilCorrect;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1123, 521);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.txtEnter);
			this.Controls.Add(this.lblEnter);
			this.Controls.Add(this.pbKey);
			this.Controls.Add(this.lblIntruction);
			this.DoubleBuffered = true;
			this.Name = "frmPigLatGame";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIntruction;
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrPuzzle;
	}
}