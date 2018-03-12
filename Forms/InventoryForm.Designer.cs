namespace TestingGrounds.Forms
{
    partial class InventoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstb_Inventory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_GP = new System.Windows.Forms.TextBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.btn_Add5GP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // lstb_Inventory
            // 
            this.lstb_Inventory.FormattingEnabled = true;
            this.lstb_Inventory.Location = new System.Drawing.Point(8, 40);
            this.lstb_Inventory.Name = "lstb_Inventory";
            this.lstb_Inventory.Size = new System.Drawing.Size(248, 173);
            this.lstb_Inventory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "GP:";
            // 
            // txtb_GP
            // 
            this.txtb_GP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_GP.Location = new System.Drawing.Point(304, 40);
            this.txtb_GP.Name = "txtb_GP";
            this.txtb_GP.ReadOnly = true;
            this.txtb_GP.Size = new System.Drawing.Size(100, 26);
            this.txtb_GP.TabIndex = 3;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.Location = new System.Drawing.Point(384, 336);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(104, 32);
            this.btn_Generate.TabIndex = 4;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // btn_Add5GP
            // 
            this.btn_Add5GP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add5GP.Location = new System.Drawing.Point(272, 336);
            this.btn_Add5GP.Name = "btn_Add5GP";
            this.btn_Add5GP.Size = new System.Drawing.Size(104, 32);
            this.btn_Add5GP.TabIndex = 5;
            this.btn_Add5GP.Text = "Add 5 GP";
            this.btn_Add5GP.UseVisualStyleBackColor = true;
            this.btn_Add5GP.Click += new System.EventHandler(this.btn_Add5GP_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 373);
            this.Controls.Add(this.btn_Add5GP);
            this.Controls.Add(this.btn_Generate);
            this.Controls.Add(this.txtb_GP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstb_Inventory);
            this.Controls.Add(this.label1);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstb_Inventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_GP;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_Add5GP;
    }
}