using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ForAlgorithm.Funcs;

namespace ForAlgorithm
{
    internal class FightFuncs()
    {
        public static int CalculateDamage(Character perso)
        {
            return perso.AttackPower * LuckRandNum();
        }
        public static int GiveDamage(Character CurCharacter, Character TargetCharacter)
        {
            int dam = CalculateDamage(CurCharacter);
            if (dam >= 0) return dam;
            else return dam * -1;

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
        public static void LargeBattle(Character[] heroes, Character[] enemies)
        {
            while (true)
            {
               
                if (IsArrayOfCharactersBeaten(heroes) == true)
                {
                    Console.WriteLine("Все герои были побеждены... :("); break;
                }

                for (int i = 0; i < heroes.Length; i++)
                {

                    if (heroes[i] != null && heroes[i].Health > 0)
                    {
                        SystemMessage($"Сейчас атакует: {heroes[i].Name}", 0);
                        int e = ChooseTarget(enemies, true);
                        if (e != -1)
                        {
                            SystemMessage(heroes[i].AsciiArt, 1);
                            SystemMessage($"{heroes[i].Name} атакует: {enemies[e].Name}", 0);
                            int DamageGiven = GiveDamage(heroes[i], enemies[e]);
                            SystemMessage($"{heroes[i].Name} нанес {enemies[e].Name} {DamageGiven} урона\n", 0);
                            enemies[e].Health -= DamageGiven;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }               
                Console.Clear();
                if (IsArrayOfCharactersBeaten(enemies) == true) 
                {
                    Console.WriteLine("Все враги были побеждены... ПОБЕДА!"); break;
                }

                for (int i = 0; i < enemies.Length; i++)
                {
                    if (enemies[i] != null && enemies[i].Health > 0)
                    {
                        SystemMessage(enemies[i].AsciiArt, 1);
                        SystemMessage($"Сейчас атакует: {enemies[i].Name}", 0);
                        int e = RandEnemyPicker(heroes);

                        SystemMessage($"{enemies[i].Name} атакует: {heroes[e].Name}", 0);

                        int DamageGiven = GiveDamage(enemies[i], heroes[e]);
                        heroes[e].Health -= DamageGiven;
                        SystemMessage($"{enemies[i].Name} нанес {heroes[e].Name} {DamageGiven} урона\n", 0);

                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                Console.Clear();
            }
        }
    }
}