using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxwellMcLaughlin_G12FP_Lock
{
    public partial class frmLockOpening : Form
    {
        public frmLockOpening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmLock().Show();
            this.Hide();
        }
    }
}
