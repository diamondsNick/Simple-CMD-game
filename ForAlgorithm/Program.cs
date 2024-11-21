using System.Runtime.InteropServices;
using System;
using ForAlgorithm;
using static ForAlgorithm.Funcs;
internal class Program
{  
    public static void Main(string[] args)
    {
        SystemMessage("Привет, мой новый искатель приключений! Как тебя зовут?\n",1);
        
        Character Player = new Character();
        Player.Name = Console.ReadLine();
        Player.Health = 100;
        Player.BackupHealth = 100;
        Player.AttackPower = 5;
        Player.AsciiArt = "  / \\\r\n  | |\r\n  |.|\r\n  |.|\r\n  |:|      __\r\n,_|:|_,   /  )\r\n  (Oo    / _I_\r\n   +\\ \\  || __|\r\n      \\ \\||___|\r\n        \\ /.:.\\-\\\r\n         |.:. /-----\\\r\n         |___|::oOo::|\r\n         /   |:<_T_>:|\r\n        |_____\\ ::: /\r\n         | |  \\ \\:/\r\n         | |   | |\r\n         \\ /   | \\___\r\n         / |   \\_____\\\r\n         `-'";

        SystemMessage("\nО нет, что же это произошло? Кто то прорвал стену в туториал к игре!" +
            " Появился какой-то непонятный гоблин!", 1);
        ShowGoblin();

        SystemMessage($"\n-Отдай мне свои ресурсы!",4);

        SystemMessage($"\n\nНо наш новый герой {Player.Name}, не сдался, и решил дать ответный огонь нарушителю!", 1);

        SystemMessage($"\nНапоминаем, {Player.Name}, что у вас только начальное снаряжение! Правильно выбирайте свои действия!", 1);        
        
        Character Goblin = new Character();

        Goblin.Health = 30;
        Goblin.BackupHealth = 30;
        Goblin.Name = "Гоблин, уничтожитель новичков";
        Goblin.AttackPower = 3;
        Goblin.AsciiArt = "\r\n            /(.-\"\"-.)\\\r\n        |\\  \\/      \\/  /|\r\n        | \\ / =.  .= \\ / |\r\n        \\( \\   o\\/o   / )/\r\n         \\_, '-/  \\-' ,_/\r\n           /   \\__/   \\\r\n           \\ \\__/\\__/ /\r\n         ___\\ \\|--|/ /___\r\n       /`    \\      /    `\\\r\n      /       '----'       \\";

        BattleRetrier(Player, Goblin, "БИТВА НАЧИНАЕТСЯ!");

        Console.Clear();

        SystemMessage($"{Player.Name}, а ты силен, раз победил такого противника и без подготовки!",1);

        Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTODO: Сделать стены крепче", 3);
        Console.ResetColor();

        ForReading(0);

        SystemMessage("Ну уж в этот раз... Добро пожаловать, смелый путник, в мир приключений и загадок! " +
            "Ты только что завершил свой первый урок, где освоил основы боевой подготовки и искусства выживания. " +
            "Но настало время покинуть начальную локацию и столкнуться с реальной опасностью — отправиться в лес, о котором столько шептали старые легенды.\n", 1);
        ForReading(1);
        SystemMessage("Лес зовёт тебя. Его таинственные просторы полны опасностей и недомолвок. " +
            "Ушко природы шепчет о загадках, которые ждут тебя за каждым деревом." +
            " Но имей в виду, не всё здесь так безопасно, как кажется. " +
            "Лес любит притягивать заблудших путников и испытывать их на прочность.\n",1);
        ForReading(1);
        SystemMessage("Ты собираешь свои вещи, прощаясь с 'БЕЗОПАСНЫМ XD туториалом', и дышишь свежим воздухом." +
            " Чем ближе ты приближаешься к лесу, тем больше ощущаешь его притяжение. " +
            "Низкий гул деревьев и запах сырого мха сопровождают тебя во время твоего пути.",1);
        ForReading(0);
        SystemMessage("Вы переходите в локацию: лес теней...",0);
        ForReading(0);
        SystemMessage("Вот и вход в лес. Ты переходишь через увядший мост, который ведёт в неизвестность. " +
            "И тут ты слышишь её — тонкий, хрипловатый голос, звонкий, словно капли воды, разбивающиеся о камни.",1);
        ForReading(1);
        SystemMessage("-Я кого-то слышу, мелкого и пугливого...\nЗашел ко мне в лес, БЕЗ ПРИГЛАШЕНИЯ, и гуляет себе без каких-либо проблем!" +
            "\nНее, так не пойдет!", 4);
        ForReading(0);
        SystemMessage($"{Player.Name}, БЕРЕГИСЬ!", 1);
        ForReading(0);
        if (LuckRandNum() == 0)
        {
            SystemMessage("Герой не успел увернуться, и получил 15 урона!", 0);
            Player.Health -= 15;
        }
        else
        {
            SystemMessage("Ухх! Ты увернулся прям как Нео! (Не спрашивай кто это, а то это сломает погружение)",1);
        }

        Player.AttackPower += 5;

        Character BigASSBird = new Character();
        BigASSBird.Health = 45;
        BigASSBird.BackupHealth = 45;
        BigASSBird.AttackPower = 10;
        BigASSBird.Name = "ОГРОМЕННАЯ ПТИЦА";
        BigASSBird.AsciiArt = "                    _.:._\r\n                  .\"\\ | /\".\r\n.,__              \"=.\\:/.=\"              __,.\r\n \"=.`\"=._            /^\\            _.=\"`.=\"\r\n   \".'.'.\"=.=.=.=.-,/   \\,-.=.=.=.=\".'.'.\"\r\n     `~.`.`.`.`.`.`.     .'.'.'.'.'.'.~`\r\n        `~.`` ` `.`.\\   /.'.' ' ''.~`\r\n           `=.-~~-._ ) ( _.-~~-.=`\r\n                    `\\ /`\r\n                     ( )\r\n                      Y\r\n";

        BattleRetrier(Player, BigASSBird, "СЕЙЧАС БУДЕТ ОЧЕНЬ МНОГО ПЕРЬЕВ!");

        SystemMessage("Фухх, это было эпично, сам такого не ожидал!", 1);
        ForReading (1);
        SystemMessage("А что произойдет дальше, вы узнаете, когда Дарья Алексеевна поставит 5 :)",0);
    }
}