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
            this.label2 = new System.Windows.Forms.Label();
            this.inventorySlot3 = new System.Windows.Forms.PictureBox();
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
            this.Roof2 = new System.Windows.Forms.PictureBox();
            this.Key2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.monster = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyCountLabel = new System.Windows.Forms.Label();
            this.swordPB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shieldPB = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Roof2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).BeginInit();
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.keyCountLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inventorySlot3);
            this.panel1.Controls.Add(this.inventorySlot2);
            this.panel1.Controls.Add(this.inventorySlot1);
            this.panel1.Location = new System.Drawing.Point(1, 796);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 123);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(487, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inventory";
            // 
            // inventorySlot3
            // 
            this.inventorySlot3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot3.Location = new System.Drawing.Point(310, 15);
            this.inventorySlot3.Margin = new System.Windows.Forms.Padding(4);
            this.inventorySlot3.Name = "inventorySlot3";
            this.inventorySlot3.Size = new System.Drawing.Size(133, 62);
            this.inventorySlot3.TabIndex = 2;
            this.inventorySlot3.TabStop = false;
            // 
            // inventorySlot2
            // 
            this.inventorySlot2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot2.Location = new System.Drawing.Point(163, 15);
            this.inventorySlot2.Margin = new System.Windows.Forms.Padding(4);
            this.inventorySlot2.Name = "inventorySlot2";
            this.inventorySlot2.Size = new System.Drawing.Size(125, 62);
            this.inventorySlot2.TabIndex = 1;
            this.inventorySlot2.TabStop = false;
            // 
            // inventorySlot1
            // 
            this.inventorySlot1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot1.Location = new System.Drawing.Point(12, 15);
            this.inventorySlot1.Margin = new System.Windows.Forms.Padding(4);
            this.inventorySlot1.Name = "inventorySlot1";
            this.inventorySlot1.Size = new System.Drawing.Size(133, 62);
            this.inventorySlot1.TabIndex = 0;
            this.inventorySlot1.TabStop = false;
            // 
            // key1
            // 
            this.key1.BackColor = System.Drawing.Color.Yellow;
            this.key1.Location = new System.Drawing.Point(756, 550);
            this.key1.Margin = new System.Windows.Forms.Padding(4);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(27, 27);
            this.key1.TabIndex = 5;
            this.key1.TabStop = false;
            this.key1.Tag = "Key";
            // 
            // roof1
            // 
            this.roof1.BackColor = System.Drawing.Color.SaddleBrown;
            this.roof1.Location = new System.Drawing.Point(1, 585);
            this.roof1.Margin = new System.Windows.Forms.Padding(4);
            this.roof1.Name = "roof1";
            this.roof1.Size = new System.Drawing.Size(421, 171);
            this.roof1.TabIndex = 4;
            this.roof1.TabStop = false;
            this.roof1.Tag = "Roof";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-80, 763);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(524, 12);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Wall";
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.DimGray;
            this.playerCharacter.Image = global::FinalProject.Properties.Resources.Cooper_Avatar_Small_2__2_;
            this.playerCharacter.Location = new System.Drawing.Point(526, 682);
            this.playerCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(41, 93);
            this.playerCharacter.TabIndex = 2;
            this.playerCharacter.TabStop = false;
            this.playerCharacter.Tag = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-63, 565);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 12);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(431, 565);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Wall";
            // 
            // Door1
            // 
            this.Door1.BackColor = System.Drawing.Color.Red;
            this.Door1.Location = new System.Drawing.Point(362, 565);
            this.Door1.Name = "Door1";
            this.Door1.Size = new System.Drawing.Size(60, 10);
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
            this.pictureBox6.Location = new System.Drawing.Point(246, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(13, 210);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Wall";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(1, 197);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(184, 13);
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Wall";
            // 
            // Door2
            // 
            this.Door2.BackColor = System.Drawing.Color.Red;
            this.Door2.Location = new System.Drawing.Point(192, 200);
            this.Door2.Name = "Door2";
            this.Door2.Size = new System.Drawing.Size(51, 10);
            this.Door2.TabIndex = 11;
            this.Door2.TabStop = false;
            this.Door2.Tag = "Door2";
            // 
            // Roof2
            // 
            this.Roof2.BackColor = System.Drawing.Color.SaddleBrown;
            this.Roof2.Location = new System.Drawing.Point(13, 13);
            this.Roof2.Margin = new System.Windows.Forms.Padding(4);
            this.Roof2.Name = "Roof2";
            this.Roof2.Size = new System.Drawing.Size(225, 176);
            this.Roof2.TabIndex = 12;
            this.Roof2.TabStop = false;
            this.Roof2.Tag = "Roof";
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
            this.label1.Location = new System.Drawing.Point(1052, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Your Health";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(1164, 43);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(0, 16);
            this.healthLabel.TabIndex = 15;
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Firebrick;
            this.monster.BackgroundImage = global::FinalProject.Properties.Resources.CS_114_Final_Project_Monster__Small;
            this.monster.Location = new System.Drawing.Point(632, 197);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(89, 83);
            this.monster.TabIndex = 16;
            this.monster.TabStop = false;
            this.monster.Tag = "enemy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(487, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Keys:";
            // 
            // keyCountLabel
            // 
            this.keyCountLabel.AutoSize = true;
            this.keyCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keyCountLabel.Location = new System.Drawing.Point(533, 39);
            this.keyCountLabel.Name = "keyCountLabel";
            this.keyCountLabel.Size = new System.Drawing.Size(0, 16);
            this.keyCountLabel.TabIndex = 10;
            // 
            // swordPB
            // 
            this.swordPB.Location = new System.Drawing.Point(227, 368);
            this.swordPB.Name = "swordPB";
            this.swordPB.Size = new System.Drawing.Size(32, 71);
            this.swordPB.TabIndex = 17;
            this.swordPB.TabStop = false;
            this.swordPB.Tag = "sword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "SWORD";
            // 
            // shieldPB
            // 
            this.shieldPB.Location = new System.Drawing.Point(1020, 393);
            this.shieldPB.Name = "shieldPB";
            this.shieldPB.Size = new System.Drawing.Size(29, 74);
            this.shieldPB.TabIndex = 19;
            this.shieldPB.TabStop = false;
            this.shieldPB.Tag = "sheild";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1006, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "SHIELD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(45, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sword";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(204, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Shield";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1239, 886);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.shieldPB);
            this.Controls.Add(this.label4);
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Roof2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldPB)).EndInit();
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
        private System.Windows.Forms.PictureBox inventorySlot3;
        private System.Windows.Forms.PictureBox inventorySlot2;
        private System.Windows.Forms.PictureBox inventorySlot1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Door1;
        private System.Windows.Forms.Timer doorTime;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox Door2;
        private System.Windows.Forms.PictureBox Roof2;
        private System.Windows.Forms.PictureBox Key2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Label keyCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox swordPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox shieldPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

