using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {
        public enum Type { Ranged, Meele, Magic };
        //int Damage;
        //int PDmgMul;
        //int MDmgMul;
        //int MDrnMul;

        //Declare the vars, while making them properties
        public int Damage { get; set; }
        public Type DmgType { get; set; }
        public int PDmgMul { get; set; }
        public int MDmgMul { get; set; }
        public int MDrnMul { get; set; }

        public Weapon ()
        {
            Weapon sword1 = new Weapon();
            sword1.Name = "Sword 1";
            sword1.Value = 20;
            sword1.Weight = 10;
            Weapon sword2 = new Weapon();
            sword2.Name = "Sword 2";
            sword2.Value = 50;
            sword2.Weight = 25;
        }
    }
}
