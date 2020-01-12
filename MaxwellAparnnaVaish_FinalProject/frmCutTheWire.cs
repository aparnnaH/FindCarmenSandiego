using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxwellMcLaughlin_G12FP_CutTheWire
{
    public partial class frmCutTheWire : Form
    {
        public int intDec = 0,intSec = 10;
        public frmCutTheWire()
        {
            InitializeComponent();
        }

        private void frmCutTheWire_Load(object sender, EventArgs e)
        {
            tmrTick.Start();
        }

        private void pbRed_Click(object sender, EventArgs e)
        {
            pbRed.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedCutV2;
            pbBlue.Enabled = false;
            pbGreen.Enabled = false;
            tmrTick.Stop();
			new ManoharanV_CarmenChaseScene.frmCarmenChaseScene().Show();
			this.Close();
		}

        private void pbBlue_Click(object sender, EventArgs e)
        {
            pbBlue.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueCutV2;
            pbRed.Enabled = false;
            pbGreen.Enabled = false;
        }

        private void pbGreen_Click(object sender, EventArgs e)
        {
            pbGreen.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenCutV2;
            pbBlue.Enabled = false;
            pbRed.Enabled = false;
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            if (intDec == 0 && intSec > 0)
            {
                intDec = 99;
                intSec--;
                lblTime.Text = intSec + ":" + intDec;
            }
            else if (intDec >=0 && intSec >= 0)
            {
                intDec--;
                lblTime.Text = intSec + ":" + intDec;
            }
            else if (intDec <= 0 && intSec <= 0)
            {
                tmrTick.Stop();
                MessageBox.Show("fail");
				new MaxwellMcLaughlin_G12FP_CutTheWire.frmCutTheWire().Show();
				this.Close();
			}
           
        }
    }
}
