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
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_damage = new System.Windows.Forms.TextBox();
            this.txtb_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_pdmgmul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtb_mdmgmult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtb_mdrnmul = new System.Windows.Forms.TextBox();
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
            this.btn_do.Location = new System.Drawing.Point(508, 324);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 32);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Do";
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
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(80, 104);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.ReadOnly = true;
            this.txtb_name.Size = new System.Drawing.Size(200, 20);
            this.txtb_name.TabIndex = 6;
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
            // txtb_weight
            // 
            this.txtb_weight.Location = new System.Drawing.Point(80, 168);
            this.txtb_weight.Name = "txtb_weight";
            this.txtb_weight.ReadOnly = true;
            this.txtb_weight.Size = new System.Drawing.Size(200, 20);
            this.txtb_weight.TabIndex = 8;
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
            // txtb_value
            // 
            this.txtb_value.Location = new System.Drawing.Point(80, 136);
            this.txtb_value.Name = "txtb_value";
            this.txtb_value.ReadOnly = true;
            this.txtb_value.Size = new System.Drawing.Size(200, 20);
            this.txtb_value.TabIndex = 10;
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
            // txtb_damage
            // 
            this.txtb_damage.Location = new System.Drawing.Point(80, 232);
            this.txtb_damage.Name = "txtb_damage";
            this.txtb_damage.ReadOnly = true;
            this.txtb_damage.Size = new System.Drawing.Size(200, 20);
            this.txtb_damage.TabIndex = 12;
            // 
            // txtb_type
            // 
            this.txtb_type.Location = new System.Drawing.Point(80, 200);
            this.txtb_type.Name = "txtb_type";
            this.txtb_type.ReadOnly = true;
            this.txtb_type.Size = new System.Drawing.Size(200, 20);
            this.txtb_type.TabIndex = 14;
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
            // txtb_pdmgmul
            // 
            this.txtb_pdmgmul.Location = new System.Drawing.Point(144, 264);
            this.txtb_pdmgmul.Name = "txtb_pdmgmul";
            this.txtb_pdmgmul.ReadOnly = true;
            this.txtb_pdmgmul.Size = new System.Drawing.Size(136, 20);
            this.txtb_pdmgmul.TabIndex = 16;
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
            // txtb_mdmgmult
            // 
            this.txtb_mdmgmult.Location = new System.Drawing.Point(144, 296);
            this.txtb_mdmgmult.Name = "txtb_mdmgmult";
            this.txtb_mdmgmult.ReadOnly = true;
            this.txtb_mdmgmult.Size = new System.Drawing.Size(136, 20);
            this.txtb_mdmgmult.TabIndex = 18;
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
            // txtb_mdrnmul
            // 
            this.txtb_mdrnmul.Location = new System.Drawing.Point(144, 328);
            this.txtb_mdrnmul.Name = "txtb_mdrnmul";
            this.txtb_mdrnmul.ReadOnly = true;
            this.txtb_mdrnmul.Size = new System.Drawing.Size(136, 20);
            this.txtb_mdrnmul.TabIndex = 20;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 362);
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
            this.Controls.Add(this.txtb_mdrnmul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtb_mdmgmult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtb_pdmgmul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_damage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_name);
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
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_damage;
        private System.Windows.Forms.TextBox txtb_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_pdmgmul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtb_mdmgmult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtb_mdrnmul;
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
    }
}

