using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    public class Armour : Item
    {

        public Armour(string IName, int IValue, int IWeight, int IDefense, int IPDefMul, int IMDefMul, int IHPBoost, int IMBoost) // this allows you to create an armour anywhere with any settings u want
        {
            //Take in arguments and create a new armour based on them
            Name = IName;
            Weight = IWeight;
            Value = IValue;
            Defense = IDefense;
            PDefMul = IPDefMul;
            MDefMul = IMDefMul;
            HPBoost = IHPBoost;
            MBoost = IMBoost;

        }

        public Armour(PredefinedArmours ThisArmour)
        {
            switch (ThisArmour)
            {
                //Declaration of a predefined armour
                case PredefinedArmours.GenericIronArmour:
                    Name = "Iron Armour";
                    Weight = 10;
                    Value = 20;
                    Defense = 10;
                    PDefMul = 10;
                    MDefMul = 1;
                    HPBoost = 50;
                    MBoost = 0;
                    break;
            }
        }

        //Declaration of possible predefined armours
        public enum PredefinedArmours
        {
            GenericIronArmour
        }
        /// <summary>
        /// Value of Armour Defense
        /// </summary>
        public int Defense { get; set; }
        public int PDefMul { get; set; }
        public int MDefMul { get; set; }
        public int HPBoost { get; set; }
        public int MBoost { get; set; }
    }
}
