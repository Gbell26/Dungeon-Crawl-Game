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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.changeDirection = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(756, 550);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 27);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Key";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox4.Location = new System.Drawing.Point(1, 585);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(421, 171);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Roof";
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
            this.doorTime.Interval = 3000;
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
            // changeDirection
            // 
            this.changeDirection.Enabled = true;
            this.changeDirection.Interval = 1000;
            this.changeDirection.Tick += new System.EventHandler(this.changeDirection_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1239, 886);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Roof2);
            this.Controls.Add(this.Door2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Door1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer playerMoveTime;
        public System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
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
        private System.Windows.Forms.Timer changeDirection;
    }
}

