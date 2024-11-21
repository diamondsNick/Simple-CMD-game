using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithm
{
    public class Weapon()
    {
        string name;
        int damage;
        int type;

        public string Name { get => name; set => name = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Type { get => type; set => type = value; }
    }
}
