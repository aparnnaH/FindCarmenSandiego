using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_V2
{
	public partial class frmCalendarBingoPuzzle : Form
	{
		public frmCalendarBingoPuzzle()
		{
			InitializeComponent();
		}

		private int[] count = new int[32];
		private int numBtnNext = 1;
		private int numBtnBingoNext = 1;

		private void label1_Click(object sender, EventArgs e)
		{ }
		private void Form1_Load(object sender, EventArgs e)
		{
			picDecCalendar.SendToBack();
		}

		private void lblDec10_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec10.Tag.ToString());
		}

		private void lblDec30_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec30.Tag.ToString());
		}

		private void lblDec29_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec29.Tag.ToString());
		}

		private void lblDec28_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec28.Tag.ToString());
		}

		private void lblDec27_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec27.Tag.ToString());
		}

		private void lblDec26_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec26.Tag.ToString());
		}

		private void lblDec25_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec25.Tag.ToString());
		}

		private void lblDec24_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec24.Tag.ToString());
		}

		private void lblDec23_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec23.Tag.ToString());
		}

		private void lblDec22_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec22.Tag.ToString());
		}

		private void lblDec21_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec21.Tag.ToString());
		}

		private void lblDec20_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec20.Tag.ToString());
		}

		private void lblDec19_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec19.Tag.ToString());
		}

		private void lblDec18_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec18.Tag.ToString());
		}

		private void lblDec17_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec17.Tag.ToString());
		}

		private void lblDec16_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec16.Tag.ToString());
		}

		private void lblDec15_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec15.Tag.ToString());
		}

		private void lblDec14_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec14.Tag.ToString());
		}

		private void lblDec13_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec13.Tag.ToString());
		}

		private void lblDec12_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec12.Tag.ToString());
		}

		private void lblDec11_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec11.Tag.ToString());
		}

		private void lblDec31_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec31.Tag.ToString());
		}

		private void lblDec9_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec9.Tag.ToString());
		}

		private void lblDec8_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec8.Tag.ToString());
		}

		private void lblDec7_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec7.Tag.ToString());
		}

		private void lblDec6_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec6.Tag.ToString());
		}

		private void lblDec5_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec5.Tag.ToString());
		}

		private void lblDec4_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec4.Tag.ToString());
		}

		private void lblDec3_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec3.Tag.ToString());
		}

		private void lblDec2_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec2.Tag.ToString());
		}

		private void lblDec1_Click(object sender, EventArgs e)
		{
			DecColorChange(lblDec1.Tag.ToString());
		}

		private void DecColorChange(string tag)
		{
			int clickCount = 0;
			int num = int.Parse(tag), correct = 0;
			Label[] dec = {lblDec1, lblDec2, lblDec3, lblDec4, lblDec5, lblDec6, lblDec7, lblDec8, lblDec9, lblDec10, lblDec11, lblDec12, lblDec13, lblDec14, lblDec15, lblDec16, lblDec17, lblDec18, lblDec19, lblDec20, lblDec21, lblDec22, lblDec23, lblDec24, lblDec25, lblDec26, lblDec27, lblDec28, lblDec29, lblDec30, lblDec31 };
			Label[] decCorrect = {lblDec2, lblDec4, lblDec9, lblDec10, lblDec11, lblDec18, lblDec25};

			dec[num - 1].BackColor = Color.Turquoise;
			count[num - 1] += 1;
			if (count[num - 1] == 2)
			{
				dec[num - 1].BackColor = Color.White;
				count[num - 1] = 0;
			}

			for (int i = 0; i < dec.Length; i++)
			{
				if (dec[i].BackColor == Color.Turquoise)
				{
					clickCount += 1;
				}
			}

			for (int i = 0; i < decCorrect.Length; i++)
			{
				if (decCorrect[i].BackColor == Color.Turquoise)
				{
					correct += 1;
				}
			}

			if (correct == decCorrect.Length && clickCount == correct )
			{
				for (int i = 0; i < dec.Length; i++)
				{
					dec[i].Enabled = false;
				}
			}

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string[] dates = { "Dec 2", "Dec 4", "Dec 9", "Dec 10", "Dec 11", "Dec 18", "Dec 25"};

			lblNewspaperDate.Text = dates[numBtnNext];
			numBtnNext += 1;

			if (numBtnNext == 7)
			{
				numBtnNext = 0;
			}

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{ }

		private void bingoCard(int index)
		{
			Button[] btn = { btnSq1, btnSq2, btnSq3, btnSq4, btnSq5, btnSq6, btnSq7, btnSq8, btnSq9, btnSq10, btnSq11, btnSq12, btnSq13, btnSq14, btnSq15, btnSq16, btnSq17, btnSq18, btnSq19, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };

			if (btn[index].Tag.Equals("0"))
			{
				btn[index].Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BingoTocken;
				btn[index].Tag = "1";
			}
			else if (btn[index].Tag.Equals("1"))
			{
				btn[index].Image = null;
				btn[index].Tag = "0";
			}
			BingoWin();
		}

		private void picSq15_Click(object sender, EventArgs e)
		{
			bingoCard(14);
		}

		private void btnSq1_Click(object sender, EventArgs e)
		{
			bingoCard(0);
		}

		private void btnSq2_Click(object sender, EventArgs e)
		{
			bingoCard(1);
		}

		private void btnSq3_Click(object sender, EventArgs e)
		{
			bingoCard(2);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			bingoCard(3);
		}

		private void btnSq5_Click(object sender, EventArgs e)
		{
			bingoCard(4);
		}

		private void btnSq6_Click(object sender, EventArgs e)
		{
			bingoCard(5);
		}

		private void btnSq7_Click(object sender, EventArgs e)
		{
			bingoCard(6);
		}

		private void btnSq8_Click(object sender, EventArgs e)
		{
			bingoCard(7);
		}

		private void btnSq9_Click(object sender, EventArgs e)
		{
			bingoCard(8);
		}

		private void btnSq10_Click(object sender, EventArgs e)
		{
			bingoCard(9);
		}

		private void btnSq11_Click(object sender, EventArgs e)
		{
			bingoCard(10);
		}

		private void btnSq12_Click(object sender, EventArgs e)
		{
			bingoCard(11);
		}

		private void btnSq13_Click(object sender, EventArgs e)
		{
			bingoCard(12);
		}

		private void btnSq14_Click(object sender, EventArgs e)
		{
			bingoCard(13);
		}

		private void btnSq15_Click(object sender, EventArgs e)
		{
			bingoCard(14);
		}

		private void btnSq16_Click(object sender, EventArgs e)
		{
			bingoCard(15);
		}

		private void btnSq17_Click(object sender, EventArgs e)
		{
			bingoCard(16);
		}

		private void btnSq18_Click(object sender, EventArgs e)
		{
			bingoCard(17);
		}

		private void btnSq19_Click(object sender, EventArgs e)
		{
			bingoCard(18);
		}

		private void btnSq20_Click(object sender, EventArgs e)
		{
			bingoCard(19);
		}

		private void btnSq21_Click(object sender, EventArgs e)
		{
			bingoCard(20);
		}

		private void btnSq22_Click(object sender, EventArgs e)
		{
			bingoCard(21);
		}

		private void btnSq23_Click(object sender, EventArgs e)
		{
			bingoCard(22);
		}

		private void btnSq24_Click(object sender, EventArgs e)
		{
			bingoCard(23);
		}

		private void btnNextBingo_Click(object sender, EventArgs e)
		{
			Image[] pic = { MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoG31,MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoI21, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoN40, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoI28, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoG52,
									MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoG46, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoI23, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoI4, MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoG58,MaxwellAparnnaVaish_FinalProject.Properties.Resources.bingoN35};
			picBingoBall.Image = pic[numBtnBingoNext];
			numBtnBingoNext += 1;

			if (numBtnBingoNext == 10)
			{
				numBtnBingoNext = 0;
			}
		}

		private void BingoWin()
		{
			int countBingo = 0, clickCount = 0;
			Button[] btnCorrect = { btnSq2, btnSq3, btnSq4, btnSq7, btnSq12, btnSq13, btnSq18, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };
			Button[] btn = { btnSq1, btnSq2, btnSq3, btnSq4, btnSq5, btnSq6, btnSq7, btnSq8, btnSq9, btnSq10, btnSq11, btnSq12, btnSq13, btnSq14, btnSq15, btnSq16, btnSq17, btnSq18, btnSq19, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };

			for (int i = 0; i < btnCorrect.Length; i++)
			{
				if (btnCorrect[i].Tag.Equals("1"))
				{
					countBingo += 1;				
				}
			}

			for (int i = 0; i < btn.Length; i++)
			{
				if (btn[i].Tag.Equals("1"))
				{
					clickCount += 1;
				}
			}

			if (countBingo == 10 && clickCount == countBingo)
			{
				MessageBox.Show("Completed");
				for (int i = 0; i < btn.Length; i++)
				{
					btn[i].Enabled = false;
				}
				new Sliding_Picture_Puzzle.frmSlidingPicturePuzzle().Show();
				this.Close();
			}
			
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{ }

	}
}
