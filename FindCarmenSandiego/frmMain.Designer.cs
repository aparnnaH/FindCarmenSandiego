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
			this.btnLock.BackColor = System.Drawing.Color.Teal;
			this.btnLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLock.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLock.ForeColor = System.Drawing.Color.White;
			this.btnLock.Location = new System.Drawing.Point(255, 26);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(221, 134);
			this.btnLock.TabIndex = 11;
			this.btnLock.Text = "Unlock the Lock ";
			this.btnLock.UseVisualStyleBackColor = false;
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			this.btnLock.MouseLeave += new System.EventHandler(this.btnLock_MouseLeave);
			this.btnLock.MouseHover += new System.EventHandler(this.btnLock_MouseHover);
			// 
			// btnPiglatin
			// 
			this.btnPiglatin.BackColor = System.Drawing.Color.Teal;
			this.btnPiglatin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPiglatin.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPiglatin.ForeColor = System.Drawing.Color.White;
			this.btnPiglatin.Location = new System.Drawing.Point(12, 26);
			this.btnPiglatin.Name = "btnPiglatin";
			this.btnPiglatin.Size = new System.Drawing.Size(221, 134);
			this.btnPiglatin.TabIndex = 10;
			this.btnPiglatin.Text = "Pig Latin";
			this.btnPiglatin.UseVisualStyleBackColor = false;
			this.btnPiglatin.Click += new System.EventHandler(this.btnPiglatin_Click);
			// 
			// btnSlidingPuzzle
			// 
			this.btnSlidingPuzzle.BackColor = System.Drawing.Color.Teal;
			this.btnSlidingPuzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSlidingPuzzle.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSlidingPuzzle.ForeColor = System.Drawing.Color.White;
			this.btnSlidingPuzzle.Location = new System.Drawing.Point(501, 172);
			this.btnSlidingPuzzle.Name = "btnSlidingPuzzle";
			this.btnSlidingPuzzle.Size = new System.Drawing.Size(223, 134);
			this.btnSlidingPuzzle.TabIndex = 9;
			this.btnSlidingPuzzle.Text = "Sliding Picture Puzzle";
			this.btnSlidingPuzzle.UseVisualStyleBackColor = false;
			this.btnSlidingPuzzle.Click += new System.EventHandler(this.btnSlidingPuzzle_Click);
			this.btnSlidingPuzzle.MouseLeave += new System.EventHandler(this.btnSlidingPuzzle_MouseLeave);
			this.btnSlidingPuzzle.MouseHover += new System.EventHandler(this.btnSlidingPuzzle_MouseHover);
			// 
			// btnMatching
			// 
			this.btnMatching.BackColor = System.Drawing.Color.Teal;
			this.btnMatching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMatching.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMatching.ForeColor = System.Drawing.Color.White;
			this.btnMatching.Location = new System.Drawing.Point(255, 172);
			this.btnMatching.Name = "btnMatching";
			this.btnMatching.Size = new System.Drawing.Size(221, 134);
			this.btnMatching.TabIndex = 8;
			this.btnMatching.Text = "Matching";
			this.btnMatching.UseVisualStyleBackColor = false;
			this.btnMatching.Click += new System.EventHandler(this.btnMatching_Click);
			this.btnMatching.MouseLeave += new System.EventHandler(this.btnMatching_MouseLeave);
			this.btnMatching.MouseHover += new System.EventHandler(this.btnMatching_MouseHover);
			// 
			// btnMinesweeper
			// 
			this.btnMinesweeper.BackColor = System.Drawing.Color.Teal;
			this.btnMinesweeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMinesweeper.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinesweeper.ForeColor = System.Drawing.Color.White;
			this.btnMinesweeper.Location = new System.Drawing.Point(501, 26);
			this.btnMinesweeper.Name = "btnMinesweeper";
			this.btnMinesweeper.Size = new System.Drawing.Size(223, 134);
			this.btnMinesweeper.TabIndex = 7;
			this.btnMinesweeper.Text = "Minesweeper";
			this.btnMinesweeper.UseVisualStyleBackColor = false;
			this.btnMinesweeper.Click += new System.EventHandler(this.btnMinesweeper_Click);
			this.btnMinesweeper.MouseLeave += new System.EventHandler(this.btnMinesweeper_MouseLeave);
			this.btnMinesweeper.MouseHover += new System.EventHandler(this.btnMinesweeper_MouseHover);
			// 
			// btnDiffuseBomb
			// 
			this.btnDiffuseBomb.BackColor = System.Drawing.Color.Teal;
			this.btnDiffuseBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDiffuseBomb.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiffuseBomb.ForeColor = System.Drawing.Color.White;
			this.btnDiffuseBomb.Location = new System.Drawing.Point(12, 172);
			this.btnDiffuseBomb.Name = "btnDiffuseBomb";
			this.btnDiffuseBomb.Size = new System.Drawing.Size(221, 134);
			this.btnDiffuseBomb.TabIndex = 6;
			this.btnDiffuseBomb.Text = "Diffuse the bomb";
			this.btnDiffuseBomb.UseVisualStyleBackColor = false;
			this.btnDiffuseBomb.Click += new System.EventHandler(this.btnDiffuseBomb_Click);
			this.btnDiffuseBomb.MouseLeave += new System.EventHandler(this.btnDiffuseBomb_MouseLeave);
			this.btnDiffuseBomb.MouseHover += new System.EventHandler(this.btnDiffuseBomb_MouseHover);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 327);
			this.Controls.Add(this.btnLock);
			this.Controls.Add(this.btnPiglatin);
			this.Controls.Add(this.btnSlidingPuzzle);
			this.Controls.Add(this.btnMatching);
			this.Controls.Add(this.btnMinesweeper);
			this.Controls.Add(this.btnDiffuseBomb);
			this.Name = "frmMain";
			this.Text = "Main ";
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

