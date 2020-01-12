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

    public partial class frmPuzzle23 : Form
    {
        public string strRedP = "",strGreenP = "", strBlueP = "",strCrossColour = "ee",strCurrentColour = "";
        public bool blnLose = false;
        public int intTime = 80;

        public frmPuzzle23()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            btnGO.Enabled = false;
            tmrBomb.Stop();
            if (pbA71.Tag.ToString().IndexOf("d") != -1 && pbA73.Tag.ToString().IndexOf("d") != -1 && pbA76.Tag.ToString().IndexOf("d") != -1)
            {
                strRedP = "6,0," + pbA71.Tag.ToString()[0];
                pbA71.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedTurn;
                ColourRotate(pbA71);
                strGreenP = "6,2," + pbA73.Tag.ToString()[0];
                pbA73.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenTurn;
                ColourRotate(pbA73);
                strBlueP = "6,5," + pbA76.Tag.ToString()[0];
                pbA76.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueTurn;
                ColourRotate(pbA76);
                tmrTick.Start();
            }
            else
            {
                MessageBox.Show("You have failed to difuse the bomb.");
                this.Refresh();//reset game (not sure if this works)
                new frmPuzzle23().Show();
                this.Close();
            }
           
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            //PictureBox[] pbLeftEdge = {pbA11,pbA21,pbA31,pbA41,pbA51,pbA61,pbA71};
            //PictureBox[] pbRightEdge = {pbA17,pbA27,pbA37,pbA47,pbA57,pbA67,pbA77};
            //PictureBox[] pbTopEdge = {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17};
            //PictureBox[] pbBotEdge = {pbA71,pbA72,pbA73,pbA74,pbA75,pbA76,pbA77};
            if (strRedP[4] == 'W' && strGreenP[4] == 'W' && strBlueP[4] == 'W')
            {
                tmrTick.Stop();
                MessageBox.Show("win condition");
				new MaxwellMcLaughlin_G12FP_CutTheWire.frmCutTheWire().Show();
				this.Close();
			}
            if (blnLose)
            {
                tmrTick.Stop();
                MessageBox.Show("boom");
            }

            strCurrentColour = "r";
            if (Edge(strRedP))
            {
                switch (strRedP[4])
                {
                    case 'u': GoUp(ref strRedP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedForward); break;
                    case 'd': GoDown(ref strRedP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedForward); break;
                    case 'l': GoLeft(ref strRedP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedForward); break;
                    case 'r': GoRight(ref strRedP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedForward); break;
                    default:
                        break;
                }
            }
            strCurrentColour = "g";
            if (Edge(strGreenP))
            {
                switch (strGreenP[4])
                {
                    case 'u': GoUp(ref strGreenP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenForward); break;
                    case 'd': GoDown(ref strGreenP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenForward); break;
                    case 'l': GoLeft(ref strGreenP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenForward); break;
                    case 'r': GoRight(ref strGreenP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenForward); break;
                    default:
                        break;
                }
            }
            strCurrentColour = "b";
            if (Edge(strBlueP))
            {
                switch (strBlueP[4])
                {
                    case 'u': GoUp(ref strBlueP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueForward); break;
                    case 'd': GoDown(ref strBlueP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueForward); break;
                    case 'l': GoLeft(ref strBlueP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueForward); break;
                    case 'r': GoRight(ref strBlueP, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueTurn, MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueForward); break;
                    default:
                        break;
                }
            }

        }

        private void frmPuzzle23_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int intRand1 = 0,intRand2 = 0;
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            //red initialization
            pbA72.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA62.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA61.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA42.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA33.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA34.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA44.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA45.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA15.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA14.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //green initialization
            pbA74.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA55.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA56.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA47.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbA37.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA36.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA26.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA24.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA23.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //blue initialization
            pbA76.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA75.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA66.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA67.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //haring initialization
            pbA12.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA16.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA17.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA22.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA31.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA52.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA53.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbA57.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbA63.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            for (int i = 0; i < 20; i++)
            {
                intRand1 = rand.Next(0, 7);
                intRand2 = rand.Next(0, 7);
                for (int j = 0; j < rand.Next(1,4); j++)
                {
                    pb_Rotate(pbArr[rand.Next(0, 7), rand.Next(0, 7)],null);
                }
                
            }
            tmrBomb.Start();
        }

        private void pb_Rotate(object sender ,EventArgs e)
        {
            
            PictureBox pbTarget = sender as PictureBox;
            if (pbTarget != pbA25)
            {
                Image img = pbTarget.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pbTarget.Image = img;

                switch (pbTarget.Tag.ToString()[0].ToString() + pbTarget.Tag.ToString()[1].ToString())
                {
                    case "rd": pbTarget.Tag = "ld"; break;
                    case "ld": pbTarget.Tag = "lu"; break;
                    case "lu": pbTarget.Tag = "ru"; break;
                    case "ru": pbTarget.Tag = "rd"; break;
                    case "h ": pbTarget.Tag = "v "; break;
                    case "v ": pbTarget.Tag = "h "; break;
                    default:
                        break;
                }

            }
            
        }

        private void ColourRotate(PictureBox pbTarget)
        {
            Image img = pbTarget.Image;
            
            
            switch (pbTarget.Tag.ToString())
            {
                case "rd": break;
                case "ld": img.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                case "lu": img.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                case "ru": img.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                case "h ": img.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                default:
                    break;
            }
            pbTarget.Image = img;
        }

        private void CrossReColour()
        {
            switch (strCrossColour[1])
            {
                case 'e':
                    switch (strCrossColour[0])
                    {
                        case 'e': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.EmptyCrossEmpty; break;
                        case 'r': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.EmptyCrossRed; break;
                        case 'g': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.EmptyCrossGreen; break;
                        case 'b': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.EmptyCrossBlue; break;
                        default:
                            break;
                    } break;

                case 'r':
                    switch (strCrossColour[0])
                    {
                        case 'e': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedCrossEmpty; break;
                        case 'r': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedCrossRed; break;
                        case 'g': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedCrossGreen; break;
                        case 'b': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.RedCrossBlue; break;
                        default:
                            break;
                    }break;

                case 'g':
                    switch (strCrossColour[0])
                    {
                        case 'e': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenCrossEmpty; break;
                        case 'r': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenCrossRed; break;
                        case 'g': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenCrossGreen; break;
                        case 'b': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.GreenCrossBlue; break;
                        default:
                            break;
                    }break;

                case 'b':
                    switch (strCrossColour[0])
                    {
                        case 'e': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueCrossEmpty; break;
                        case 'r': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueCrossRed; break;
                        case 'g': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueCrossGreen; break;
                        case 'b': pbA25.Image = MaxwellAparnnaVaish_FinalProject.Properties.Resources.BlueCrossBlue; break;
                        default:
                            break;
                    }break;
                default:
                    break;
            }
        }
        private void GoRight(ref string strPos, Image ImgTurn, Image ImgForward)
        {
  
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            Image Img;
            if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag == "v " || pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag == "h ")
            {
                Img = ImgForward;
            }
            else
            {
                Img = ImgTurn;
            }

            if (strPos[4] == 'r')
            {
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag.ToString()[0] == 'l')
                {
                    strPos = int.Parse(strPos[0].ToString()).ToString() + "," + (int.Parse(strPos[2].ToString()) + 1).ToString() + "," + pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag.ToString()[1];
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);

                }
                else
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag.ToString()[0] == 'h')
                {
                    strPos = int.Parse(strPos[0].ToString()).ToString() + "," + (int.Parse(strPos[2].ToString()) + 1).ToString() + "," + "r";
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);
                }
                else
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) + 1].Tag.ToString()[0] == 'E')
                {
                    strCrossColour = "r" + strCrossColour[1];
                    CrossReColour();
                }
                else
                {
                    blnLose = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            new DiffuseBomb().Show();
            this.Close();
        }

        private void tmrBomb_Tick(object sender, EventArgs e)
        {
            intTime--;
            lblTime.Text = intTime.ToString();
            if (intTime <= 0)
            {
                tmrBomb.Stop();
               MessageBox.Show("boom");
                new DiffuseBomb().Show();
                this.Close();
           }
        }

        private void GoLeft(ref string strPos, Image ImgTurn, Image ImgForward)
        {
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            Image Img;
            if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag == "v " || pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag == "h ")
            {
                Img = ImgForward;
            }
            else
            {
                Img = ImgTurn;
            }

            if (strPos[4] == 'l')
            {
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag.ToString()[0] == 'r')
                {
                    strPos = int.Parse(strPos[0].ToString()).ToString() + "," + (int.Parse(strPos[2].ToString()) - 1).ToString() + "," + pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag.ToString()[1];
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);

                }
                else
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag.ToString()[0] == 'h')
                {
                    strPos = int.Parse(strPos[0].ToString()).ToString() + "," + (int.Parse(strPos[2].ToString()) - 1).ToString() + "," + "l";
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);
                }
                else
                if (pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString()) - 1].Tag.ToString()[0] == 'E')
                {
                    strPos = int.Parse(strPos[0].ToString()).ToString() + "," + (int.Parse(strPos[2].ToString()) - 1).ToString() + "," + "l";
                    strCrossColour = strCurrentColour + strCrossColour[1];
                    CrossReColour();
                }
                else
                {
                    blnLose = true;
                }
            }
        }

        private void GoUp(ref string strPos, Image ImgTurn, Image ImgForward)
        {
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            Image Img;
            if (pbArr[int.Parse(strPos[0].ToString())-1, int.Parse(strPos[2].ToString())].Tag == "v " || pbArr[int.Parse(strPos[0].ToString())-1, int.Parse(strPos[2].ToString())].Tag == "h ")
            {
                Img = ImgForward;
            }
            else
            {
                Img = ImgTurn;
            }

            if (strPos[4] == 'u')
            {
                if (pbArr[int.Parse(strPos[0].ToString())-1, int.Parse(strPos[2].ToString())].Tag.ToString()[1] == 'd')
                {
                    strPos = (int.Parse(strPos[0].ToString())-1).ToString() + "," + (int.Parse(strPos[2].ToString())).ToString() + "," + pbArr[int.Parse(strPos[0].ToString())-1, int.Parse(strPos[2].ToString())].Tag.ToString()[0];//0 was 1
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);

                }
                else
                if (pbArr[(int.Parse(strPos[0].ToString())-1), int.Parse(strPos[2].ToString())].Tag.ToString()[0] == 'v')
                {
                    strPos = (int.Parse(strPos[0].ToString()) - 1).ToString() + "," + (int.Parse(strPos[2].ToString())).ToString() + "," + "u";
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);
                }
                else
                if (pbArr[int.Parse(strPos[0].ToString())-1, int.Parse(strPos[2].ToString())].Tag.ToString()[0] == 'E')
                {
                    strPos = (int.Parse(strPos[0].ToString()) - 1).ToString() + "," + (int.Parse(strPos[2].ToString())).ToString() + "," + "u";
                    strCrossColour =   strCrossColour[0] + strCurrentColour;
                    CrossReColour();
                }
                else
                {
                    blnLose = true;
                }
            }

        }
        private void GoDown(ref string strPos, Image ImgTurn, Image ImgForward)
        {
            PictureBox[,] pbArr = new PictureBox[,] { {pbA11,pbA12,pbA13,pbA14,pbA15,pbA16,pbA17},
                                                      {pbA21,pbA22,pbA23,pbA24,pbA25,pbA26,pbA27},
                                                      {pbA31,pbA32,pbA33,pbA34,pbA35,pbA36,pbA37},
                                                      {pbA41,pbA42,pbA43,pbA44,pbA45,pbA46,pbA47},
                                                      {pbA51,pbA52,pbA53,pbA54,pbA55,pbA56,pbA57},
                                                      {pbA61,pbA62,pbA63,pbA64,pbA65,pbA66,pbA67},
                                                      {pbA71,pbA72, pbA73,pbA74,pbA75,pbA76,pbA77}};
            Image Img;
            if (pbArr[int.Parse(strPos[0].ToString()) + 1, int.Parse(strPos[2].ToString())].Tag == "v " || pbArr[int.Parse(strPos[0].ToString()) + 1, int.Parse(strPos[2].ToString())].Tag == "h ")
            {
                Img = ImgForward;
            }
            else
            {
                Img = ImgTurn;
            }

            if (strPos[4] == 'd')
            {
                if (pbArr[int.Parse(strPos[0].ToString()) + 1, int.Parse(strPos[2].ToString())].Tag.ToString()[1] == 'u')
                {
                    strPos = (int.Parse(strPos[0].ToString()) + 1).ToString() + "," + (int.Parse(strPos[2].ToString())).ToString() + "," + pbArr[int.Parse(strPos[0].ToString()) + 1, int.Parse(strPos[2].ToString())].Tag.ToString()[0];//0 was 1
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);

                }
                else
                if (pbArr[(int.Parse(strPos[0].ToString()) + 1), int.Parse(strPos[2].ToString())].Tag.ToString()[0] == 'v')
                {
                    strPos = (int.Parse(strPos[0].ToString()) + 1).ToString() + "," + (int.Parse(strPos[2].ToString())).ToString() + "," + "d";
                    pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())].Image = Img;
                    ColourRotate(pbArr[int.Parse(strPos[0].ToString()), int.Parse(strPos[2].ToString())]);//-1 or no?
                }
                else
                if (pbArr[int.Parse(strPos[0].ToString()) - 1, int.Parse(strPos[2].ToString())].Tag.ToString()[0] == 'E')
                {
                    strCrossColour = "d" + strCrossColour[1];
                    CrossReColour();
                }
                else
                {
                    blnLose = true;
                }
            }

        }
        //error checking
        private bool Edge(string strPos)
        {
            //top edge
            if (strPos[0] == '0' && strPos[4] == 'u')
            {
                if (strPos[2] == '3' && strPos == strRedP)
                {
                   
                    strRedP = strRedP[0] + "," + strRedP[2] + ",W"; //red win 
                    return false;
                }
                else
                if (strPos[2] == '2' && strPos == strGreenP)
                {
                    if (strPos[2] == '2' && strPos == strGreenP)
                    {
                       
                        strGreenP = strGreenP[0] + "," + strGreenP[2] + ",W";//green win
                        return false;
                    }
                }
                blnLose = true;
                    return false; //lose
                
            }

            //botom edge
            if (strPos[0] == '6' && strPos[4] == 'd')
            {
                blnLose = true;
                return false;//lose
            }
            //left edge
            if (strPos[2] == '0' && strPos[4] == 'l')
            {
                blnLose = true;
                return false;//lose
            }
            //Right edge
            if (strPos[2] == '6' && strPos[4] == 'r')
            {
                if (strPos[0] == '5' && strPos == strBlueP)
                {
                   
                    strBlueP = strBlueP[0] + "," + strBlueP[2] + ",W";//blue win
                    return false;
                }
                blnLose = true;
                return false;
            }
            //def
            return true;
        }
    }

    }

