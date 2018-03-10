using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Player : Creature
    {

        public Player()
        {

                //Declaration of Player
                    Name = "Player";
                    HP = 100;
                    Mana = 80;
                    GP = 50;
                    Level = 1;
                    Stamina = 60;
                    EquipedArmour = Armour.PredefinedArmours.IronArmour.ToString(); //needs fixing
                    EquipedWeapon = null;

        }

        public int Stamina { get; set; }
        public int GP { get; set; }

    }
}
