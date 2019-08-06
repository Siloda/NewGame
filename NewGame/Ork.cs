using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{
    class Ork : Person
    {

       

        public Ork(string name= "Kolia",string race ="Ork", int expPoint = 0, int lvlPoints = 3, int lvl = 0, int hpPoints = 7, int strike = 10, int armor = 0, int strength = 4, int intelligence = 2, int agility = 2)
        {
            Name = name;
            Race = race;
            ExpPoint = expPoint;
            LvlPoints = lvlPoints;
            Lvl = lvl;            
            HpPoints = hpPoints;
            Strike = strength + (intelligence/agility);
            Hp = hpPoints * 5;
            Armor = armor;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;



        }
        public override string getInfo() { return "Name: " + Name + ": Race: " + Race +"; Level: "+Lvl+ "; Hp: " + Hp + "; Strike: " + Strike + "; Armor: " + Armor + ";  Strenght: " + Strength + "; Intelligence: " + Intelligence + "; Agirlity: " + Agility + "; Free points: " + LvlPoints; }

    }
}