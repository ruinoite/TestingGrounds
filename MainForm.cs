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

        private BindingList<string> ItemsList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ItemsList = new BindingList<string>();

            //ItemsList.Add("sword");
            //ItemsList.Add("bow");
            //ItemsList.Add("metal armour");
            //ItemsList.Add("banana");
            //ItemsList.Add("croissant");
            //ItemsList.Add("gold ring");

        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            Weapon sword1 = new Weapon();
            sword1.Name = "Sword 1";
            Weapon sword2 = new Weapon();
            sword2.Name = "Sword 2";
            ItemsList.Add(sword1.Name);
            ItemsList.Add(sword2.Name);
            lstb_1.DataSource = ItemsList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ItemsList.Add(txtb_1.Text);
            lstb_1.DataSource = ItemsList;
            txtb_1.Clear();
        }

        private void lstb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedObject = lstb_1.SelectedItem;
            string propertyCalled = "Name";
            var propertyName = selectedObject.GetType().GetProperty(propertyCalled).GetValue(selectedObject, null);

            //string selected = lstb_1.SelectedItem.ToString();
            txtb_name.Text = propertyName.ToString();
            //txtb_value.Text = selected.Value;
            //txtb_weight.Text = selected.Weight;
        }
    }
}
