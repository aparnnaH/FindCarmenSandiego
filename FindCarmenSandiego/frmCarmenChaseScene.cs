using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarmenChaseScene
{
    public partial class frmCarmenChaseScene : Form
    {
        public frmCarmenChaseScene()
        {
            InitializeComponent();
            string path = @"\CarmenEscape.mp4";

            // add music

            wmpEscape.uiMode = "None";
            path = Application.StartupPath + path;
            wmpEscape.URL = path;
        }

        private void wmpEscape_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
				new  ChiefFinalScene_FP.frmChiefFinalScene().Show();
				this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {			
		}
	}
}
