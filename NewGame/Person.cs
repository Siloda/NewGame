using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{

    public class Person : Iitem
    {
        static Engine En = Engine.Letsgo;
        public string Name { get; set; }
        public string Race { get; set; }
        public int Lvl { get; set; }
        public int ExpPoint { get; set; }
        public int LvlPoints { get; set; }
        public int HpPoints { get; set; }
        public int Hp { get; set; }
        public int Strike { get; set; }
        public int Armor { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int CountHp { get; set; }


        public virtual string getInfo() { return " Hp: " + Hp + "; Strike: " + Strike + "; Armor: " + Armor + ";  Strenght: " + Strength + "; Intelligence: " + Intelligence + "; Agirlity: " + Agility; }

        public void dropItem()
        {
            throw new NotImplementedException();
        }

        public void temInfo()
        {
            throw new NotImplementedException();
        }

        public void putItem()
        {
            throw new NotImplementedException();
        }


        public void takeItem(int heroIndex, int itemIndex)
        {
          

            En.heroesList[heroIndex].Strength += En.itemsList[itemIndex].Strength;
            En.heroesList[heroIndex].Agility += En.itemsList[itemIndex].Agility;
            En.heroesList[heroIndex].Intelligence += En.itemsList[itemIndex].Intelligence;
            En.heroesList[heroIndex].Strike += En.itemsList[itemIndex].Strike;

            return;
        }
    } 
}
