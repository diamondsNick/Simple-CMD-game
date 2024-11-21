using System.Runtime.InteropServices;
using System;
using ForAlgorithm;
using static ForAlgorithm.Funcs;
internal class Program
{  
    public static void Main(string[] args)
    {

        Character[] mainStack = new Character[5];

        mainStack[0] = new Character("Дмитрий",100,100,20);

        mainStack[1] = new Character("Рандомыч", 100, 100, 20);
        //Player.Name = "Инокентий";
        //Player.Health = 100;
        //Player.BackupHealth = 100;
        //Player.AttackPower = 5;
        //Player.AsciiArt = "  / \\\r\n  | |\r\n  |.|\r\n  |.|\r\n  |:|      __\r\n,_|:|_,   /  )\r\n  (Oo    / _I_\r\n   +\\ \\  || __|\r\n      \\ \\||___|\r\n        \\ /.:.\\-\\\r\n         |.:. /-----\\\r\n         |___|::oOo::|\r\n         /   |:<_T_>:|\r\n        |_____\\ ::: /\r\n         | |  \\ \\:/\r\n         | |   | |\r\n         \\ /   | \\___\r\n         / |   \\_____\\\r\n         `-'";

        foreach (Character chel in mainStack)
        {
            if (chel != null) { Console.WriteLine(chel.Name); }
        }

    }
}