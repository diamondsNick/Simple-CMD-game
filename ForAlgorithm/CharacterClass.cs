using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithm
{
        public partial class Character()
        {
            string name;
            int health;
            int backupHealth;
            int attackPower;
            string asciiArt;

            public string Name { get => name; set => name = value; }
            public int Health { get => health; set => health = value; }
            public int AttackPower { get => attackPower; set => attackPower = value; }
            public string AsciiArt { get => asciiArt; set => asciiArt = value; }
            public int BackupHealth { get => backupHealth; set => backupHealth = value; }
        }
}
