using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lock
{
    //ans is 6174
    public partial class frmLock : Form
    {
        private bool blnBlink = false;
        private string strConsole = ">",strAns = "6174";
        private int intPerfect, intCorrect,intPosition;
        private char[] chrDisplay = {'-','-','-','-'};

        public frmLock()
        {
            InitializeComponent();
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            if (blnBlink != true)
            {
                lblConsole.Text = strConsole + "#";
                blnBlink = true;
            }
            else
            {
                lblConsole.Text = strConsole;
                blnBlink = false;
            }
        }

        private void frmLock_Load(object sender, EventArgs e)
        {
            tmrBlink.Start();

            Random rand = new Random();
            int intStart1;
            int intStart2;
            int intStart3;
            int intStart4;

            intStart1 = rand.Next(0,10);

            do
            {
                intStart2 = rand.Next(0, 10);
            } while (intStart1 == intStart2);

            do
            {
                intStart3 = rand.Next(0, 10);
            } while (intStart1 == intStart3 || intStart2 == intStart3);

            do
            {
                intStart4 = rand.Next(0, 10);
            } while (intStart1 == intStart4|| intStart2 == intStart4|| intStart3 == intStart4);

            strAns = intStart1.ToString() + intStart2.ToString() + intStart3.ToString() + intStart4.ToString();

        }

        private void ClearDisplay(object sender, EventArgs e)
        {
            intPosition = 0;
            intCorrect = 0;
            intPerfect = 0;
            lblDisplay.Text = "----";
            strConsole = ">";
            for (int i = 0; i < 4; i++)
            {
                chrDisplay[i] = '-';
            }
        }

        private void DisplayAdd(object sender, EventArgs e)
        {
            Button btnTarget = sender as Button;

            if (intPosition > 3)
            {
                ClearDisplay(btnBClear,e);
            }
            
            chrDisplay[intPosition] = btnTarget.Text[0];
            lblDisplay.Text = chrDisplay[0].ToString() + chrDisplay[1].ToString() + chrDisplay[2].ToString() + chrDisplay[3].ToString();
            intPosition++;
            btnEnter.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (lblDisplay.Text[i] == strAns[i])
                {
                    intPerfect++;
                }
                else if (lblDisplay.Text[i] == strAns[0] || lblDisplay.Text[i] == strAns[1] || lblDisplay.Text[i] == strAns[2] || lblDisplay.Text[i] == strAns[3])
                {
                    intCorrect++;
                }
            }
            if (intPerfect == 4)
            {
                strConsole = "> ACCESS GRANTED";
                intCorrect = 0;
                intPerfect = 0;
                MessageBox.Show("win condition");
				new pathPuzzle.frmPuzzle23().Show();
				this.Close();
				return;
            }
            strConsole = "> " + intPerfect + " number(s) correct and in the right position\n" + "> " + intCorrect + " number(s) in the wrong position";
            intCorrect = 0;
            intPerfect = 0;
        }



  


    }
}
