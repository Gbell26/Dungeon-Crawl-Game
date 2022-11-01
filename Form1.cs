using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool characterLeft = false;
        bool characterRight = false;
        bool characterDown = false;
        bool characterUp = false;

        int playerSpeed = 5;

        


        private void playerMoveTime_Tick(object sender, EventArgs e)
        {
            
            //move character
            if (characterLeft == true)
            {
                playerCharacter.Left -= playerSpeed;

            }
            if (characterRight == true)
            {
                playerCharacter.Left += playerSpeed;

            }
            if (characterUp == true)
            {
                playerCharacter.Top -= playerSpeed;

            }
            if (characterDown == true)
            {
                playerCharacter.Top += playerSpeed;

            }//end of character movement

            //Make walls solid
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Wall")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterLeft == true)
                        {
                            playerCharacter.Left += playerSpeed;
                        }
                        else if(playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterRight == true)
                        {
                            playerCharacter.Left -= playerSpeed;
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterUp == true)
                        {
                            playerCharacter.Top += playerSpeed;
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterDown == true)
                        {
                            playerCharacter.Top -= playerSpeed;
                        }

                    }
                }
            }//end of walls

            //Make roof invisible on entry of room
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag == "Roof")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                        }
                    }
                }
            }//end of hide roof

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Roof")
                    {
                        if (!playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = true;
                        }
                    }
                }
            }//end of hide roof


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                characterLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                characterRight = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                characterUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                characterDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                characterLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                characterRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                characterUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                characterDown = false;
            }

            
        }
        private void RestartGame()
        {
            bool characterLeft = false;
            bool characterRight = false;
            bool characterDown = false;
            bool characterUp = false;

            int playerSpeed = 10;

            playerCharacter.Left = 422;
            playerCharacter.Top = 561;

        }
    }
}
