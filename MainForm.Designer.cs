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
            this.txtb_1 = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_value = new System.Windows.Forms.TextBox();
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
            this.lstb_1.Size = new System.Drawing.Size(272, 91);
            this.lstb_1.TabIndex = 0;
            this.lstb_1.SelectedIndexChanged += new System.EventHandler(this.lstb_1_SelectedIndexChanged);
            // 
            // btn_do
            // 
            this.btn_do.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_do.Location = new System.Drawing.Point(208, 232);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 32);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Do";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // txtb_1
            // 
            this.txtb_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_1.Location = new System.Drawing.Point(0, 232);
            this.txtb_1.Name = "txtb_1";
            this.txtb_1.Size = new System.Drawing.Size(120, 32);
            this.txtb_1.TabIndex = 2;
            // 
            // lbl_1
            // 
            this.lbl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(0, 208);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(98, 17);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Add New Item:";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(128, 232);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.txtb_name.Location = new System.Drawing.Point(72, 104);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.ReadOnly = true;
            this.txtb_name.Size = new System.Drawing.Size(208, 20);
            this.txtb_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight:";
            // 
            // txtb_weight
            // 
            this.txtb_weight.Location = new System.Drawing.Point(72, 136);
            this.txtb_weight.Name = "txtb_weight";
            this.txtb_weight.ReadOnly = true;
            this.txtb_weight.Size = new System.Drawing.Size(208, 20);
            this.txtb_weight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Value:";
            // 
            // txtb_value
            // 
            this.txtb_value.Location = new System.Drawing.Point(72, 168);
            this.txtb_value.Name = "txtb_value";
            this.txtb_value.ReadOnly = true;
            this.txtb_value.Size = new System.Drawing.Size(208, 20);
            this.txtb_value.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtb_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.txtb_1);
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
        private System.Windows.Forms.TextBox txtb_1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_value;
    }
}

