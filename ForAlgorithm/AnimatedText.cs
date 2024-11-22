using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlgorithm
{
    public partial class AnimatedText
    {
        public static void SetRainbowText(string text)
        {
            List<ConsoleColor> colors = new List<ConsoleColor>
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan,
                ConsoleColor.White
            };

            Random random = new Random();

            foreach (char c in text)
            {
                Console.ForegroundColor = colors[random.Next(colors.Count)];
                Console.Write(c);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
        public static void ShowAnimText(string text, int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                SetRainbowText(text);
                Thread.Sleep(400);
                Console.Clear();
            }
        }
    }
}
    
