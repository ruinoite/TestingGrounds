using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Item
    {

        public Item()
        {
            //No need for anything in here as Item is just a base and there
            //will probably never be an object which is only an "Item"
        }

        //Declare the vars, while making them properties
        public int Weight { get; protected set; } // Only Inside this class we can edit this value(and deprived classes)
        public int Value { get; protected set; } // Only Inside this class we can edit this value
        public string Name { get; protected set; } // Only Inside this class we can edit this value
    }
}
