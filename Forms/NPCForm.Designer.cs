namespace TestingGrounds
{
    partial class NPCForm
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
            this.lstb_NPCs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Gen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.txtb_Type = new System.Windows.Forms.TextBox();
            this.txtb_Specialty = new System.Windows.Forms.TextBox();
            this.txtb_Weapon = new System.Windows.Forms.TextBox();
            this.txtb_HP = new System.Windows.Forms.TextBox();
            this.txtb_Mana = new System.Windows.Forms.TextBox();
            this.txtb_Stamina = new System.Windows.Forms.TextBox();
            this.txtb_GP = new System.Windows.Forms.TextBox();
            this.txtb_Level = new System.Windows.Forms.TextBox();
            this.txtb_EXPDrop = new System.Windows.Forms.TextBox();
            this.txtb_GPDrop = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtb_Armour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstb_NPCs
            // 
            this.lstb_NPCs.FormattingEnabled = true;
            this.lstb_NPCs.Location = new System.Drawing.Point(8, 8);
            this.lstb_NPCs.Name = "lstb_NPCs";
            this.lstb_NPCs.Size = new System.Drawing.Size(288, 134);
            this.lstb_NPCs.TabIndex = 0;
            this.lstb_NPCs.SelectedIndexChanged += new System.EventHandler(this.lstb_NPCs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPCs";
            // 
            // btn_Gen
            // 
            this.btn_Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gen.Location = new System.Drawing.Point(488, 328);
            this.btn_Gen.Name = "btn_Gen";
            this.btn_Gen.Size = new System.Drawing.Size(96, 32);
            this.btn_Gen.TabIndex = 2;
            this.btn_Gen.Text = "Generate";
            this.btn_Gen.UseVisualStyleBackColor = true;
            this.btn_Gen.Click += new System.EventHandler(this.btn_Gen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "GP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stamina:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Specialty:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "EXP Drop:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "GP Drop:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(304, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Weapon:";
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(384, 40);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.ReadOnly = true;
            this.txtb_Name.Size = new System.Drawing.Size(200, 20);
            this.txtb_Name.TabIndex = 14;
            // 
            // txtb_Type
            // 
            this.txtb_Type.Location = new System.Drawing.Point(384, 64);
            this.txtb_Type.Name = "txtb_Type";
            this.txtb_Type.ReadOnly = true;
            this.txtb_Type.Size = new System.Drawing.Size(200, 20);
            this.txtb_Type.TabIndex = 15;
            // 
            // txtb_Specialty
            // 
            this.txtb_Specialty.Location = new System.Drawing.Point(384, 88);
            this.txtb_Specialty.Name = "txtb_Specialty";
            this.txtb_Specialty.ReadOnly = true;
            this.txtb_Specialty.Size = new System.Drawing.Size(200, 20);
            this.txtb_Specialty.TabIndex = 16;
            // 
            // txtb_Weapon
            // 
            this.txtb_Weapon.Location = new System.Drawing.Point(384, 112);
            this.txtb_Weapon.Name = "txtb_Weapon";
            this.txtb_Weapon.ReadOnly = true;
            this.txtb_Weapon.Size = new System.Drawing.Size(200, 20);
            this.txtb_Weapon.TabIndex = 17;
            // 
            // txtb_HP
            // 
            this.txtb_HP.Location = new System.Drawing.Point(96, 152);
            this.txtb_HP.Name = "txtb_HP";
            this.txtb_HP.ReadOnly = true;
            this.txtb_HP.Size = new System.Drawing.Size(200, 20);
            this.txtb_HP.TabIndex = 18;
            // 
            // txtb_Mana
            // 
            this.txtb_Mana.Location = new System.Drawing.Point(96, 176);
            this.txtb_Mana.Name = "txtb_Mana";
            this.txtb_Mana.ReadOnly = true;
            this.txtb_Mana.Size = new System.Drawing.Size(200, 20);
            this.txtb_Mana.TabIndex = 19;
            // 
            // txtb_Stamina
            // 
            this.txtb_Stamina.Location = new System.Drawing.Point(96, 200);
            this.txtb_Stamina.Name = "txtb_Stamina";
            this.txtb_Stamina.ReadOnly = true;
            this.txtb_Stamina.Size = new System.Drawing.Size(200, 20);
            this.txtb_Stamina.TabIndex = 20;
            // 
            // txtb_GP
            // 
            this.txtb_GP.Location = new System.Drawing.Point(96, 224);
            this.txtb_GP.Name = "txtb_GP";
            this.txtb_GP.ReadOnly = true;
            this.txtb_GP.Size = new System.Drawing.Size(200, 20);
            this.txtb_GP.TabIndex = 21;
            // 
            // txtb_Level
            // 
            this.txtb_Level.Location = new System.Drawing.Point(96, 248);
            this.txtb_Level.Name = "txtb_Level";
            this.txtb_Level.ReadOnly = true;
            this.txtb_Level.Size = new System.Drawing.Size(200, 20);
            this.txtb_Level.TabIndex = 22;
            // 
            // txtb_EXPDrop
            // 
            this.txtb_EXPDrop.Location = new System.Drawing.Point(96, 272);
            this.txtb_EXPDrop.Name = "txtb_EXPDrop";
            this.txtb_EXPDrop.ReadOnly = true;
            this.txtb_EXPDrop.Size = new System.Drawing.Size(200, 20);
            this.txtb_EXPDrop.TabIndex = 23;
            // 
            // txtb_GPDrop
            // 
            this.txtb_GPDrop.Location = new System.Drawing.Point(96, 296);
            this.txtb_GPDrop.Name = "txtb_GPDrop";
            this.txtb_GPDrop.ReadOnly = true;
            this.txtb_GPDrop.Size = new System.Drawing.Size(200, 20);
            this.txtb_GPDrop.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(304, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Armour:";
            // 
            // txtb_Armour
            // 
            this.txtb_Armour.Location = new System.Drawing.Point(384, 136);
            this.txtb_Armour.Name = "txtb_Armour";
            this.txtb_Armour.ReadOnly = true;
            this.txtb_Armour.Size = new System.Drawing.Size(200, 20);
            this.txtb_Armour.TabIndex = 26;
            // 
            // NPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.txtb_Armour);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtb_GPDrop);
            this.Controls.Add(this.txtb_EXPDrop);
            this.Controls.Add(this.txtb_Level);
            this.Controls.Add(this.txtb_GP);
            this.Controls.Add(this.txtb_Stamina);
            this.Controls.Add(this.txtb_Mana);
            this.Controls.Add(this.txtb_HP);
            this.Controls.Add(this.txtb_Weapon);
            this.Controls.Add(this.txtb_Specialty);
            this.Controls.Add(this.txtb_Type);
            this.Controls.Add(this.txtb_Name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Gen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstb_NPCs);
            this.Name = "NPCForm";
            this.Text = "NPCForm";
            this.Load += new System.EventHandler(this.NPCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_NPCs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Gen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.TextBox txtb_Type;
        private System.Windows.Forms.TextBox txtb_Specialty;
        private System.Windows.Forms.TextBox txtb_Weapon;
        private System.Windows.Forms.TextBox txtb_HP;
        private System.Windows.Forms.TextBox txtb_Mana;
        private System.Windows.Forms.TextBox txtb_Stamina;
        private System.Windows.Forms.TextBox txtb_GP;
        private System.Windows.Forms.TextBox txtb_Level;
        private System.Windows.Forms.TextBox txtb_EXPDrop;
        private System.Windows.Forms.TextBox txtb_GPDrop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtb_Armour;
    }
}