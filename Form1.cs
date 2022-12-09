//Gregory Bell, Levi Bushey, Jaleel Gonzalez
//CS-114 Final Project

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

        bool characterLeft, characterRight, characterUp, characterDown, keyActivate, doorUnLock, winDoor;
        
        
        Random random = new Random();

        bool inventorySword = false;
        bool inventoryShield = false;
        bool weaponequip = false;
        bool sheild = false;
        int swordHealth = 50;
        int shieldHealth = 50;

        bool monsterAlive = true;
        int enemyHealth = 100;
        int characterHealth = 100;
        int changeDir = 0;

        int monsterSpeed = 3;
        int playerSpeed = 10;


        private void doorTime_Tick(object sender, EventArgs e)
        {
            if (doorUnLock == true)
            {
                doorUnLock = false;
                Door1.Visible = true;
                Door2.Visible = true;
                
            }
            changeDir = random.Next(4);
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

            if (Math.Abs(monster.Left-playerCharacter.Left) <= 30 ||
                Math.Abs(monster.Top - playerCharacter.Top) <= 30){
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
                        monster.Top += monsterSpeed;
                        break;
                    case 2:
                        monster.Top -= monsterSpeed;
                        break;
                    case 3:
                        monster.Left -= monsterSpeed;
                        break;             
                }
            }
            //end of enemy movement

            //Health
            if (playerCharacter.Bounds.IntersectsWith(monster.Bounds) && monsterAlive == true)
            {
                if (weaponequip == false)
                {
                    if (sheild == false)
                    {
                        characterHealth -= 1;
                    }
                    else
                    {
                        shieldHealth -= 1;
                    }
                }
                else if (weaponequip == true)
                {
                    enemyHealth -= 1;
                    swordHealth -= 1;
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
                monsterAlive = false;
            }
            healthLabel.Text = characterHealth.ToString();
            //end of health


            //monster boundarys
            if (monster.Left >= this.ClientSize.Width)
            {
                changeDir = 3;
            }

            if (monster.Left <= 0)
            {
                changeDir = 0;
            }

            if (monster.Top >= this.ClientSize.Height)
            {
                changeDir = 2;
            }

            if (monster.Top <= 0)
            {
                changeDir = 1;
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

            //end of key3
            //Door1
            if (playerCharacter.Bounds.IntersectsWith(Door1.Bounds) && characterDown == true)
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
               //End of Door code


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
            //End of Door2 code

            if (playerCharacter.Bounds.IntersectsWith(Door3.Bounds) && characterLeft == true)
            {
                if (keyActivate == true && keyCount >= 3)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door3.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                    winDoor = true;
                }
                if(winDoor == true)
                {
                    playerMoveTime.Enabled = false;
                    MessageBox.Show("You Escaped", "Congratulations!");
                }
                else
                {
                    playerCharacter.Left += playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door3.Bounds) && characterRight == true)
            {
                if (keyActivate == true && keyCount >= 3)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door3.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                    winDoor = true;
                }
                if (winDoor == true)
                {
                    playerMoveTime.Enabled = false;
                    MessageBox.Show("You Escaped", "Congratulations!");
                }
                else
                {
                    playerCharacter.Left -= playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door3.Bounds) && characterUp == true)
            {
                if (keyActivate == true && keyCount >= 3)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door3.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                    winDoor = true;
                }
                if (winDoor == true)
                {
                    playerMoveTime.Enabled = false;
                    MessageBox.Show("You Escaped", "Congratulations!");
                }
                else
                {
                    playerCharacter.Top += playerSpeed;
                }
            }
            else if (playerCharacter.Bounds.IntersectsWith(Door3.Bounds) && characterDown == true)
            {
                if (keyActivate == true && keyCount >= 3)
                {
                    doorUnLock = true;
                }
                if (doorUnLock == true)
                {
                    Door3.Visible = false;
                    doorTime.Enabled = false;
                    doorTime.Enabled = true;
                    winDoor = true;
                }
                if (winDoor == true)
                {
                    playerMoveTime.Enabled = false;
                    MessageBox.Show("You Escaped", "Congratulations!");
                }
                else
                {
                    playerCharacter.Top -= playerSpeed;
                }

            }//end Win Door

            //Shield & Sword health
            if(shieldHealth == 0)
            {
                sheild = false;
                shieldPB.Visible=true;
                shieldHealth = 100;
                equippedLbl.Text = "";
            }
            if(swordHealth == 0)
            {
                weaponequip = false;
                swordPB.Visible = true;
                swordHealth = 100;
                equippedLbl.Text = "";
            }


            //quicksand trap
            if (playerCharacter.Bounds.IntersectsWith(quickSand.Bounds) || playerCharacter.Bounds.IntersectsWith(quickSand2.Bounds)
                || playerCharacter.Bounds.IntersectsWith(quickSand3.Bounds))
            {
                playerSpeed = 2;
            }
            else
            {
                playerSpeed = 5;
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

            //equip Sword
            if (e.KeyCode == Keys.E)
            {
                if (inventorySword == true)
                {
                    equippedLbl.Text = "Sword Equipped";
                    weaponequip = true;
                    inventorySlot1.Visible = false;
                    inventorySword = false;
                }
            }
            //equip shield
            if (e.KeyCode == Keys.R)
            {
                if (inventoryShield == true)
                {
                    equippedLbl.Text = "Shield Equipped";
                    sheild = true;
                    inventorySlot2.Visible=false;
                    inventoryShield = false;
                }
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

                if (playerCharacter.Bounds.IntersectsWith(swordPB.Bounds))
                {
                    swordPB.Visible = false;
                    inventorySlot1.Visible = true;
                    inventorySword = true;
                }

                if (playerCharacter.Bounds.IntersectsWith(shieldPB.Bounds))
                {
                    shieldPB.Visible = false;
                    inventorySlot2.Visible = true;
                    inventoryShield = true;
                }

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
                if (playerCharacter.Bounds.IntersectsWith(key3.Bounds))
                {
                    if (key3.Visible == true)
                    {
                        keyCount += 1;
                        key3.Visible = false;

                    }
                }
            }




        }
    }
}
