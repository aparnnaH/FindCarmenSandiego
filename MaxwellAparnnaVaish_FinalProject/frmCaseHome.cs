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
    public partial class frmCaseHome : Form
    {
        public frmCaseHome()
        {
            InitializeComponent();
            lblUserName.Text = frmUserInfo.userName;
			lblMission.Text = "Diffusing a possible bomb.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMap frmMap = new frmMap();
            frmMap.Show();
        }
    }
}
