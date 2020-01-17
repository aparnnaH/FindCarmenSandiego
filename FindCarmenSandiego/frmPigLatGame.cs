using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGame
{
    public partial class frmPigLatGame : Form
    {

        private int intTime = 80;
        
        public frmPigLatGame()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
			if (txtEnter.Text == "I love Brazil. Especially the city with Christ.".ToUpper() || txtEnter.Text == "I love Brazil.Especially the city with Christ.".ToUpper())
			{
				tmrPuzzle.Stop();
				MessageBox.Show("Yes this is the secret message! What's the city in Brazil with the Christ??? Rio de Janeiro!", "Where in the World is Carmen Sandiego?");
				SplashScreen_FP.SplashScreen.NewYork = true;
				new Phone_call.frmPhoneCall().Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("That is not the correct translation. I have to try again. I should watch for puncuation and capitalization!", "Failed translation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtEnter.Clear();
				txtEnter.Focus();
			}
		}

        private void frmPigLatGame_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
        }

        private void tmrPuzzle_Tick(object sender, EventArgs e)
        {

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
