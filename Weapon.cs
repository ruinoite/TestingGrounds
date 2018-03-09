using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {

        public Weapon(string ThisName, int ThisValue, int ThisDamage, int ThisWeight, Type ThisType) // this allows you to create a weapon anywhere with any settings u want
        {
            Name = ThisName;
            Weight = ThisWeight;
            Damage = ThisDamage;
            DmgType = ThisType;
            Value = ThisValue;            
        }

        public Weapon(PredefinedWeapons Thisweapon)
        {
            switch(Thisweapon)
            {
                case PredefinedWeapons.IronSword:
                    Name = "Iron Sword";
                    Weight = 10;
                    Damage = 10;
                    DmgType = Type.Meele;
                    Value = 20;
                    break;
                case PredefinedWeapons.WoodenBow:
                    Name = "WoodenBow";
                    Weight = 25;
                    Value = 50;
                    DmgType = Type.Ranged;
                    break;
            }
        }

        public enum Type { Ranged, Meele, Magic };

        public int Damage { get; set; }
        public Type DmgType { get; set; }
        public int PDmgMul { get; set; }
        public int MDmgMul { get; set; }
        public int MDrnMul { get; set; }

      public enum PredefinedWeapons
        {
            IronSword,
            WoodenBow
        }
    }
}
