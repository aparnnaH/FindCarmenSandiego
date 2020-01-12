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
    public partial class frmChiefExplainingCarmen : Form
    {
        int count = 0;

        public frmChiefExplainingCarmen()
        {
            InitializeComponent();
            tmr3.Start();
            wmpChiefIntro.uiMode = "None";

        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            count += 1;

            if (count == 7)
            {
                picLoading.Visible = false;                
                wmpChiefIntro.URL =  Application.StartupPath + @"\ChiefIntro.mp4";
            }
            if (count == 25)
            {
                picLoading.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.chiefgif;
                picLoading.SizeMode = PictureBoxSizeMode.StretchImage;
                picLoading.Visible = true;
                lblCover.Visible = false;
                lblCaption.Visible = true;
            }
            if (count == 29)
            {
                picStartVideo.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.carmenVideoSS;
                picLoading.Visible = false;
                picStartVideo.Visible = true;
                picStartVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (count == 30)
            {
                for (int i = 0; i < 40; i++)
                {
                    picStartVideo.Left -= 3;
                    picStartVideo.Top -= 3;
                    picStartVideo.Height +=5;
                    picStartVideo.Width +=8;
                }
            }
        }

        private void picStartVideo_Click(object sender, EventArgs e)
        {
                this.Close();
                frmCarmenHistory frmCarmenHistory = new frmCarmenHistory();
                frmCarmenHistory.Show();
        }

		private void lblCaption_Click(object sender, EventArgs e)
		{

		}
	}
}
