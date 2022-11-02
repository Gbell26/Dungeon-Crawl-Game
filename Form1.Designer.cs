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
            this.playerMoveTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventorySlot1 = new System.Windows.Forms.PictureBox();
            this.inventorySlot2 = new System.Windows.Forms.PictureBox();
            this.inventorySlot3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).BeginInit();
            this.SuspendLayout();
            // 
            // playerMoveTime
            // 
            this.playerMoveTime.Enabled = true;
            this.playerMoveTime.Interval = 1;
            this.playerMoveTime.Tick += new System.EventHandler(this.playerMoveTime_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox4.Location = new System.Drawing.Point(1, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(316, 139);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Roof";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-60, 620);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(393, 10);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Wall";
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter.Image = global::FinalProject.Properties.Resources.CS_114_Final_Project_Game_Avatar;
            this.playerCharacter.Location = new System.Drawing.Point(449, 526);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(43, 77);
            this.playerCharacter.TabIndex = 2;
            this.playerCharacter.TabStop = false;
            this.playerCharacter.Tag = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-47, 459);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Wall";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(323, 459);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(564, 161);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 22);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Key";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inventorySlot3);
            this.panel1.Controls.Add(this.inventorySlot2);
            this.panel1.Controls.Add(this.inventorySlot1);
            this.panel1.Location = new System.Drawing.Point(1, 647);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 100);
            this.panel1.TabIndex = 6;
            // 
            // inventorySlot1
            // 
            this.inventorySlot1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot1.Location = new System.Drawing.Point(63, 11);
            this.inventorySlot1.Name = "inventorySlot1";
            this.inventorySlot1.Size = new System.Drawing.Size(100, 50);
            this.inventorySlot1.TabIndex = 0;
            this.inventorySlot1.TabStop = false;
            // 
            // inventorySlot2
            // 
            this.inventorySlot2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot2.Location = new System.Drawing.Point(265, 11);
            this.inventorySlot2.Name = "inventorySlot2";
            this.inventorySlot2.Size = new System.Drawing.Size(94, 50);
            this.inventorySlot2.TabIndex = 1;
            this.inventorySlot2.TabStop = false;
            // 
            // inventorySlot3
            // 
            this.inventorySlot3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventorySlot3.Location = new System.Drawing.Point(437, 11);
            this.inventorySlot3.Name = "inventorySlot3";
            this.inventorySlot3.Size = new System.Drawing.Size(100, 50);
            this.inventorySlot3.TabIndex = 2;
            this.inventorySlot3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(365, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inventory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).EndInit();
            this.ResumeLayout(false);

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
    }
}

