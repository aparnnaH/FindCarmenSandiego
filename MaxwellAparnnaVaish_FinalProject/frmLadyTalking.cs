using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmIndia
{
    public partial class frmLadyTalking : Form
    {
        private RadioButton[] convoChoices;
        private int count = 1;

        public frmLadyTalking()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click_1(object sender, EventArgs e)
        {
            convoChoices = new RadioButton[] { rdbOne, rdbTwo, rdbThree };

            for (int i = 0; i < convoChoices.Length; i++)
            {
                if (convoChoices[i].Checked == true)
                {
                    if (count == 1)
                        (lblAgent1).Text = convoChoices[i].Text;
                    else if (count == 2)
                        (lblAgent2).Text = convoChoices[i].Text;
                    else if (count == 3)
                    {
                        (lblAgent3).Text = convoChoices[i].Text;
                        btnBack.Visible = true;
                    }
                    KaranResponse(i);
                }
            }
            count++;
            NextSetofChoices();
        }
        private void KaranResponse(int num)
        {
            if (count == 1)
            {              
                        lblLadySpeech1.Text = "Namaste.";                      
            }
            else if (count == 2)
            {
               
                        lblLadySpeech2.Text = "No English. Only Hindi.";            
                
            }
        }

        private void NextSetofChoices()
        {
            if (count == 2)
            {
                rdbOne.Text = " I was wondering if you saw anyone with a red coat?";
                rdbTwo.Text = "You probably have seen a lady wearing a red coat and fedora.";
                rdbThree.Text = "I'm in a hurry and was wondering if you a saw anyone with a red coat and hat.";
            }

            else if (count == 3)
            {
                rdbOne.Text = "Oh I'm so sorry.";
                rdbTwo.Text = "Thank you for your help.";
                rdbThree.Text = "Enjoy your trip.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTajMahal Form1 = new frmTajMahal();
            Form1.Show();
        }
    }
}
