using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ManoharanV_SplashScreen_FP
{
    public partial class frmUserInfo : Form
    {
        public static string userName="";

        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            Match match = regex.Match(txtUserName.Text);

            if (match.Success == false)  // Only letters should be valid      
            {
                MessageBox.Show("Enter letters only!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtUserName.Clear();
                txtUserName.Focus();
            }
            else
            {
                userName = (txtUserName.Text);
                userName = userName.First().ToString().ToUpper() + userName.Substring(1);
                DialogResult result =MessageBox.Show("Welcome Agent " + userName + "!", "A.C.M.E Login",MessageBoxButtons .OK, MessageBoxIcon.None) ;

                if (result == DialogResult.OK)
                {
                    this.Close();
                    frmChiefExplainingCarmen frmChiefExplainingCarmen = new frmChiefExplainingCarmen();
                    frmChiefExplainingCarmen.Show();
                }
            }
            
        }

	}
}
