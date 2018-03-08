using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Item
    {

        public Item()   //Create Item template
        {
            Weight = 10;
            Value = 5;
            Name = "unknown";
        }

        //Declare the vars, while making them properties
        public int Weight { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
