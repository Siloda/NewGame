using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{
    class Engine
    {
        protected static Engine En;


        public Engine()
        {

        }

        public static Engine Letsgo
        {
            get
            {
                if (En == null)
                {
                    En = new Engine();
                }
                return En;
            }
        }
       
        public List<Person> heroesList = new List<Person>();

        public List<Item> itemsList = new List<Item>();
        
        
        public void getPersonList()
        {
            
            foreach (Person p in heroesList)
            {
                Console.WriteLine("[" + p.Name + "]" + "[" + p.Hp + "]" + "[" + p.Race + "]");
            }
        }
        public void getItemList() 
        {

            foreach (Item p in itemsList)
            {
                Console.WriteLine("\tTitle  [" + p.Name + "]" + "\t Health point + [" + p.HpPoints + "]" + "\t Race  [" + p.Race + "]");
            }
        }
        public void start()
        {
            Helm item1 = new Helm("magik cap", "Human",0,0,2,0,10,1,1,1);
            Helm item2 = new Helm("iron helm", "Human", 0, 0, 1, 0, 20, 1, 1, 1);
            Helm item3 = new Helm("Fishman cap", "Ork", 0, 0, 2, 0, 10, 1, 1, 1);
            Helm item4 = new Helm("Oak helm", "Okr", 0, 0, 1, 0, 20, 1, 1, 1);
            Human human = new Human();
            Ork ork = new Ork();
            heroesList.Clear();
            heroesList.Add(human);           
            heroesList.Add(ork);
            itemsList.Clear();
            itemsList.Add(item1);
            itemsList.Add(item2);
            itemsList.Add(item3);
            itemsList.Add(item4);
            Console.WriteLine(human.getInfo());
            Console.WriteLine(ork.getInfo());
            Console.WriteLine(" ");
            getPersonList();
            getItemList();
            

            
          




            
        }

    }
}
