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

        // Declare a binding list of type Item, so it can hold items and not just text
        private BindingList<Item> ItemsList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialise the binding list of type Item
            ItemsList = new BindingList<Item>();

        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            //Add an IronSword predefined weapon (predefined in the Weapon Class)
            Weapon SwordLeIron = new Weapon(Weapon.PredefinedWeapons.IronSword);

            //Add custom weapons using parameters(Name,Value,Damage,Weight,Type,Phys Dmg Mul,Mag Dmg Mul,Mana Drain Mul)
            Weapon Customstuff = new Weapon("magic woop",200,10,20,Weapon.Type.Magic,1,3,0);
            Weapon NightWeapon = new Weapon("Nighty", 300, 20, 30, Weapon.Type.Ranged,3,3,3);

            //Add custom armour using parameters(Name,Value,Weight,Defense,PDefMul,MDefMul,HPBoost,MBoost)
            Armour CustomArmour = new Armour("Custom Armour", 500, 50, 40, 12, 5, 200, 20);

            //Add an IronArmour predefined Armour (predefined in the Armour Class)
            Armour ArmourIron = new Armour(Armour.PredefinedArmours.IronArmour);

            //Add custom consumable using parameters(Name,Value,Weight,HPGain,StamGain,ManaGain)
            Consumable CustomApple = new Consumable("Custom Apple", 2, 1, 40, 12, 5);

            //Add an IronSword predefined weapon (predefined in the Weapon Class)
            Consumable PreApple = new Consumable(Consumable.PredefinedConsumables.PredefApple);

            //Insert the previously generated items to the ItemsList
            ItemsList.Add(SwordLeIron);
            ItemsList.Add(Customstuff);
            ItemsList.Add(NightWeapon);
            ItemsList.Add(CustomArmour);
            ItemsList.Add(ArmourIron);
            ItemsList.Add(CustomApple);
            ItemsList.Add(PreApple);

            //Update the listbox with items existing in ItemsList
            lstb_1.DataSource = ItemsList;
            //Tell the listbox to show the Name var of each item
            lstb_1.DisplayMember = "Name";

        }


        private void lstb_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Check if the selected item is of Weapon type
            if (lstb_1.SelectedItem.GetType() == typeof(Weapon))
            {
                Weapon SelectedObject = (Weapon)lstb_1.SelectedItem;
                //We CAST the selected object to a Item object.
                //We can do this because the Weapon types are derived from the Item type
                //This is not super safe. If an object that isn't derived of Item is selected it goes allahu akbar(there are easy ways to check)


                //Fill in the textboxes with info about the selected item
                txtb_Name.Text = SelectedObject.Name;
                txtb_Value.Text = SelectedObject.Value.ToString();
                txtb_Weight.Text = SelectedObject.Weight.ToString();
                txtb_Type.Text = SelectedObject.DmgType.ToString();
                txtb_Damage.Text = SelectedObject.Damage.ToString();
                txtb_PDmgMul.Text = SelectedObject.PDmgMul.ToString();
                txtb_MDmgMul.Text = SelectedObject.MDmgMul.ToString();
                txtb_MDrnMul.Text = SelectedObject.MDrnMul.ToString();
            
                txtb_Def.Text = "N/A w/ this item";
                txtb_HPBoost.Text = "N/A w/ this item";
                txtb_MBoost.Text = "N/A w/ this item";
                txtb_PDefMul.Text = "N/A w/ this item";
                txtb_MDefMul.Text = "N/A w/ this item";
                txtb_HPGain.Text = "N/A w/ this item";
                txtb_StamGain.Text = "N/A w/ this item";
                txtb_ManaGain.Text = "N/A w/ this item";

                //else, check if the selected item is of Armour type
            }else if (lstb_1.SelectedItem.GetType() == typeof(Armour))
            {
                Armour SelectedObject = (Armour)lstb_1.SelectedItem;

                //Fill in the textboxes with info about the selected item
                txtb_Name.Text = SelectedObject.Name;
                txtb_Value.Text = SelectedObject.Value.ToString();
                txtb_Weight.Text = SelectedObject.Weight.ToString();
                txtb_Def.Text = SelectedObject.Defense.ToString();
                txtb_HPBoost.Text = SelectedObject.HPBoost.ToString();
                txtb_MBoost.Text = SelectedObject.MBoost.ToString();
                txtb_PDefMul.Text = SelectedObject.PDefMul.ToString();
                txtb_MDefMul.Text = SelectedObject.MDefMul.ToString();

                txtb_Type.Text = "N/A w/ this item";
                txtb_Damage.Text = "N/A w/ this item";
                txtb_PDmgMul.Text = "N/A w/ this item";
                txtb_MDmgMul.Text = "N/A w/ this item";
                txtb_MDrnMul.Text = "N/A w/ this item";
                txtb_HPGain.Text = "N/A w/ this item";
                txtb_StamGain.Text = "N/A w/ this item";
                txtb_ManaGain.Text = "N/A w/ this item";

            }
            else if (lstb_1.SelectedItem.GetType() == typeof(Consumable))
            {
                Consumable SelectedObject = (Consumable)lstb_1.SelectedItem;

                //Fill in the textboxes with info about the selected item
                txtb_Name.Text = SelectedObject.Name;
                txtb_Value.Text = SelectedObject.Value.ToString();
                txtb_Weight.Text = SelectedObject.Weight.ToString();
                txtb_HPGain.Text = SelectedObject.HPGain.ToString();
                txtb_StamGain.Text = SelectedObject.StamGain.ToString();
                txtb_ManaGain.Text = SelectedObject.ManaGain.ToString();

                txtb_Def.Text = "N/A w/ this item";
                txtb_HPBoost.Text = "N/A w/ this item";
                txtb_MBoost.Text = "N/A w/ this item";
                txtb_Type.Text = "N/A w/ this item";
                txtb_Damage.Text = "N/A w/ this item";
                txtb_PDmgMul.Text = "N/A w/ this item";
                txtb_MDmgMul.Text = "N/A w/ this item";
                txtb_MDrnMul.Text = "N/A w/ this item";
                txtb_PDefMul.Text = "N/A w/ this item";
                txtb_MDefMul.Text = "N/A w/ this item";

            }

        }

        private void btn_NPCsForm_Click(object sender, EventArgs e)
        {
            NPCForm NPCForm = new NPCForm();

            NPCForm.ShowDialog();
        }
    }
}
