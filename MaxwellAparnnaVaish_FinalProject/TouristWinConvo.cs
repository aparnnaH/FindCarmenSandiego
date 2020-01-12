using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxwellAparnnaVaish_FinalProject
{
	public partial class TouristWinConvo : Form
	{
		public TouristWinConvo()
		{
			InitializeComponent();
			lblAgent1.Text = "I won the game. Tell me where you last saw Carmen!";
			System.Threading.Thread.Sleep(1500);
			lblKaranSpeech1.Text = "I saw a lady sitting and reading the newspaper in the coffee shop down the street.";
			System.Threading.Thread.Sleep(1500);
			lblAgent2.Text = "Got it. Thank you.";
			System.Threading.Thread.Sleep(1500);
			new Coffee_shop_Scene.frmCoffeeShopScene().Show();
			this.Close();
		}

		private void TouristWinConvo_Load(object sender, EventArgs e)
		{

		}
	}
}
