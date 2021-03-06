﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_call
{
	public partial class frmPhoneCall : Form
	{
		public frmPhoneCall()
		{
			InitializeComponent();
		}

		private void frmPhoneCall_Load(object sender, EventArgs e)
		{
			tmrTime.Start();
		}

		private void picAcceptCall_Click(object sender, EventArgs e)
		{
			picEndCall.Visible = true;
			SplashScreen_FP.SplashScreen.NewYork = true;
			this.BackgroundImage = FindCarmenSandiego.Properties.Resources.Phone_call_ongoing;
			lblText.Visible = true;
			lblText.BringToFront();
			picThought.Visible = true;
		}

		private void picEndCall_Click(object sender, EventArgs e)
		{
			picAcceptCall.Visible = false;
			new SplashScreen_FP.frmMap().Show();
			this.Close();
		}

		private void tmrTime_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("h:mm tt");
		}

		private void picThought_Click(object sender, EventArgs e)
		{

		}
	}
}
