using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmIndia
{
    public partial class frmTouristConversation : Form
    {
        private RadioButton[] convoChoices;
        private int count = 1;

        public frmTouristConversation()
        {
            InitializeComponent();

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            convoChoices = new RadioButton[] { rdbOne, rdbTwo, rdbThree };
            // RadioButton convo = (RadioButton)sender;
            //  lblConvo.Text = convo.Text;


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
                        btnStartGame.Visible = true;
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
                switch (num)
                {
                    case 0:
                        lblKaranSpeech1.Text = "Namaste. My name is Karan and I work as a tour guide. Would you like to be shown around the Taj Mahal.";
                        break;
                    case 1:
                        lblKaranSpeech1.Text = "I'm a tourist guide working at the Taj Mahal.";
                        break;
                    case 2:
                        lblKaranSpeech1.Text = "That is very rude. I'm a tour guide that is currently busy.";
                        break;
                }
            }
            else if (count == 2)
            {
                switch (num)
                {
                    case 0:
                        lblKaranSpeech2.Text = " Business has been really slow today. I can help you if you play a game with me.";
                        break;
                    case 1:
                        lblKaranSpeech2.Text = " Yes I have, but my memory is weak. Let's play a memory game. Maybe I will remember after.";
                        break;
                    case 2:
                        lblKaranSpeech2.Text = "Hmmm...maybe I have, maybe I haven't. Since you were rude to me, you need to win against me in a game before I say anything.";
                        break;
                }
            }
        }

        private void NextSetofChoices()
        {
             if (count == 2)
            {
                rdbOne.Text = "No thank you. I'm looking for someone. I was wondering if you saw anyone with a red coat?";
                rdbTwo.Text = "Oh that's amazing. You probably have seen a lady wearing a red coat and fedora.";
                rdbThree.Text = "Oh I'm so sorry. I'm in a hurry and was wondering if you a saw anyone with a red coat and hat.";
            }

            else if (count ==3)
            {
                rdbOne.Text = "I'm in a hurry but I'll do it.";
                rdbTwo.Text = "Ok..let's play.";
                rdbThree.Text = "Ughh...fine.";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
			//code for matching game
			new Matching_game.frmMatchingGame().Show();
			this.Close();
		}
	}
}
