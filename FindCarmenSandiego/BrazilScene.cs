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

namespace Scene_in_Brazil
{
	public partial class frmBrazilScene : Form
	{
		public frmBrazilScene()
		{
			InitializeComponent();
		}

		private int count = 0;

		private void picNewspaper_Click(object sender, EventArgs e)
		{
			Inventory(0);
			picNewspaper.Enabled = false;
		}

		private void picCalendar_Click(object sender, EventArgs e)
		{
			Inventory(1);
			picCalendar.Enabled = false;
		}

		private void picBingo_Click(object sender, EventArgs e)
		{
			Inventory(2);
			picBingo.Enabled = false;
		}

		private void Inventory(int num)
		{
			Bitmap[] picture = { FindCarmenSandiego.Properties.Resources.newspaper_stack_burned, FindCarmenSandiego.Properties.Resources.calendar, FindCarmenSandiego.Properties.Resources.bingo_card };
			PictureBox[] inventoryPicturebox = { picInventorySq1, picInventorySq2, picInventorySq3};

			inventoryPicturebox[count].Image = picture[num];
			count += 1;

			if (count == 3)
			{
				Thread.Sleep(2000);
				this.Refresh();
				new Calendar_V2.frmCalendarBingoPuzzle().Show();
				this.Close();
			}

		}

		private void btnMap_Click(object sender, EventArgs e)
		{
			new SplashScreen_FP.frmMap().Show();
			this.Close();
		}
	}
}
