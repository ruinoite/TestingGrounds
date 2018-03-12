using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGrounds.Forms
{
    public partial class InventoryForm : Form
    {
        private Player ply;

        public InventoryForm(Player Iply)
        {
            InitializeComponent();
            ply = Iply;
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            lstb_Inventory.DataSource = ply.PlayerInventory;
            lstb_Inventory.DisplayMember = "Name";
            txtb_GP.Text = ply.GP.ToString();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            ply.PlayerInventory.Add(new Weapon (Weapon.PredefinedWeapons.GenericIronSword));
        }

        private void btn_Add5GP_Click(object sender, EventArgs e)
        {
            ply.GP += 5;
            txtb_GP.Text = ply.GP.ToString();
        }
    }
}
