using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {
        //int Damage;
        //enum Type { Ranged, Meele, Magic };
        //int PDmgMul;
        //int MDmgMul;
        //int MDrnMul;

        //Declare the vars, while making them properties
        public int Damage { get; set; }
        public enum Type { Ranged, Meele, Magic } { get; set; }
        public int PDmgMul { get; set; }
        public int MDmgMul { get; set; }
        public int MDrnMul { get; set; }
    }
}
