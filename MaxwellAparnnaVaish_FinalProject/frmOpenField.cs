using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManoharanV_OpenFieldLondon_FP
{
    public partial class frmOpenField : Form
    {
        int count = 0;

        public frmOpenField()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;

			if (count == 3)
				picThought.Visible = true;
			else if (count == 4)
			{
                timer1.Stop();
				btnSearch.Visible = true;
			}

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
			//code for minesweeper
			new  minesweeper_puzzle.frmMinesweeper().Show();
			this.Close();
		}

		private void frmOpenField_Load(object sender, EventArgs e)
		{

		}
	}
}
