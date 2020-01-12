using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxwellMcLaughlin_G12FP_PigLatinGame
{
    public partial class frmPigLatGameOpening : Form
    {
        public frmPigLatGameOpening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPigLatGame().Show();
            this.Hide();
        }
    }
}
