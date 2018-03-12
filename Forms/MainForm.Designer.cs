namespace TestingGrounds
{
    partial class MainForm
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
            this.lstb_1 = new System.Windows.Forms.ListBox();
            this.btn_do = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_Value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Damage = new System.Windows.Forms.TextBox();
            this.txtb_Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_PDmgMul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_MDmgMul = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb_MDrnMul = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtb_MBoost = new System.Windows.Forms.TextBox();
            this.txtb_HPBoost = new System.Windows.Forms.TextBox();
            this.txtb_Def = new System.Windows.Forms.TextBox();
            this.txtb_MDefMul = new System.Windows.Forms.TextBox();
            this.txtb_PDefMul = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtb_HPGain = new System.Windows.Forms.TextBox();
            this.txtb_StamGain = new System.Windows.Forms.TextBox();
            this.txtb_ManaGain = new System.Windows.Forms.TextBox();
            this.btn_NPCsForm = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstb_1
            // 
            this.lstb_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstb_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstb_1.FormattingEnabled = true;
            this.lstb_1.Location = new System.Drawing.Point(8, 8);
            this.lstb_1.Name = "lstb_1";
            this.lstb_1.Size = new System.Drawing.Size(576, 78);
            this.lstb_1.TabIndex = 0;
            this.lstb_1.SelectedIndexChanged += new System.EventHandler(this.lstb_1_SelectedIndexChanged);
            // 
            // btn_do
            // 
            this.btn_do.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_do.Location = new System.Drawing.Point(488, 376);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(95, 32);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Generate";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(80, 104);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.ReadOnly = true;
            this.txtb_Name.Size = new System.Drawing.Size(200, 20);
            this.txtb_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight:";
            // 
            // txtb_Weight
            // 
            this.txtb_Weight.Location = new System.Drawing.Point(80, 168);
            this.txtb_Weight.Name = "txtb_Weight";
            this.txtb_Weight.ReadOnly = true;
            this.txtb_Weight.Size = new System.Drawing.Size(200, 20);
            this.txtb_Weight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Value:";
            // 
            // txtb_Value
            // 
            this.txtb_Value.Location = new System.Drawing.Point(80, 136);
            this.txtb_Value.Name = "txtb_Value";
            this.txtb_Value.ReadOnly = true;
            this.txtb_Value.Size = new System.Drawing.Size(200, 20);
            this.txtb_Value.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Damage:";
            // 
            // txtb_Damage
            // 
            this.txtb_Damage.Location = new System.Drawing.Point(80, 232);
            this.txtb_Damage.Name = "txtb_Damage";
            this.txtb_Damage.ReadOnly = true;
            this.txtb_Damage.Size = new System.Drawing.Size(200, 20);
            this.txtb_Damage.TabIndex = 12;
            // 
            // txtb_Type
            // 
            this.txtb_Type.Location = new System.Drawing.Point(80, 200);
            this.txtb_Type.Name = "txtb_Type";
            this.txtb_Type.ReadOnly = true;
            this.txtb_Type.Size = new System.Drawing.Size(200, 20);
            this.txtb_Type.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Physical Dmg Mul:";
            // 
            // txtb_PDmgMul
            // 
            this.txtb_PDmgMul.Location = new System.Drawing.Point(144, 264);
            this.txtb_PDmgMul.Name = "txtb_PDmgMul";
            this.txtb_PDmgMul.ReadOnly = true;
            this.txtb_PDmgMul.Size = new System.Drawing.Size(136, 20);
            this.txtb_PDmgMul.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Magic Dmg Mul:";
            // 
            // txtb_MDmgMul
            // 
            this.txtb_MDmgMul.Location = new System.Drawing.Point(144, 296);
            this.txtb_MDmgMul.Name = "txtb_MDmgMul";
            this.txtb_MDmgMul.ReadOnly = true;
            this.txtb_MDmgMul.Size = new System.Drawing.Size(136, 20);
            this.txtb_MDmgMul.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mana Drain Mul:";
            // 
            // txtb_MDrnMul
            // 
            this.txtb_MDrnMul.Location = new System.Drawing.Point(144, 328);
            this.txtb_MDrnMul.Name = "txtb_MDrnMul";
            this.txtb_MDrnMul.ReadOnly = true;
            this.txtb_MDrnMul.Size = new System.Drawing.Size(136, 20);
            this.txtb_MDrnMul.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Defense:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Phys Defense Mul:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Magic Defense Mul:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(296, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "HP Boost:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Mana Boost:";
            // 
            // txtb_MBoost
            // 
            this.txtb_MBoost.Location = new System.Drawing.Point(400, 168);
            this.txtb_MBoost.Name = "txtb_MBoost";
            this.txtb_MBoost.ReadOnly = true;
            this.txtb_MBoost.Size = new System.Drawing.Size(184, 20);
            this.txtb_MBoost.TabIndex = 26;
            // 
            // txtb_HPBoost
            // 
            this.txtb_HPBoost.Location = new System.Drawing.Point(400, 136);
            this.txtb_HPBoost.Name = "txtb_HPBoost";
            this.txtb_HPBoost.ReadOnly = true;
            this.txtb_HPBoost.Size = new System.Drawing.Size(184, 20);
            this.txtb_HPBoost.TabIndex = 27;
            // 
            // txtb_Def
            // 
            this.txtb_Def.Location = new System.Drawing.Point(400, 104);
            this.txtb_Def.Name = "txtb_Def";
            this.txtb_Def.ReadOnly = true;
            this.txtb_Def.Size = new System.Drawing.Size(184, 20);
            this.txtb_Def.TabIndex = 28;
            // 
            // txtb_MDefMul
            // 
            this.txtb_MDefMul.Location = new System.Drawing.Point(448, 232);
            this.txtb_MDefMul.Name = "txtb_MDefMul";
            this.txtb_MDefMul.ReadOnly = true;
            this.txtb_MDefMul.Size = new System.Drawing.Size(136, 20);
            this.txtb_MDefMul.TabIndex = 29;
            // 
            // txtb_PDefMul
            // 
            this.txtb_PDefMul.Location = new System.Drawing.Point(448, 200);
            this.txtb_PDefMul.Name = "txtb_PDefMul";
            this.txtb_PDefMul.ReadOnly = true;
            this.txtb_PDefMul.Size = new System.Drawing.Size(136, 20);
            this.txtb_PDefMul.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "HP Gain:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Stamina Gain:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(296, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Mana Gain:";
            // 
            // txtb_HPGain
            // 
            this.txtb_HPGain.Location = new System.Drawing.Point(408, 264);
            this.txtb_HPGain.Name = "txtb_HPGain";
            this.txtb_HPGain.ReadOnly = true;
            this.txtb_HPGain.Size = new System.Drawing.Size(176, 20);
            this.txtb_HPGain.TabIndex = 34;
            // 
            // txtb_StamGain
            // 
            this.txtb_StamGain.Location = new System.Drawing.Point(408, 296);
            this.txtb_StamGain.Name = "txtb_StamGain";
            this.txtb_StamGain.ReadOnly = true;
            this.txtb_StamGain.Size = new System.Drawing.Size(176, 20);
            this.txtb_StamGain.TabIndex = 35;
            // 
            // txtb_ManaGain
            // 
            this.txtb_ManaGain.Location = new System.Drawing.Point(408, 328);
            this.txtb_ManaGain.Name = "txtb_ManaGain";
            this.txtb_ManaGain.ReadOnly = true;
            this.txtb_ManaGain.Size = new System.Drawing.Size(176, 20);
            this.txtb_ManaGain.TabIndex = 36;
            // 
            // btn_NPCsForm
            // 
            this.btn_NPCsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NPCsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NPCsForm.Location = new System.Drawing.Point(8, 376);
            this.btn_NPCsForm.Name = "btn_NPCsForm";
            this.btn_NPCsForm.Size = new System.Drawing.Size(96, 32);
            this.btn_NPCsForm.TabIndex = 37;
            this.btn_NPCsForm.Text = "NPCs";
            this.btn_NPCsForm.UseVisualStyleBackColor = true;
            this.btn_NPCsForm.Click += new System.EventHandler(this.btn_NPCsForm_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.Location = new System.Drawing.Point(112, 376);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(96, 32);
            this.btn_Inventory.TabIndex = 38;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 417);
            this.Controls.Add(this.btn_Inventory);
            this.Controls.Add(this.btn_NPCsForm);
            this.Controls.Add(this.txtb_ManaGain);
            this.Controls.Add(this.txtb_StamGain);
            this.Controls.Add(this.txtb_HPGain);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtb_PDefMul);
            this.Controls.Add(this.txtb_MDefMul);
            this.Controls.Add(this.txtb_Def);
            this.Controls.Add(this.txtb_HPBoost);
            this.Controls.Add(this.txtb_MBoost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtb_MDrnMul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_MDmgMul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_PDmgMul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_Damage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_Value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.lstb_1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstb_1;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_Value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_Damage;
        private System.Windows.Forms.TextBox txtb_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_PDmgMul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_MDmgMul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb_MDrnMul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtb_MBoost;
        private System.Windows.Forms.TextBox txtb_HPBoost;
        private System.Windows.Forms.TextBox txtb_Def;
        private System.Windows.Forms.TextBox txtb_MDefMul;
        private System.Windows.Forms.TextBox txtb_PDefMul;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtb_HPGain;
        private System.Windows.Forms.TextBox txtb_StamGain;
        private System.Windows.Forms.TextBox txtb_ManaGain;
        private System.Windows.Forms.Button btn_NPCsForm;
        private System.Windows.Forms.Button btn_Inventory;
    }
}

