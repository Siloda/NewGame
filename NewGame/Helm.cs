using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{
    class Helm:Item
    {
        public Helm(string name, string race = "Human", int expPoint = 0, int lvlPoints = 0, int hpPoints = 0, int strike = 0, int armor = 0, int strength = 0, int intelligence = 0, int agility = 0) {
            Name = name;
            Race = race;
            ExpPoint = expPoint;
            LvlPoints = lvlPoints;
            HpPoints = hpPoints;
            Strike = strength + (agility / intelligence);
            Hp = hpPoints * 5;
            Armor = armor;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
        }
       
    }
}
