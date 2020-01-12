using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManoharanV_ChiefFinalScene_FP
{
    public partial class frmChiefFinalScene : Form
    {
        private int scrll { get; set; }
        private int count = 0;

        public frmChiefFinalScene()
        {
            InitializeComponent();

            string path = @"\ChiefFinal.mp4";

            // add music

            wmpFinal.uiMode = "None";
            path = Application.StartupPath + path;
            wmpFinal.URL = path;
            tmrSubtitles.Start();
        }

        private void wmpFinal_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {

            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            ScrollLabel();
        }

        private void ScrollLabel()
        {
            string strString = "        And the chase for Carmen Sandiego continues...";

            scrll = scrll + 1;
            int iLmt = strString.Length - scrll;
            if (iLmt < 20)
            {
                scrll = 0;
            }
            string str = strString.Substring(scrll, 20);
            lblCredits.Text = str;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ScrollLabel();
        }

        private void tmrSubtitles_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 0 && count <= 7)
                lblCC.Text = " Congratulations Agent sdflj. You have caught that villain Carmen Sandiego, and the London police have arrested her." ;
            if (count >= 7 && count <= 12)
                lblCC.Text = "With your intelligence, dedutive reasoning, and investigation skills, you solved the crime.";
            if (count >=12 && count <= 17)
                lblCC.Text = "Unfortunately, Carmen has escaped AGAIN. We will contact you immediately when we receive intel on her.";
            if (count >= 17)
            {
                lblCC.Visible = false;
                lblCredits.Visible = true;
                tmr = new Timer();
                tmr.Tick += new EventHandler(this.TimerTick);
                tmr.Interval = 450;
                tmrSubtitles.Stop();
                tmr.Start();
            }
        }

		private void lblCredits_Click(object sender, EventArgs e)
		{

		}
	}
}
