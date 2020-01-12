using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maxwell_McLaughlin_G12FP_puzzle23
{
    public partial class DiffuseBomb : Form
    {
        public DiffuseBomb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmPuzzle23().Show();
            this.Hide();
        }
    }
}
