using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen_FP
{
    public partial class frmCaseHome : Form
    {
        public frmCaseHome()
        {
            InitializeComponent();
            lblUserName.Text = SplashScreen_FP.frmUserInfo.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
			SplashScreen_FP.frmMap frmMap = new SplashScreen_FP.frmMap();
            frmMap.Show();
        }
    }
}
