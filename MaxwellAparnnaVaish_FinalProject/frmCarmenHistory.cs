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
    public partial class frmCarmenHistory : Form
    {
        int count = 0;

        public frmCarmenHistory()
        {
            InitializeComponent();
            string path = @"\fullbackstory.mp4";

           // add music
                       
            wmpCarmenHistory.uiMode = "None";
            path = Application.StartupPath + path; 
            wmpCarmenHistory.URL = path;
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            count += 1;

			if (count <= 10)
				lblSubtitles.Text = "A.C.M.E is an international organization that is dedicated to fighting crime. We train the recruits in a vigourous 4-year program to become spies. ";

			else if (count > 10 & count <= 19)
				lblSubtitles.Text = " Carmen Sandiego was one of the brightest students ever to pass through the academy. She was the youngest in the cohort yet the most brilliant. ";
			else if (count > 20 & count <= 30)
				lblSubtitles.Text = "We trained the agents in all areas. From combat, agility, arts, cloaking, hacking and more.";
			else if (count > 30 & count <= 34)
				lblSubtitles.Text = "Finally it was graduation day. Everyone was eager to see if they passed and could start fighting and solving real crimes.";
			else if (count > 35 & count <= 42)
				lblSubtitles.Text = "However we couldn't let Carmen graduate due to her age. She was rejected and it absolutely devastated her.";
			else if (count > 42 & count <= 47)
				lblSubtitles.Text = "She was so angry and hated A.C.M.E for not treating her as a rightful agent.";
			else if (count > 47 & count <= 54)
				lblSubtitles.Text = "Then she saw the infamous red cloak and fedora. An evil lightbulb went off in her head.";
			else if (count > 55 & count <= 63)
				lblSubtitles.Text = "She snuck past the guards carefully.";
			else if (count > 63 & count <= 70)
				lblSubtitles.Text = "She hijacked a boat and escaped the academy with all our secrets.";
			else if (count > 71 & count <= 76)
				lblSubtitles.Text = "She began her life as Carmen Sandiego - a robber, a thief, and A.C.M.E's most wanted villain!";
			else if (count > 76 & count <= 80)
			{
				WMPLib.IWMPControls3 pause = (WMPLib.IWMPControls3)wmpCarmenHistory.Ctlcontrols;
				if (pause.get_isAvailable("pause"))
				{
					pause.pause();
				}
			}
			else if (count > 80)
			{
				this.Close();
				frmCaseHome frmCaseHome = new frmCaseHome();
				frmCaseHome.Show();
			}
                
        }

		private void lblSubtitles_Click(object sender, EventArgs e)
		{
		}
	}
}
