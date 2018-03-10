using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class NPC : Creature
    {

        // this allows you to create a NPC anywhere with any settings u want
        public NPC(string IName, int IHP, int IMana, int ILevel, Type IType, Specialty ISpecialty,
            int IEXPDrop, int IGPDrop, Item IEquipedArmour, Item IEquipedWeapon)
        {
            //Take in arguments and create a NPC based on them
            Name = IName;
            HP = IHP;
            Mana = IMana;
            Level = ILevel;
            NPCType = IType;
            NPCSpecialty = ISpecialty;
            EXPDrop = IEXPDrop;
            GPDrop = IGPDrop;
            EquipedArmour = IEquipedArmour;
            EquipedWeapon = IEquipedWeapon;
        }


        public NPC(PredefinedNPCs INPC)
        {
            switch (INPC)
            {
                //Declaration of predefined NPCs
                case PredefinedNPCs.Goblin:
                    Name = "Goblin(Predefined)";
                    HP = 20;
                    Mana = 10;
                    Level = 1;
                    NPCType = Type.Ground;
                    NPCSpecialty = Specialty.Meele;
                    EXPDrop = 10;
                    GPDrop = 5;
                    EquipedArmour = null;
                    EquipedWeapon = null;
                    break;
                case PredefinedNPCs.MBird:
                    Name = "Magic Birb(Predefined)";
                    HP = 30;
                    Mana = 50;
                    Level = 3;
                    NPCType = Type.Flying;
                    NPCSpecialty = Specialty.Magic;
                    EXPDrop = 50;
                    GPDrop = 20;
                    EquipedArmour = null;
                    EquipedWeapon = null;
                    break;
            }
        }


        public enum Type { Flying, Ground, Water };
        public enum Specialty { Meele, Ranged, Magic};

        public Type NPCType { get; set; }
        public Specialty NPCSpecialty { get; set; }
        public int EXPDrop { get; set; }
        public int GPDrop { get; set; }

        public enum PredefinedNPCs
        {
            //Declaration of possible predefined NPCs
            Goblin,
            MBird
        }

    }
}
