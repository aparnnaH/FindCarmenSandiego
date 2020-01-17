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
    public partial class frmMap : Form
    {
        public frmMap()

        {
            InitializeComponent();

           PictureBox[] pictureTest = {picNewYork, picAgra, picLondon, picRiodeJaneiro};
        }

        private void picNewYork_Click(object sender, EventArgs e)
        {
			SplashScreen_FP.frmGraffitiWall frmGraffitiWall = new SplashScreen_FP.frmGraffitiWall();
            frmGraffitiWall.Show();
        }

		private void picRiodeJaneiro_Click(object sender, EventArgs e)
		{
			new Scene_in_Brazil.frmBrazilScene().Show();
			this.Close();
		}

		private void picLondon_Click(object sender, EventArgs e)
		{
			if (SplashScreen_FP.SplashScreen.Brazil == true && SplashScreen_FP.SplashScreen.India == true && SplashScreen_FP.SplashScreen.NewYork == true)
			{
				new OpenFieldLondon_FP.frmOpenField().Show();
				this.Close();
			}
		}

		private void picAgra_Click(object sender, EventArgs e)
		{
			new  frmIndia.frmTajMahal().Show();
			this.Close();
		}

		private void picNewYork_Click_1(object sender, EventArgs e)
		{
			new SplashScreen_FP.frmGraffitiWall().Show();
			this.Close();
		}

	}
}
