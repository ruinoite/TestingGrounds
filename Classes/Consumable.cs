using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    public class Consumable : Item
    {
        public Consumable(string IName, int IValue, int IWeight, int IHPGain, int IStamGain, int IManaGain) // this allows you to create a consumable anywhere with any settings u want
        {
            //Take in arguments and create a new consumable based on them
            Name = IName;
            Weight = IWeight;
            Value = IValue;
            HPGain = IHPGain;
            StamGain = IStamGain;
            ManaGain = IManaGain;

        }

        public Consumable(PredefinedConsumables ThisConsumable)
        {
            switch (ThisConsumable)
            {
                //Declaration of a predefined consumable
                case PredefinedConsumables.PredefApple:
                    Name = "Predefined Apple";
                    Weight = 10;
                    Value = 20;
                    HPGain = 25;
                    StamGain = 50;
                    ManaGain = 5;
                    break;
            }
        }

        //Declaration of possible predefined consumables
        public enum PredefinedConsumables
        {
            PredefApple
        }

        public int HPGain { get; set; }
        public int StamGain { get; set; }
        public int ManaGain { get; set; }

    }
}
