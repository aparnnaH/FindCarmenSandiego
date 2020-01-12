/***********************************************************************
	PROGRAMME	:	Where in the World is Carmen Sandiego?

	OUTLINE		:	Where in the world is Carmen Sandiego is a simulation . The programme
							starts off showing the backstory of Carmen and the information required
							to complete the mission. The mission is to catch Carmen and to stop her 
							from executing her plan. 
							
							The goal of the program is to catch Carmen Sandiego and diffuse the bomb
							that has been planted in London. Though various thinking challenges, the 
							user who is a ACME agent will decode Carmen Sandiego’s clues and puzzles 
							and find her. 			 

	PROGRAMMER	:	Aparnna Hariharan, Maxwell McLauglin, Vaishnave Manoharan

	DATE					:	June 7, 2019
 ***************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManoharanV_SplashScreen_FP
{
    public partial class SplashScreen : Form
    {
        int count = 0;
		public static bool NewYork = false;
		public static bool Brazil = false;
		public static bool India = false;

		public SplashScreen()
        {
            InitializeComponent();
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            pBarLoading.Increment(1);
            lblLoading.Text = "L O A D I N G ..."+count + "%";
            count += 1;


            if (count == 101)
            {
                tmrSplash.Stop();
                this.Hide();
                frmSignIn frmSignIn = new frmSignIn();
                frmSignIn.Show();
            }

        }

		private void picSplash_Click(object sender, EventArgs e)
		{

		}
	}
 }

