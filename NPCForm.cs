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
    public partial class NPCForm : Form
    {

        // Declare a binding list of type Creature, so it can hold creatures and not just text
        private BindingList<Creature> CreaturesList;

        public NPCForm()
        {
            InitializeComponent();
        }

        private void NPCForm_Load(object sender, EventArgs e)
        {
            // Initialise the binding list of type Creature
            CreaturesList = new BindingList<Creature>();
        }

        private void btn_Gen_Click(object sender, EventArgs e)
        {

            //Create the Player
            Player Player = new Player();

            //Create some predefined NPCs
            NPC MBird = new NPC(NPC.PredefinedNPCs.MBird);
            NPC Goblin = new NPC(NPC.PredefinedNPCs.Goblin);

            //Create a custom NPC using parameters(Name,HP,Mana,LVL,Type,Specialty
            //EXPDrop,GPDrop,EquipedArmour,EquipedWeap)
            NPC CustomHuman = new NPC("John Johnson", 100, 20,5,NPC.Type.Ground,NPC.Specialty.Meele,
                20,30,null,null);

            //Insert the previously generated Creatures to the CreaturesList
            CreaturesList.Add(Player);
            CreaturesList.Add(MBird);
            CreaturesList.Add(Goblin);
            CreaturesList.Add(CustomHuman);

            //Update the listbox with Creatures existing in CreaturesList
            lstb_NPCs.DataSource = CreaturesList;
            //Tell the listbox to show the Name var of each Creature
            lstb_NPCs.DisplayMember = "Name";

        }

        private void lstb_NPCs_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Check if the selected Creature is of Player type
            if (lstb_NPCs.SelectedItem.GetType() == typeof(Player))
            {
                //We CAST the selected object to a Item object.
                //We can do this because the Weapon types are derived from the Item type
                //This is not super safe. If an object that isn't derived of Item is selected
                //it goes allahu akbar(there are easy ways to check)
                Player SelectedObject = (Player)lstb_NPCs.SelectedItem;

                //Fill in the textboxes with info about the selected item
                txtb_Name.Text = SelectedObject.Name;
                txtb_Type.Text = "N/A w/ this creature";
                txtb_Specialty.Text = "N/A w/ this creature";
                txtb_Weapon.Text = SelectedObject.EquipedWeapon.ToString();
                txtb_Armour.Text = SelectedObject.EquipedArmour.ToString();
                txtb_HP.Text = SelectedObject.HP.ToString();
                txtb_Mana.Text = SelectedObject.Mana.ToString();
                txtb_Stamina.Text = SelectedObject.Stamina.ToString();
                txtb_GP.Text = SelectedObject.GP.ToString();
                txtb_Level.Text = SelectedObject.Level.ToString();
                txtb_EXPDrop.Text = "N/A w/ this creature";
                txtb_GPDrop.Text = "N/A w/ this creature";

            }
            else if (lstb_NPCs.SelectedItem.GetType() == typeof(NPC))
            {
                //We CAST the selected object to a Item object.
                //We can do this because the Weapon types are derived from the Item type
                //This is not super safe. If an object that isn't derived of Item is selected
                //it goes allahu akbar(there are easy ways to check)
                NPC SelectedObject = (NPC)lstb_NPCs.SelectedItem;

                //Fill in the textboxes with info about the selected item
                txtb_Name.Text = SelectedObject.Name;
                txtb_Type.Text = SelectedObject.NPCType.ToString();
                txtb_Specialty.Text = SelectedObject.NPCSpecialty.ToString();
                txtb_Weapon.Text = SelectedObject.EquipedWeapon.ToString();
                txtb_Armour.Text = SelectedObject.EquipedArmour.ToString();
                txtb_HP.Text = SelectedObject.HP.ToString();
                txtb_Mana.Text = SelectedObject.Mana.ToString();
                txtb_Stamina.Text = "N/A w/ this creature";
                txtb_GP.Text = "N/A w/ this creature";
                txtb_Level.Text = SelectedObject.Level.ToString();
                txtb_EXPDrop.Text = SelectedObject.EXPDrop.ToString();
                txtb_GPDrop.Text = SelectedObject.GPDrop.ToString();

            }

        }
    }
}
