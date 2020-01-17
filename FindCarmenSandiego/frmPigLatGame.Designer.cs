namespace PigLatinGame
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
			this.pbKey = new System.Windows.Forms.PictureBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.tmrPuzzle = new System.Windows.Forms.Timer(this.components);
			this.lblIntruction = new System.Windows.Forms.Label();
			this.txtEnter = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
			this.SuspendLayout();
			// 
			// pbKey
			// 
			this.pbKey.Image = global::FindCarmenSandiego.Properties.Resources.PigLatin;
			this.pbKey.Location = new System.Drawing.Point(1140, 265);
			this.pbKey.Margin = new System.Windows.Forms.Padding(4);
			this.pbKey.Name = "pbKey";
			this.pbKey.Size = new System.Drawing.Size(403, 292);
			this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbKey.TabIndex = 3;
			this.pbKey.TabStop = false;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(1221, 418);
			this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(0, 0);
			this.btnEnter.TabIndex = 6;
			this.btnEnter.Text = "You shouldent be able to see this";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// tmrPuzzle
			// 
			this.tmrPuzzle.Interval = 1000;
			this.tmrPuzzle.Tick += new System.EventHandler(this.tmrPuzzle_Tick);
			// 
			// lblIntruction
			// 
			this.lblIntruction.BackColor = System.Drawing.Color.Black;
			this.lblIntruction.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntruction.ForeColor = System.Drawing.Color.Yellow;
			this.lblIntruction.Location = new System.Drawing.Point(-7, 1);
			this.lblIntruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblIntruction.Name = "lblIntruction";
			this.lblIntruction.Size = new System.Drawing.Size(1569, 39);
			this.lblIntruction.TabIndex = 10;
			this.lblIntruction.Text = "** I knew it. This is one of Carmen\'s tricks. I think I have to decode the messag" +
    "e from Pig-Latin to English**";
			this.lblIntruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtEnter
			// 
			this.txtEnter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEnter.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnter.Location = new System.Drawing.Point(619, 588);
			this.txtEnter.Margin = new System.Windows.Forms.Padding(4);
			this.txtEnter.Name = "txtEnter";
			this.txtEnter.Size = new System.Drawing.Size(849, 37);
			this.txtEnter.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(775, 558);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 31);
			this.label1.TabIndex = 11;
			this.label1.Text = "The Secret Message is:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1337, 207);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 58);
			this.label2.TabIndex = 13;
			this.label2.Text = "Pig-Latin Decoder from A.C.M.E";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// frmPigLatGame
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.pigLatinBrazilCorrect;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1541, 641);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEnter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblIntruction);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.pbKey);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmPigLatGame";
			this.Text = "frmPigLatGame";
			this.Load += new System.EventHandler(this.frmPigLatGame_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Timer tmrPuzzle;
		private System.Windows.Forms.Label lblIntruction;
		private System.Windows.Forms.TextBox txtEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}