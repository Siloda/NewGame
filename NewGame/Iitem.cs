using System;
using System.Collections.Generic;
using System.Text;

namespace NewGame
{
    interface Iitem
    {
        void takeItem(int heroIndex, int itemIndex);

        void putItem();
        void dropItem();
        void temInfo();

      
    }
}
