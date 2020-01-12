using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Picture_Puzzle
{
	public partial class frmSlidingPicturePuzzle : Form
	{

		int blank = 1;
		private int[][] blankpic = new int[9][];
		private bool[] boolBlank = new bool[9];

		public frmSlidingPicturePuzzle()
		{
			InitializeComponent();
		}

		private void frmSlidingPicturePuzzle_Load(object sender, EventArgs e)
		{
			blank = 5;
		}

		private void GameWon()
		{
			PictureBox[] pic = { picSq1, picSq2, picSq3, picSq4, picSq5, picSq6, picSq7, picSq8, picSq9 };
			int count = 0, tag;

			for (int i = 0; i < pic.Length; i++)
			{
				tag = int.Parse(pic[i].Tag.ToString());
				if ( tag == i )
				{
					count += 1;
				}
			}

			if (count == 9)
			{
				pic[6].Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.tajmahal7;
				for (int i = 0; i < pic.Length; i++)
				{
					pic[i].Enabled = false;
				}
				MessageBox.Show("That means Carmen Sandiego's next target is Agra, India!");
				//ManoharanV_SplashScreen_FP.frmMap.Brazil = true;
				ManoharanV_SplashScreen_FP.SplashScreen.Brazil = true;
				new ManoharanV_SplashScreen_FP.frmMap().Show();
				this.Close();
			}

		}


		private void SlidePic(int num)
		{
			int tag;
			PictureBox[] pic = { picSq1, picSq2, picSq3, picSq4, picSq5, picSq6, picSq7, picSq8, picSq9 };
			//blank - 1  =  replace picturebox option
			blankpic[0] = new int[] { 2, 4 };
			blankpic[1] = new int[] { 1, 3, 5 };
			blankpic[2] = new int[] { 2, 6 };
			blankpic[3] = new int[] { 1, 5, 7 };
			blankpic[4] = new int[] { 2, 4, 6, 8 };
			blankpic[5] = new int[] { 3, 5, 9 };
			blankpic[6] = new int[] { 4, 8 };
			blankpic[7] = new int[] { 5, 7, 9 };
			blankpic[8] = new int[] { 6, 8 };

			//switch the blank picture box		
			for (int i = 0; i < blankpic[blank].Length; i++)
			{// blankpic[blank picture box][forloop] == picturebox clicked 
				if (blankpic[blank][i] == num + 1)
				{
					boolBlank[blank] = false;			
					pic[blank].Image = pic[num].Image;
					tag = int.Parse(pic[blank].Tag.ToString());
					pic[blank].Tag = pic[num].Tag;
					pic[num].Tag = tag;
					boolBlank[num] = true;
					pic[num].Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.blank;
					blank = num;
				}
			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{		
			SlidePic(0);
			GameWon();
		}

		private void picSq2_Click(object sender, EventArgs e)
		{		
			SlidePic(1);
			GameWon();
		}

		private void picSq3_Click(object sender, EventArgs e)
		{			
			SlidePic(2);
			GameWon();
		}

		private void picSq4_Click(object sender, EventArgs e)
		{	
			SlidePic(3);
			GameWon();
		}

		private void picSq5_Click(object sender, EventArgs e)
		{		
			SlidePic(4);
			GameWon();
		}

		private void picSq6_Click(object sender, EventArgs e)
		{
			SlidePic(5);
			GameWon();		
		}

		private void picSq7_Click(object sender, EventArgs e)
		{
			SlidePic(6);
			GameWon();		
		}

		private void picSq8_Click(object sender, EventArgs e)
		{
			SlidePic(7);
			GameWon();		
		}

		private void picSq9_Click(object sender, EventArgs e)
		{
			SlidePic(8);
			GameWon();			
		}

	}
}
