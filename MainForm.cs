using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGrounds
{
    public partial class MainForm : Form
    {

        private BindingList<Item> ItemsList; // chanced from string to item
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemsList = new BindingList<Item>(); // chanced from string to item

            //ItemsList.Add("sword");
            //ItemsList.Add("bow");
            //ItemsList.Add("metal armour");
            //ItemsList.Add("banana");
            //ItemsList.Add("croissant");
            //ItemsList.Add("gold ring");

        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            //Weapon sword1 = new Weapon();
            //sword1.Name = "Sword 1";
            //sword1.Value = 20;
            //sword1.Weight = 10;
            //Weapon sword2 = new Weapon();
            //sword2.Name = "Sword 2";
            //sword2.Value = 50;
            //sword2.Weight = 25;
            ItemsList.Add(Weapon.Weapon.sword1);          // insert object instead of string
            ItemsList.Add(sword2);          // insert object instead of string
            lstb_1.DataSource = ItemsList;
            lstb_1.DisplayMember = "Name"; // This is important. we already said take the list of items to display
                                           // with this line we say, only display the Name property of the item, dont display something ugly 

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //ItemsList.Add(txtb_1.Text);
            //lstb_1.DataSource = ItemsList;
            //txtb_1.Clear();
        }

        private void lstb_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Item SelectedObject = (Item)lstb_1.SelectedItem;
            // we CAST the selected object to a Item object.
            // we can do this because the Weapon types are deprived from the Item type
            // this is not super save. if a object taht isnt deprived of Item is selected it goes boom(there are easy ways to check)

            txtb_name.Text = SelectedObject.Name;
            txtb_value.Text = SelectedObject.Value.ToString();
            txtb_weight.Text = SelectedObject.Weight.ToString();

        }
    }
}
