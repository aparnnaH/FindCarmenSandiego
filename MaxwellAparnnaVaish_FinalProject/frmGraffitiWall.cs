using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManoharanV_SplashScreen_FP
{
    public partial class frmGraffitiWall : Form
    {
        int count = 0;

        public frmGraffitiWall()
        {
            InitializeComponent();
			tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            count ++;
			System.Threading.Thread.Sleep(750);

			if (count == 1)
			{
				picTHought.Visible = true;
			}
		}

        private void frmGraffitiWall_Click(object sender, EventArgs e)
        {
			new MaxwellMcLaughlin_G12FP_PigLatinGame.frmPigLatGame().Show();
			this.Close();
		}

		private void btnMap_Click(object sender, EventArgs e)
		{
			new ManoharanV_SplashScreen_FP.frmMap().Show();
			this.Close();
		}

		private void frmGraffitiWall_Load(object sender, EventArgs e)
		{

		}
	}
}
