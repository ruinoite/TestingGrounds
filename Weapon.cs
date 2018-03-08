using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds
{
    class Weapon : Item
    {
        int Damage;
        enum Type { Ranged, Meele, Magic};
        int PDmgMul;
        int MDmgMul;
        int MDrnMul;
    }
}
