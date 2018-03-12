using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    public class Creature
    {

        public Creature()
        {
            //No need for anything in here as Creature is just a base and there
            //will probably never be an object which is only a "Creature"
        }

        //Declare the vars, while making them properties
        public int HP { get; protected set; } // Only Inside this class we can edit this value(and deprived classes)
        public int Mana { get; protected set; } // Only Inside this class we can edit this value
        public int Level { get; protected set; } // Only Inside this class we can edit this value
        public string Name { get; protected set; } // Only Inside this class we can edit this value
        public Armour EquipedArmour { get; protected set; } // Only Inside this class we can edit this value
        public Weapon EquipedWeapon { get; protected set; } // Only Inside this class we can edit this value

    }
}
