using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmIndia
{
    public partial class frmTajMahal : Form
    {
        public frmTajMahal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTouristConversation frmTouristConversation = new frmTouristConversation();
            frmTouristConversation.Show();
        }

        private void btnLady_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLadyTalking frmLadyTalking = new frmLadyTalking();
            frmLadyTalking.Show();
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChildConvo frmChildConvo = new frmChildConvo();
            frmChildConvo.Show();
        }

		private void btnMap_Click(object sender, EventArgs e)
		{
			new ManoharanV_SplashScreen_FP.frmMap().Show();
			this.Close();
		}
	}
}
