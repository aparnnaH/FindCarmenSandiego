using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnMinesweeper_MouseHover(object sender, EventArgs e)
		{
			btnMinesweeper.BackgroundImage = FindCarmenSandiego.Properties.Resources.minesweeperIcon;
		}

		private void btnMinesweeper_MouseLeave(object sender, EventArgs e)
		{
			btnMinesweeper.BackgroundImage = null;
		}

		private void btnLock_MouseHover(object sender, EventArgs e)
		{
			btnLock.BackgroundImage = FindCarmenSandiego.Properties.Resources.lockIcon;
			btnLock.ForeColor = Color.Black;
		}

		private void btnLock_MouseLeave(object sender, EventArgs e)
		{
			btnLock.BackgroundImage = null;
			btnLock.ForeColor = Color.White;
		}

		private void btnDiffuseBomb_MouseHover(object sender, EventArgs e)
		{
			btnDiffuseBomb.BackgroundImage = FindCarmenSandiego.Properties.Resources.DiffureBombIcon;
		}

		private void btnDiffuseBomb_MouseLeave(object sender, EventArgs e)
		{
			btnDiffuseBomb.BackgroundImage = null;
		}

		private void btnMatching_MouseHover(object sender, EventArgs e)
		{
			btnMatching.BackgroundImage = FindCarmenSandiego.Properties.Resources.MatchingGameIcon;
		}

		private void btnMatching_MouseLeave(object sender, EventArgs e)
		{
			btnMatching.BackgroundImage = null;
		}

		private void btnSlidingPuzzle_MouseHover(object sender, EventArgs e)
		{
			btnSlidingPuzzle.BackgroundImage = FindCarmenSandiego.Properties.Resources.SlidingPicturePuzzleIcon;
		}

		private void btnSlidingPuzzle_MouseLeave(object sender, EventArgs e)
		{
			btnSlidingPuzzle.BackgroundImage = null;
		}

		private void btnPiglatin_Click(object sender, EventArgs e)
		{
			new PigLatinGame.frmPigLatGame().Show();
			this.Hide();
		}

		private void btnLock_Click(object sender, EventArgs e)
		{			
			new Lock.frmLock().Show();
			this.Hide();
		}

		private void btnMinesweeper_Click(object sender, EventArgs e)
		{
			new minesweeper_puzzle.frmMinesweeper().Show();
			this.Hide();
		}

		private void btnDiffuseBomb_Click(object sender, EventArgs e)
		{
			new pathPuzzle.frmPuzzle23().Show();
			this.Hide();
		}

		private void btnMatching_Click(object sender, EventArgs e)
		{
			new Matching_game.frmMatchingGame().Show();
			this.Hide();
		}

		private void btnSlidingPuzzle_Click(object sender, EventArgs e)
		{
			new Sliding_Picture_Puzzle.frmSlidingPicturePuzzle().Show();
			this.Hide(); 
		}

	}
}
