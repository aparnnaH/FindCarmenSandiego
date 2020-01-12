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
    public partial class frmCutTheWireOpening : Form
    {
        public frmCutTheWireOpening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmCutTheWire().Show();
            this.Hide();
        }
    }
}
