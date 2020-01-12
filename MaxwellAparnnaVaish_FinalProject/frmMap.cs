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

    public partial class frmMap : Form
	{
		public frmMap()
			
        {
            InitializeComponent();

           PictureBox[] pictureTest = {picNewYork, picAgra, picLondon, picRiodeJaneiro};
        }

        private void picNewYork_Click(object sender, EventArgs e)
        {
            frmGraffitiWall frmGraffitiWall = new frmGraffitiWall();
            frmGraffitiWall.Show();
        }

		private void picRiodeJaneiro_Click(object sender, EventArgs e)
		{
			new Scene_in_Brazil.frmBrazilScene().Show();
			this.Close();
		}

		private void picLondon_Click(object sender, EventArgs e)
		{
			if (ManoharanV_SplashScreen_FP.SplashScreen.Brazil == true && ManoharanV_SplashScreen_FP.SplashScreen.India == true && ManoharanV_SplashScreen_FP.SplashScreen.NewYork == true)
			{
				new ManoharanV_OpenFieldLondon_FP.frmOpenField().Show();
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
			new frmGraffitiWall().Show();
			this.Close();
		}

	}
}
