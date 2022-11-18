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

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool characterLeft, characterRight, characterUp, characterDown, keyActivate, doorUnLock;
        int characterHealth = 100;
        int monsterSpeed = 3;
        Random random = new Random();
        bool weaponequip = true;
        bool sheild = false;
        int enemyHealth = 100;


        int changeDir = 0;

        int playerSpeed = 5;

        private void doorTime_Tick(object sender, EventArgs e)
        {
            if (doorUnLock == true)
            {
                doorUnLock = false;
                Door1.Visible = true;
                Door2.Visible = true;
                
            }
        }

        private void changeDirection_Tick(object sender, EventArgs e)
        {
            changeDir = random.Next(7);
        }

        int keyCount = 0;

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

            }
            //end of character movement


            //enemy movement
            
            switch (changeDir)
            {
                //right movements
                case 0:
                    monster.Left += monsterSpeed;
                    break;
                case 1:
                    monster.Top -= monsterSpeed;
                    monster.Left += monsterSpeed;
                    break;
                case 2:
                    monster.Top += monsterSpeed;
                    break;
                case 3:
                    monster.Top -= monsterSpeed;    
                    break;
                case 4:
                    monster.Left -= monsterSpeed;
                    break;
                case 5:
                    monster.Top += monsterSpeed;
                    monster.Left -= monsterSpeed;
                    break;
                case 6:
                    monster.Top -= monsterSpeed;
                    monster.Left -= monsterSpeed;
                    break;
            }
            /*
            if (monster.Left <= playerCharacter.Left)
            {
                monster.Left += monsterSpeed;
            }
            else if (monster.Left >= playerCharacter.Right)
            {
                monster.Left -= monsterSpeed;
            }

            if (monster.Top <= playerCharacter.Top)
            {
                monster.Top += monsterSpeed;
            }
            else if (monster.Top >= playerCharacter.Top)
            {
                monster.Top -= monsterSpeed;
            }//end of enemy movement
            */
            //Health
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "enemy")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (weaponequip == false)
                            {
                                if (sheild == false)
                                {
                                    playerCharacter.BackColor = Color.Red;
                                    characterHealth -= 1;
                                }
                            }
                            else if (weaponequip == true)
                            {
                                x.BackColor = Color.Red;
                                enemyHealth -= 1;
                            }
                        }
                        else
                        {
                            playerCharacter.BackColor = Color.Blue;
                        }
                    }
                }
            }
            if (characterHealth <= 0)
            {
                playerMoveTime.Enabled = false;
                MessageBox.Show("You Died", "sorry");

            }
            if (enemyHealth <= 0)
            {
                monster.Visible = false;
            }
            healthLabel.Text = characterHealth.ToString();

            //end of health
            //monster boundarys(might need to go into new timer)
            if (monster.Left >= this.ClientSize.Width)
            {
                changeDir = 4;
            }

            if (monster.Left <= 0)
            {
                changeDir = 0;
            }

            if (monster.Top >= this.ClientSize.Height)
            {
                changeDir = 3;
            }

            if (monster.Top <= 0)
            {
                changeDir = 2;
            }
            //end of monster boundaries

            //Make walls solid
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Wall")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterLeft == true)
                        {
                            playerCharacter.Left += playerSpeed;
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterRight == true)
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
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Roof")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                        }
                        else
                        {
                            x.Visible=true;
                        }
                    }
                }
            }//end of hide roof/show roof

           
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Key")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            keyCount += 1;
                            inventorySlot1.BackColor = Color.Yellow;
                        }
                    }
                }
            }//end of key

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Key2")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            keyCount += 1;
                            inventorySlot2.BackColor = Color.Yellow;
                        }
                    }
                }
            }//end of key2

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Door")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterLeft == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if(doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Left += playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterRight == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Left -= playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterUp == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Top += playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterDown == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Top -= playerSpeed;
                            }

                        }

                    }
                }
            }//End of Door code


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Door2")
                    {
                        if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterLeft == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Left += playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterRight == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Left -= playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterUp == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Top += playerSpeed;
                            }
                        }
                        else if (playerCharacter.Bounds.IntersectsWith(x.Bounds) && characterDown == true)
                        {
                            if (keyActivate == true && keyCount >= 1)
                            {
                                doorUnLock = true;
                            }
                            if (doorUnLock == true)
                            {
                                x.Visible = false;
                                doorTime.Enabled = false;
                                doorTime.Enabled = true;
                            }
                            else
                            {
                                playerCharacter.Top -= playerSpeed;
                            }

                        }

                    }
                }
            }//End of Door2 code


            //reset doors
            /* if (doorUnLock == true)
             {
                 int milliseconds = 5000;
                 Thread.Sleep(milliseconds);
                 doorUnLock = false;

             }
            */

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //get key inputs for character movement
            if (e.KeyCode == Keys.Left)
            {
                characterLeft = true;
                characterRight = false;
                characterUp = false;
                characterDown = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                characterRight = true;
                characterLeft = false;
                characterUp = false;
                characterDown = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                characterUp = true;
                characterLeft = false;
                characterRight = false;
                characterDown = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                characterDown = true;
                characterLeft = false;
                characterRight = false;
                characterUp = false;
    
            }

            if(e.KeyCode == Keys.Space)
            {
                keyActivate = true;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //stops moving when you lift directional key
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
            if (e.KeyCode == Keys.Space)
            {
                keyActivate = false;
            }


        }
        private void RestartGame()
        {
            bool characterLeft = false;
            bool characterRight = false;
            bool characterDown = false;
            bool characterUp = false;

            int playerSpeed = 5;

            playerCharacter.Left = 422;
            playerCharacter.Top = 561;

        }
    }
}
