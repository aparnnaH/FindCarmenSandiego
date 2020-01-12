namespace Minesweeper_Instructions
{
	partial class frmMinesweeperInstructions
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
			this.btnNext = new System.Windows.Forms.Button();
			this.picInstructions = new System.Windows.Forms.PictureBox();
			this.lblInsructions = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picInstructions)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(70, 457);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(497, 57);
			this.btnNext.TabIndex = 6;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// picInstructions
			// 
			this.picInstructions.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep1;
			this.picInstructions.Location = new System.Drawing.Point(-1, 2);
			this.picInstructions.Name = "picInstructions";
			this.picInstructions.Size = new System.Drawing.Size(636, 307);
			this.picInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picInstructions.TabIndex = 0;
			this.picInstructions.TabStop = false;
			// 
			// lblInsructions
			// 
			this.lblInsructions.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInsructions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblInsructions.Location = new System.Drawing.Point(8, 312);
			this.lblInsructions.Name = "lblInsructions";
			this.lblInsructions.Size = new System.Drawing.Size(627, 143);
			this.lblInsructions.TabIndex = 10;
			this.lblInsructions.Text = "Click any square on the grid. Doing so will start the Minesweeper game.";
			this.lblInsructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmMinesweeperInstructions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(647, 521);
			this.Controls.Add(this.lblInsructions);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.picInstructions);
			this.Name = "frmMinesweeperInstructions";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.picInstructions)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picInstructions;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label lblInsructions;
	}
}

