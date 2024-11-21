using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithm
{
    public partial class Character(string Name, int Health, int BackupHealth, int AttackPower)
    {

        string asciiArt;

        public string Name { get; set; } = Name;
        public int Health { get; set; } = Health;
        public int BackupHealth { get; set; } = BackupHealth;
        public int AttackPower { get; set; } = AttackPower;
        public string AsciiArt { get => asciiArt; set => asciiArt = value; }
    }
}
