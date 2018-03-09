using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {
    
        public Weapon(WeaponKind Kind)
        {
            switch(Kind)
            {
                case WeaponKind.IronSword:
                    Damage = 10;
                    Name = "sword";
                    break;
                
                case WeaponKind.Staff:
                    Damage = 120;
                    Name = "Staff";
                    break;
            }
        
        }
        
        public enum WeaponKind
        {
            IronSword,
            Staff,
            Spear,
            Mace,
            Bow
        
        }
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
