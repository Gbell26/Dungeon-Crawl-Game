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
        bool weaponequip = false;
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

            if (Math.Abs(monster.Left-playerCharacter.Left) <= 25 || Math.Abs(monster.Top - playerCharacter.Top) <= 25){
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
                }
            }
            else {
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
            }
           //end of enemy movement
            
            //Health
            if (playerCharacter.Bounds.IntersectsWith(monster.Bounds))
            {
                if (weaponequip == false)
                {
                    if (sheild == false)
                    {
                        characterHealth -= 1;
                    }
                }
                else if (weaponequip == true)
                {
                    enemyHealth -= 1;
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


            //monster boundarys
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
            if (playerCharacter.Bounds.IntersectsWith(Roof2.Bounds))
            {
                Roof2.Visible = false;
            }
            else
            {
                Roof2.Visible = true;
            }


            if (playerCharacter.Bounds.IntersectsWith(roof1.Bounds))
            {
                roof1.Visible = false;
            }
            else
            {
                roof1.Visible = true;
            }//end of hide roof/show roof

            keyCountLabel.Text = keyCount.ToString();

            if (playerCharacter.Bounds.IntersectsWith(key1.Bounds))
            {
                if (key1.Visible == true)
                {
                    keyCount += 1;
                    key1.Visible = false;

                }
            }
            //end of key
            if (playerCharacter.Bounds.IntersectsWith(Key2.Bounds))
            {
                if (Key2.Visible == true)
                {
                    keyCount += 1;
                    Key2.Visible = false;

                }
            }//end of key2
            //Door1
                if (playerCharacter.Bounds.IntersectsWith(Door1.Bounds) && characterLeft == true)
                {
                    if (keyActivate == true && keyCount >= 1)
                    {
                        doorUnLock = true;
                    }
                    if (doorUnLock == true)
                    {
                    Door1.Visible = false;
                        doorTime.Enabled = false;
                        doorTime.Enabled = true;
                    }
                    else
                    {
                        playerCharacter.Left += playerSpeed;
                    }
                }
                else if (playerCharacter.Bounds.IntersectsWith(Door1.Bounds) && characterRight == true)
                {
                    if (keyActivate == true && keyCount >= 1)
                    {
                        doorUnLock = true;
                    }
                    if (doorUnLock == true)
                    {
                    Door1.Visible = false;
                        doorTime.Enabled = false;
                        doorTime.Enabled = true;
                    }
                    else
                    {
                        playerCharacter.Left -= playerSpeed;
                    }
                }
                else if (playerCharacter.Bounds.IntersectsWith(Door1.Bounds) && characterUp == true)
                {
                    if (keyActivate == true && keyCount >= 1)
                    {
                        doorUnLock = true;
                    }
                    if (doorUnLock == true)
                    {
                    Door1.Visible = false;
                        doorTime.Enabled = false;
                        doorTime.Enabled = true;
                    }
                    else
                    {
                        playerCharacter.Top += playerSpeed;
                    }
                }
                else if (playerCharacter.Bounds.IntersectsWith(Door1.Bounds) && characterDown == true)
                {
                    if (keyActivate == true && keyCount >= 1)
                    {
                        doorUnLock = true;
                    }
                    if (doorUnLock == true)
                    {
                    Door1.Visible = false;
                        doorTime.Enabled = false;
                        doorTime.Enabled = true;
                    }
                    else
                    {
                        playerCharacter.Top -= playerSpeed;
                    }

                }//End of Door code


            if (playerCharacter.Bounds.IntersectsWith(Door2.Bounds) && characterLeft == true)
            {
                if (keyActivate == true && keyCount >= 1)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door2.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                }
                else
                {
                    playerCharacter.Left += playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door2.Bounds) && characterRight == true)
            {
                if (keyActivate == true && keyCount >= 1)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door2.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                }
                else
                {
                    playerCharacter.Left -= playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door2.Bounds) && characterUp == true)
            {
                if (keyActivate == true && keyCount >= 1)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door2.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                }
                else
                {
                    playerCharacter.Top += playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door2.Bounds) && characterDown == true)
            {
                if (keyActivate == true && keyCount >= 1)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door2.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                }
                else
                {
                    playerCharacter.Top -= playerSpeed;
                }

            }//End of Door2 code

            //ADD SWORD & SHIELD HITPOINTS
           if (playerCharacter.Bounds.IntersectsWith(swordPB.Bounds))
           {
                swordPB.Visible = false;
                inventorySlot1.BackColor = Color.Violet;
                inventorySlot1.Tag = "sword";
           }   
           else
           {
                swordPB.Visible = true;
           }

            if (playerCharacter.Bounds.IntersectsWith(shieldPB.Bounds))
            {
                shieldPB.Visible = false;
                inventorySlot2.BackColor = Color.Violet;
                inventorySlot2.Tag = "sword";
            }
            else
            {
                swordPB.Visible = true;
            }

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
