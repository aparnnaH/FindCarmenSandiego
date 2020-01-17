using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Matching_game
{
	public partial class frmMatchingGame : Form
	{		
		public frmMatchingGame()
		{
			InitializeComponent();
		}

		private int[] randBtn = new int[13], randBtn1 = new int[13], randPic = new int[13], randPic1 = new int [13], picClicked = new int [2];
		private int count, pic1, pic2, btnClicked1, btnClicked2, correct; 
		
		private void btnSq1_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(0, true, false);
		}

		private void btnSq2_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(1, true, false);
		}

		private void btnSq3_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(2, true, false);
		}

		private void btnSq4_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(3, true, false);
		}

		private void btnSq5_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(4, true, false);
		}

		private void btnSq6_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(5, true, false);
		}

		private void btnSq7_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(6, true, false);
		}

		private void btnSq8_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(7, true, false);
		}

		private void btnSq9_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(8, true, false);
		}

		private void btnSq10_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(9, true, false);
		}

		private void btnSq11_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(10, true, false);
		}

		private void btnSq12_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(11, true, false);
		}

		private void btnSq13_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(0, false, true);
		}

		private void btnSq14_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(1, false, true);
		}

		private void btnSq15_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(2, false, true);
		}

		private void btnSq16_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(3, false, true);
		}

		private void btnSq17_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(4, false, true);
		}

		private void btnSq18_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(5, false, true);
		}

		private void btnSq19_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(6, false, true);
		}

		private void btnSq20_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(7, false, true);
		}

		private void btnSq21_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(8, false, true);
		}

		private void btnSq22_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(9, false, true);
		}

		private void btnSq23_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(10, false, true);
		}

		private void btnSq24_Click(object sender, EventArgs e)
		{
			count += 1;
			GeneratePic(11, false, true);
		}

		private void frmMatchingGame_Load(object sender, EventArgs e)
		{
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			int inner, outer;
			Button[] btn1To12 = { btnSq1, btnSq2, btnSq3, btnSq4, btnSq5, btnSq6, btnSq7, btnSq8, btnSq9, btnSq10, btnSq11, btnSq12 };
			Button[] btn13To24 = { btnSq13, btnSq14, btnSq15, btnSq16, btnSq17, btnSq18, btnSq19, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };
			Random rand = new Random();

			for (outer = 0; outer <= 11; outer++)
			{
				randPic[outer] = rand.Next(0, 12); // 0 to 12
				for (inner = 0; inner <= outer; inner++)
				{
					if (inner < outer)
					{
						if (randPic[outer] == randPic[inner])
						{
							outer -= 1;
							break;
						}
					}
				}
			}

			for (outer = 0; outer <= 11; outer++)
			{
				randPic1[outer] = rand.Next(0, 12); // 0 to 12
				for (inner = 0; inner <= outer; inner++)
				{
					if (inner < outer)
					{
						if (randPic1[outer] == randPic1[inner])
						{
							outer -= 1;
							break;
						}
					}
				}
			}
			for (int i = 0; i <= 11 ; i++)
			{
				btn1To12[i].Enabled = true;
				btn13To24[i].Enabled = true;
			}
			btnStart.Enabled = false;
			count = 0;
		}

		private void GeneratePic(int num, bool btn1To12Clicked, bool btn13To24Clicked)
		{
			Button[] btn1To12 = { btnSq1, btnSq2, btnSq3, btnSq4, btnSq5, btnSq6, btnSq7, btnSq8, btnSq9, btnSq10, btnSq11, btnSq12 };
			Button[] btn13To24 = { btnSq13, btnSq14, btnSq15, btnSq16, btnSq17, btnSq18, btnSq19, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };
			Button[] btn = { btnSq1, btnSq2, btnSq3, btnSq4, btnSq5, btnSq6, btnSq7, btnSq8, btnSq9, btnSq10, btnSq11, btnSq12, btnSq13, btnSq14, btnSq15, btnSq16, btnSq17, btnSq18, btnSq19, btnSq20, btnSq21, btnSq22, btnSq23, btnSq24 };
			Image[] pic = { FindCarmenSandiego.Properties.Resources.flag_1, FindCarmenSandiego.Properties.Resources.flag_2, FindCarmenSandiego.Properties.Resources.flag_3, FindCarmenSandiego.Properties.Resources.flag_4, FindCarmenSandiego.Properties.Resources.flag_5, FindCarmenSandiego.Properties.Resources.flag_6, FindCarmenSandiego.Properties.Resources.flag_7, FindCarmenSandiego.Properties.Resources.flag_8, FindCarmenSandiego.Properties.Resources.flag_9, FindCarmenSandiego.Properties.Resources.flag_10, FindCarmenSandiego.Properties.Resources.flag_11, FindCarmenSandiego.Properties.Resources.flag_12 };

			if ((btn1To12Clicked == true) && (btn13To24Clicked == false))
			{
				btn1To12[num].BackgroundImage = pic[randPic[num]];
			}

			if ((btn13To24Clicked == true) && (btn1To12Clicked == false))
			{
				btn13To24[num].BackgroundImage = pic[randPic1[num]];
			}

			if (count == 1)
			{
				if (btn1To12Clicked == true)
				{
					picClicked[0] = randPic[num];
					pic1 = randPic[num];
					btnClicked1 = num;
					btn[btnClicked1].Enabled = false;
				}
				else if (btn13To24Clicked == true)
				{
					picClicked[0] = randPic1[num];
					pic1 = randPic1[num];
					btnClicked1 = num + 12;
					btn[btnClicked1].Enabled = false;
				}
			}

			if (count == 2)
			{
				if (btn1To12Clicked == true)
				{
					picClicked[1] = randPic[num];
					pic2 = randPic[num];
					btnClicked2 = num;
					btn[btnClicked2].Enabled = false;
				}
				else if (btn13To24Clicked == true)
				{
					picClicked[1] = randPic1[num];
					pic2 = randPic1[num];
					btnClicked2 = num + 12;
					btn[btnClicked2].Enabled = false;
				}

				if (pic1 == pic2)
				{
					btn[btnClicked1].Enabled = false;
					btn[btnClicked2].Enabled = false;
					correct += 1;
				}
				else
				{
					this.Refresh();
					System.Threading.Thread.Sleep(1000);
					btn[btnClicked1].Enabled = true;
					btn[btnClicked2].Enabled = true;
					btn[btnClicked1].BackgroundImage = FindCarmenSandiego.Properties.Resources.main;
					btn[btnClicked2].BackgroundImage = FindCarmenSandiego.Properties.Resources.main;
				}

				count = 0;
			}

			if (correct == 12)
			{
				MessageBox.Show("YOU WIN!!!");
				new Coffee_shop_Scene.frmCoffeeShopScene().Show();
				this.Close();
			}

		}

	}
}
