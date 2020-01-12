namespace Main_form
{
	partial class frmMain
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
			this.btnLock = new System.Windows.Forms.Button();
			this.btnPiglatin = new System.Windows.Forms.Button();
			this.btnSlidingPuzzle = new System.Windows.Forms.Button();
			this.btnMatching = new System.Windows.Forms.Button();
			this.btnMinesweeper = new System.Windows.Forms.Button();
			this.btnDiffuseBomb = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLock
			// 
			this.btnLock.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLock.Location = new System.Drawing.Point(295, 85);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(221, 134);
			this.btnLock.TabIndex = 11;
			this.btnLock.Text = "Unlock the Lock ";
			this.btnLock.UseVisualStyleBackColor = true;
			// 
			// btnPiglatin
			// 
			this.btnPiglatin.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPiglatin.Location = new System.Drawing.Point(37, 85);
			this.btnPiglatin.Name = "btnPiglatin";
			this.btnPiglatin.Size = new System.Drawing.Size(221, 134);
			this.btnPiglatin.TabIndex = 10;
			this.btnPiglatin.Text = "Pig Latin";
			this.btnPiglatin.UseVisualStyleBackColor = true;
			// 
			// btnSlidingPuzzle
			// 
			this.btnSlidingPuzzle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSlidingPuzzle.Location = new System.Drawing.Point(543, 231);
			this.btnSlidingPuzzle.Name = "btnSlidingPuzzle";
			this.btnSlidingPuzzle.Size = new System.Drawing.Size(221, 134);
			this.btnSlidingPuzzle.TabIndex = 9;
			this.btnSlidingPuzzle.Text = "Sliding Picture Puzzle";
			this.btnSlidingPuzzle.UseVisualStyleBackColor = true;
			// 
			// btnMatching
			// 
			this.btnMatching.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMatching.Location = new System.Drawing.Point(295, 231);
			this.btnMatching.Name = "btnMatching";
			this.btnMatching.Size = new System.Drawing.Size(221, 134);
			this.btnMatching.TabIndex = 8;
			this.btnMatching.Text = "Matching";
			this.btnMatching.UseVisualStyleBackColor = true;
			// 
			// btnMinesweeper
			// 
			this.btnMinesweeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMinesweeper.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinesweeper.Location = new System.Drawing.Point(543, 85);
			this.btnMinesweeper.Name = "btnMinesweeper";
			this.btnMinesweeper.Size = new System.Drawing.Size(221, 134);
			this.btnMinesweeper.TabIndex = 7;
			this.btnMinesweeper.Text = "Minesweeper";
			this.btnMinesweeper.UseVisualStyleBackColor = true;
			// 
			// btnDiffuseBomb
			// 
			this.btnDiffuseBomb.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiffuseBomb.Location = new System.Drawing.Point(37, 231);
			this.btnDiffuseBomb.Name = "btnDiffuseBomb";
			this.btnDiffuseBomb.Size = new System.Drawing.Size(221, 134);
			this.btnDiffuseBomb.TabIndex = 6;
			this.btnDiffuseBomb.Text = "Diffuse the bomb";
			this.btnDiffuseBomb.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLock);
			this.Controls.Add(this.btnPiglatin);
			this.Controls.Add(this.btnSlidingPuzzle);
			this.Controls.Add(this.btnMatching);
			this.Controls.Add(this.btnMinesweeper);
			this.Controls.Add(this.btnDiffuseBomb);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLock;
		private System.Windows.Forms.Button btnPiglatin;
		private System.Windows.Forms.Button btnSlidingPuzzle;
		private System.Windows.Forms.Button btnMatching;
		private System.Windows.Forms.Button btnMinesweeper;
		private System.Windows.Forms.Button btnDiffuseBomb;
	}
}

