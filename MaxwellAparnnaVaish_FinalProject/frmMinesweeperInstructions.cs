using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_Instructions
{
	public partial class frmMinesweeperInstructions : Form
	{
		private int next = 1;
		public frmMinesweeperInstructions()
		{
			InitializeComponent();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Image[] pic = { MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep1,MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep2, MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep3, MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep5, MaxwellAparnnaVaish_FinalProject.Properties.Resources.MineStep6};
			string[] text = { "Click any square on the grid. Doing so will start the Minesweeper game.",
			"Review the numbers. Any number on the board refers to the number of mines currently touching that number's square.",
			"Right-click any squares that you think contain mines. This will put a flag on the square. It's best to start with squares that absolutely have to contain mines (e.g., a solitary square next to a 1 on the board) to help with the process of elimination later.",
			"Click any squares that don't contain mines.","Clear the board."};

			picInstructions.Image = pic[next];
			lblInsructions.Text = text[next];

			next += 1;

			if (next == 5)
			{
				next = 0;
			}

		}

	}
}
