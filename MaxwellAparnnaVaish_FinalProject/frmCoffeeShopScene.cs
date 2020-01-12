using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Coffee_shop_Scene
{
	public partial class frmCoffeeShopScene : Form
	{

		private int seconds = 0;

		public frmCoffeeShopScene()
		{
			InitializeComponent();
		}

		private void frmCoffeeShopScene_Load(object sender, EventArgs e)
		{
			tmrCoffeeShop.Start();
		}

		private void tmrCoffeeShop_Tick(object sender, EventArgs e)
		{
			seconds += 1;
			if (seconds == 3)
			{
				this.BackgroundImage = MaxwellAparnnaVaish_FinalProject.Properties.Resources.coffe_shop_table;
				picCoffee.Visible = true;
				picAirplaneTicket.Visible = true;
			}

			if (seconds >= 8 && (picMainImage.Visible = true))
			{
				//ManoharanV_SplashScreen_FP.frmMap.India = true;
				ManoharanV_SplashScreen_FP.SplashScreen.India = true;
				new ManoharanV_SplashScreen_FP.frmMap().Show();
				this.Close();
			}
		}

		private void picAirplaneTicket_Click(object sender, EventArgs e)
		{
			picAirplaneTicket.Visible = false;
			picCoffee.Visible = false;
			picMainImage.Visible = true;
		}

	}
}
