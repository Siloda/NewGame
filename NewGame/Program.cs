using System;
using System.Collections.Generic;

namespace NewGame
{
    class Program
    {
        static Engine en = Engine.Letsgo;
       static Person pm = new Person();
       static Item it = new Item();
        

        static void Main(string[] args)
        {
            en.start();


        }
    }
}
