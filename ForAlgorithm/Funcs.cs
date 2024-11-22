using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForAlgorithm;

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
        public static int RandEnemyPicker(Character[] characters)
        {
            Random RandNum = new Random();
            int RandomCharacter = 0;
            while (true)
            {

                RandomCharacter = RandNum.Next(0, characters.Length);
                if (characters[RandomCharacter] != null && characters[RandomCharacter].Health > 0) break;
            }
            return RandomCharacter;
        }
        public static int ChooseTarget(Character[] persons, bool isFight)
        {
            int amOfActive = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] != null && persons[i].Health > 0)
                {
                    SystemMessage($"{i}. {persons[i].Name}\n", 0);
                    amOfActive++;
                }

            }
            if (amOfActive > 0 && isFight == true)
            {
                SystemMessage("Выберите цель:", 0);
                int targetID = 0;
                targetID = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                return targetID;
            }
            else return -1; //If none is active
        }
        public static bool IsArrayOfCharactersBeaten(Character[] arrayOfCharacters)
        {
            int amountOfActiveCharacters = 0;
            foreach (Character character in arrayOfCharacters)
            {
                if (character != null && character.Health > 0) amountOfActiveCharacters++;
            }
            if (amountOfActiveCharacters > 0) return false;
            else return true;

        }
        public static void ShowGoblin()
        {
            Console.WriteLine("\r\n            /(.-\"\"-.)\\\r\n        |\\  \\/      \\/  /|\r\n        | \\ / =.  .= \\ / |\r\n        \\( \\   o\\/o   / )/\r\n         \\_, '-/  \\-' ,_/\r\n           /   \\__/   \\\r\n           \\ \\__/\\__/ /\r\n         ___\\ \\|--|/ /___\r\n       /`    \\      /    `\\\r\n      /       '----'       \\");
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
