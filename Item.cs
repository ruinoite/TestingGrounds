using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Item
    {
        //int Weight;
        //int Value;
        //string Name;

        public Item()
        {
            Weight = 10;
            Value = 5;
            Name = "unknown";
        }

        public int Weight { get; }
        public int Value { get; }
        public string Name { get; set; }
    }
}
