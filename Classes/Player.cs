using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TestingGrounds
{
    public class Player : Creature
    {

        //private static BindingList<Item> PlayerInventory;

        public Player()
        {

            PlayerInventory = new BindingList<Item>();

                    //Declaration of Player
                    Name = "Player";
                    HP = 100;
                    Mana = 80;
                    GP = 50;
                    Level = 1;
                    Stamina = 60;
                    EquipedArmour = null;
                    EquipedWeapon = null;

        }

        public int Stamina { get; set; }
        public int GP { get; set; }
        public BindingList<Item> PlayerInventory { get; private set; }

    }
}
