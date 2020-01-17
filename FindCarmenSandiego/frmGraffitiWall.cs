using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen_FP
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

            if (count == 5)
                picTHought.Visible = true;
        }

        private void frmGraffitiWall_Click(object sender, EventArgs e)
        {
			//show pig latin game
			new PigLatinGame.frmPigLatGame().Show();
			this.Close();
		}

		private void picTHought_Click(object sender, EventArgs e)
		{

		}
	}
}
