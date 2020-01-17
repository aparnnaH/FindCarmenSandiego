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

namespace SplashScreen_FP
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

