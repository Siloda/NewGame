using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{
    class Human : Person, Iitem
    {
  

        public Human(string name= "vasya", string race = "Human",int expPoint =0, int lvlPoints = 3, int hpPoints = 6, int strike =10, int armor = 0, int strength=3, int intelligence=3, int agility=3)
        {
            Name = name;
            Race = race;
            ExpPoint = expPoint;
            LvlPoints = lvlPoints;
            HpPoints = hpPoints;
            Strike = strength + (agility/intelligence);
            Hp = hpPoints*5;
            Armor = armor;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
            


    }
        public override string getInfo() { return "Name: " + Name + ": Race: " + Race + "; Level: " + Lvl + "; Hp: " + Hp + "; Strike: " + Strike + "; Armor: " + Armor + ";  Strenght: " + Strength + "; Intelligence: " + Intelligence + "; Agirlity: " + Agility + "; Free points: " + LvlPoints; }

       

    }
}
