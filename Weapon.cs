using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {

        // this allows you to create a weapon anywhere with any settings u want
        public Weapon(string ThisName, int ThisValue, int ThisDamage, int ThisWeight,
            Type ThisType, int PDM, int MDM, int MDrM)
        {
            //Take in arguments and create a weapon based on them
            Name = ThisName;
            Weight = ThisWeight;
            Damage = ThisDamage;
            DmgType = ThisType;
            Value = ThisValue;
            PDmgMul = PDM;
            MDmgMul = MDM;
            MDrnMul = MDrM;
        }

        public Weapon(PredefinedWeapons Thisweapon)
        {
            switch(Thisweapon)
            {
                //Declaration of predefined weapons
                case PredefinedWeapons.IronSword:
                    Name = "Iron Sword";
                    Weight = 10;
                    Damage = 10;
                    DmgType = Type.Meele;
                    Value = 20;
                    PDmgMul = 2;
                    MDmgMul = 0;
                    MDrnMul = 0;
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
            //Declaration of possible predefined weapons
            IronSword,
            WoodenBow
        }

    }
}
