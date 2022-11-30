namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerMoveTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.keyCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inventorySlot2 = new System.Windows.Forms.PictureBox();
            this.inventorySlot1 = new System.Windows.Forms.PictureBox();
            this.key1 = new System.Windows.Forms.PictureBox();
            this.roof1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Door1 = new System.Windows.Forms.PictureBox();
            this.doorTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Door2 = new System.Windows.Forms.PictureBox();
            this.Key2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.monster = new System.Windows.Forms.PictureBox();
            this.swordPB = new System.Windows.Forms.PictureBox();
            this.shieldPB = new System.Windows.Forms.PictureBox();
            this.quickSand = new System.Windows.Forms.PictureBox();
            this.Roof2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickSand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roof2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerMoveTime
            // 
            this.playerMoveTime.Enabled = true;
            this.playerMoveTime.Interval = 1;
            this.playerMoveTime.Tick += new System.EventHandler(this.playerMoveTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.keyCountLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inventorySlot2);
            this.panel1.Controls.Add(this.inventorySlot1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 783);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 103);
            this.panel1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(885, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Equip: R";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(299, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Equip: E";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(888, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shield";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(300, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sword";
            // 
            // keyCountLabel
            // 
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyCountLabel.Location = new System.Drawing.Point(76, 27);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(0, 25);
            this.keyCountLabel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keys:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(571, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inventory";
            // 
            // inventorySlot2
            // 
            this.inventorySlot2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot2.Location = new System.Drawing.Point(849, 27);
            this.inventorySlot2.Margin = new System.Windows.Forms.Padding(4);
            this.inventorySlot2.Name = "inventorySlot2";
            this.inventorySlot2.Size = new System.Drawing.Size(125, 62);
            this.inventorySlot2.TabIndex = 1;
            this.inventorySlot2.TabStop = false;
            // 
            // inventorySlot1
            // 
            this.inventorySlot1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot1.Location = new System.Drawing.Point(269, 28);
            this.inventorySlot1.Margin = new System.Windows.Forms.Padding(4);
            this.inventorySlot1.Name = "inventorySlot1";
            this.inventorySlot1.Size = new System.Drawing.Size(133, 62);
            this.inventorySlot1.TabIndex = 0;
            this.inventorySlot1.TabStop = false;
            // 
            // key1
            // 
            this.key1.BackColor = System.Drawing.Color.Yellow;
            this.key1.Location = new System.Drawing.Point(1184, 496);
            this.key1.Margin = new System.Windows.Forms.Padding(4);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(27, 27);
            this.key1.TabIndex = 5;
            this.key1.TabStop = false;
            this.key1.Tag = "Key";
            // 
            // roof1
            // 
            this.roof1.BackColor = System.Drawing.Color.Transparent;
            this.roof1.BackgroundImage = global::FinalProject.Properties.Resources.roof2;
            this.roof1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roof1.Location = new System.Drawing.Point(2, 582);
            this.roof1.Margin = new System.Windows.Forms.Padding(4);
            this.roof1.Name = "roof1";
            this.roof1.Size = new System.Drawing.Size(421, 173);
            this.roof1.TabIndex = 4;
            this.roof1.TabStop = false;
            this.roof1.Tag = "Roof";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImage = global::FinalProject.Properties.Resources.cobblestones;
            this.pictureBox3.Location = new System.Drawing.Point(-80, 756);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(524, 19);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Wall";
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.White;
            this.playerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playerCharacter.Image = global::FinalProject.Properties.Resources.Cooper_Avatar_Small_2__2_;
            this.playerCharacter.Location = new System.Drawing.Point(657, 650);
            this.playerCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(32, 85);
            this.playerCharacter.TabIndex = 2;
            this.playerCharacter.TabStop = false;
            this.playerCharacter.Tag = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BackgroundImage = global::FinalProject.Properties.Resources.cobblestones;
            this.pictureBox2.Location = new System.Drawing.Point(-63, 565);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 22);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::FinalProject.Properties.Resources.cobblestones;
            this.pictureBox1.Location = new System.Drawing.Point(424, 565);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Wall";
            // 
            // Door1
            // 
            this.Door1.BackColor = System.Drawing.Color.Red;
            this.Door1.Location = new System.Drawing.Point(350, 565);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(80, 22);
            this.Door1.TabIndex = 8;
            this.Door1.TabStop = false;
            this.Door1.Tag = "Door";
            // 
            // doorTime
            // 
            this.doorTime.Enabled = true;
            this.doorTime.Interval = 2000;
            this.doorTime.Tick += new System.EventHandler(this.doorTime_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.BackgroundImage = global::FinalProject.Properties.Resources.cobblestones;
            this.pictureBox6.Location = new System.Drawing.Point(240, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 210);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Wall";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.BackgroundImage = global::FinalProject.Properties.Resources.cobblestones;
            this.pictureBox7.Location = new System.Drawing.Point(1, 193);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(184, 20);
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Wall";
            // 
            // Door2
            // 
            this.Door2.BackColor = System.Drawing.Color.Red;
            this.Door2.Location = new System.Drawing.Point(182, 193);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(61, 20);
            this.Door2.TabIndex = 11;
            this.Door2.TabStop = false;
            this.Door2.Tag = "Door2";
            // 
            // Key2
            // 
            this.Key2.BackColor = System.Drawing.Color.Yellow;
            this.Key2.Location = new System.Drawing.Point(31, 28);
            this.Key2.Margin = new System.Windows.Forms.Padding(4);
            this.Key2.Name = "Key2";
            this.Key2.Size = new System.Drawing.Size(27, 27);
            this.Key2.TabIndex = 13;
            this.Key2.TabStop = false;
            this.Key2.Tag = "Key2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(991, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Health";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(1111, 13);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(0, 25);
            this.healthLabel.TabIndex = 15;
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.BackgroundImage = global::FinalProject.Properties.Resources.CS_114_Final_Project_Monster;
            this.monster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.monster.Location = new System.Drawing.Point(606, 169);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(73, 81);
            this.monster.TabIndex = 16;
            this.monster.TabStop = false;
            this.monster.Tag = "enemy";
            // 
            // swordPB
            // 
            this.swordPB.BackColor = System.Drawing.Color.Transparent;
            this.swordPB.BackgroundImage = global::FinalProject.Properties.Resources.CS_114_Sword;
            this.swordPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordPB.Location = new System.Drawing.Point(304, 193);
            this.swordPB.Name = "swordPB";
            this.swordPB.Size = new System.Drawing.Size(56, 85);
            this.swordPB.TabIndex = 17;
            this.swordPB.TabStop = false;
            this.swordPB.Tag = "sword";
            // 
            // shieldPB
            // 
            this.shieldPB.BackColor = System.Drawing.Color.Transparent;
            this.shieldPB.BackgroundImage = global::FinalProject.Properties.Resources.CS_114_Shield;
            this.shieldPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shieldPB.Location = new System.Drawing.Point(930, 308);
            this.shieldPB.Name = "shieldPB";
            this.shieldPB.Size = new System.Drawing.Size(72, 85);
            this.shieldPB.TabIndex = 19;
            this.shieldPB.TabStop = false;
            this.shieldPB.Tag = "sheild";
            // 
            // quickSand
            // 
            this.quickSand.BackColor = System.Drawing.Color.SandyBrown;
            this.quickSand.Location = new System.Drawing.Point(495, 392);
            this.quickSand.Name = "quickSand";
            this.quickSand.Size = new System.Drawing.Size(252, 75);
            this.quickSand.TabIndex = 21;
            this.quickSand.TabStop = false;
            // 
            // Roof2
            // 
            this.Roof2.BackColor = System.Drawing.Color.Transparent;
            this.Roof2.BackgroundImage = global::FinalProject.Properties.Resources.roof2;
            this.Roof2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Roof2.Location = new System.Drawing.Point(0, 0);
            this.Roof2.Margin = new System.Windows.Forms.Padding(4);
            this.Roof2.Name = "Roof2";
            this.Roof2.Size = new System.Drawing.Size(243, 193);
            this.Roof2.TabIndex = 12;
            this.Roof2.TabStop = false;
            this.Roof2.Tag = "Roof";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1239, 886);
            this.Controls.Add(this.quickSand);
            this.Controls.Add(this.shieldPB);
            this.Controls.Add(this.swordPB);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Roof2);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.roof1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Key2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickSand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roof2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer playerMoveTime;
        public System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox roof1;
        private System.Windows.Forms.PictureBox key1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox inventorySlot2;
        private System.Windows.Forms.PictureBox inventorySlot1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Door1;
        private System.Windows.Forms.Timer doorTime;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox Door2;
        private System.Windows.Forms.PictureBox Key2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Label keyCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox swordPB;
        private System.Windows.Forms.PictureBox shieldPB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox quickSand;
        private System.Windows.Forms.PictureBox Roof2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

