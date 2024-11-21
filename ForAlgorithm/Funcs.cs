using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithm
{
    internal class Funcs
    {
        public static int LuckRandNum()
        {
            Random LuckMultiplier = new Random();
            int ReLuckMultiplier = LuckMultiplier.Next(0, 4);
            return ReLuckMultiplier;
        }
        public static int CalculateDamage(Character perso)
        {

            return perso.AttackPower * LuckRandNum();
        }
        public static void ShowGoblin()
        {
            Console.WriteLine("\r\n            /(.-\"\"-.)\\\r\n        |\\  \\/      \\/  /|\r\n        | \\ / =.  .= \\ / |\r\n        \\( \\   o\\/o   / )/\r\n         \\_, '-/  \\-' ,_/\r\n           /   \\__/   \\\r\n           \\ \\__/\\__/ /\r\n         ___\\ \\|--|/ /___\r\n       /`    \\      /    `\\\r\n      /       '----'       \\");
        }
        public static void BattleRetrier(Character Attacker, Character Enemy, string messageStart)
        {
            while (true)
            {
                if (Battle(Attacker, Enemy, messageStart) == true)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    SystemMessage("Вы хотите попробовать снова? (1 - нет)", 0);
                    {
                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            SystemMessage("Увидимся снова, но позже...", 0);
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            SystemMessage("НЕ СДАВАЙСЯ!", 1);
                            Attacker.Health = Attacker.BackupHealth;
                            Enemy.Health = Enemy.BackupHealth;
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        public static bool Battle(Character Attacker, Character Enemy, string messageStart)
        {
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("\n\tБИТВА НАЧИНАЕТСЯ!\n");
            SystemMessage(messageStart, 0);
            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                if (Attacker.Health <= 0)
                {
                    SystemMessage($"Битва окончена... \n", 1);
                    ForReading(1);
                    SystemMessage($"{Attacker.Name} был побежден...", 1);
                    Console.ReadKey();
                    return false;
                }
                else if (Enemy.Health <= 0)
                {
                    SystemMessage($"Битва окончена...", 1);
                    ForReading(1);
                    SystemMessage($"\n{Attacker.Name} победил!", 1);
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(Enemy.AsciiArt);

                    int damageTaken = CalculateDamage(Enemy);
                    Attacker.Health -= damageTaken;
                    SystemMessage($"\n{Enemy.Name} атакует! {Attacker.Name} нанесено {damageTaken} урона!\n", 1);

                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(Attacker.AsciiArt);
                    int damageGiven = CalculateDamage(Attacker);
                    Enemy.Health -= damageGiven;
                    SystemMessage($"\n{Attacker.Name} атакует! {Enemy.Name} нанесено {damageGiven} урона!\n", 1);
                    Console.ReadKey();
                }

            }
        }
        public static void SystemMessage(string messageFromSystem, int type)
        {
            switch (type)
            {
                case 0: Console.ForegroundColor = ConsoleColor.Magenta; break;//sys
                case 1: Console.ForegroundColor = ConsoleColor.DarkYellow; break;//Nar
                case 3: Console.ForegroundColor = ConsoleColor.Green; break;//subMes
                case 4: Console.ForegroundColor = ConsoleColor.Red; break;//Enemy
                default: Console.ForegroundColor = ConsoleColor.Gray; break;
            }
            Console.WriteLine($"{messageFromSystem}");
            Console.ResetColor();
        }

        public static void ForReading(int type)
        {
            switch (type)
            {
                case 0:
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 1:
                    Console.ReadKey();
                    break;
            }
        }
    }
}
