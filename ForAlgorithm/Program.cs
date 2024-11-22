﻿using System.Runtime.InteropServices;
using System;
using ForAlgorithm;
using static ForAlgorithm.Funcs;
using static ForAlgorithm.FightFuncs;
using static ForAlgorithm.AnimatedText;
using static System.Net.Mime.MediaTypeNames;
internal class Program
{  
    public static void Main(string[] args)
    {
        Console.Title = "Simple CMD Game";
        //AnimatedText animatedText = new AnimatedText();
        AnimatedText.ShowAnimText("НИКОЛАЙ GEMES ПРЕДСТАВЛЯЕТ", 20);

        AnimatedText.ShowAnimText("ПРИКЛЮЧЕНИЕ ВЕКА: ПОИСК АЭРОДИНАМИКИ ОГУРЦА... ВЕЛИКОЕ ПРОДОЛЖЕНИЕ!", 20);

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        SystemMessage("Дмитрий и Рандомыч стояли у края мрачного леса, который простирался до самого горизонта. Ветви деревьев переплетались между собой, " +
            "создавая плотный купол над их головами, сквозь который едва пробивались лучи солнца. В воздухе витал густой запах сырости и гниющих листьев. " +
            "Лес был окутан тишиной, нарушаемой лишь редкими шорохами неизвестных существ, скрывающихся среди теней.", 1);
        ForReading(1);
        SystemMessage("— Мы должны пройти через этот лес!", 5);
        SystemMessage(" — тихо сказал Дмитрий, сжимая рукоять меча.", 1);
        ForReading(1);
        SystemMessage("— В нём скрыты древние руны, способные изменить ход битвы за секрет аэродинамики огурца. Но нам нужно быть осторожными. " +
            "Говорят, там обитают чудовища, которых никто никогда не видел живым.\r\n",5);
        ForReading(1);
        SystemMessage("Рандомыч кивнул, хотя его лицо выражало сомнение:\r\n", 1);
        ForReading(1);
        SystemMessage("— Я слышал легенды об этом месте. Те, кто осмеливался войти сюда, редко возвращались обратно. " +
            "Но выбора нет. Мы должны найти эти руны.", 5);
        ForReading(1);
        SystemMessage("Они обменялись взглядами, каждый понимая, что впереди их ждёт нечто неизведанное и опасное. " +
            "Вздохнув, они шагнули под своды леса, оставляя позади себя привычный мир.", 1);
        ForReading(0);

        SystemMessage("Прошло несколько часов, прежде чем они поняли, что заблудились. Лес казался бесконечным лабиринтом, где каждое дерево было похоже на предыдущее. " +
            "Они слышали странные звуки вокруг, но ничего не видели. Наконец, когда они уже начали терять надежду, перед ними появилась небольшая поляна, окружённая древними камнями.", 1);
        ForReading(1);
        SystemMessage("— Что это? — прошептал Рандомыч, подходя ближе.", 5);
        ForReading(1);
        SystemMessage("Дмитрий поднял руку, останавливая друга:", 1);
        ForReading(1);
        SystemMessage("— Осторожнее! Это может быть ловушка.", 5);
        ForReading(1);
        SystemMessage("Но было поздно. Из-за камней внезапно выскочили две огромные тени, напоминающие гигантских волков, но с длинными когтями и острыми зубами. Их глаза светились зловещим зелёным светом.", 1);
        ForReading(1);
        SystemMessage("— Готовься к бою! — крикнул Дмитрий, выхватывая меч.", 5);
        ForReading(1);
        SystemMessage("Рандомыч тоже приготовился к схватке, вытащив свой боевой топор. Чудовища бросились на них, рыча и скалясь. Битва началась.", 5);
        ForReading(0);

        AnimatedText.ShowAnimText("БИТВА НАЧАЛАСЬ!", 20);

        Character[] mainStack = new Character[5];

        mainStack[0] = new Character("Дмитрий",100,100,20);

        mainStack[1] = new Character("Рандомыч", 100, 100, 20);

        Character[] firstEnemyStack = new Character[2];

        firstEnemyStack[0] = new Character("Волк", 60, 60, 15);
        firstEnemyStack[1] = new Character("Вожак стаи", 60, 60, 15);
        mainStack[0].AsciiArt = "      _,.\r\n    ,` -.)\r\n   ( _/-\\\\-._\r\n  /,|`--._,-^|            ,\r\n  \\_| |`-._/||          ,'|\r\n    |  `-, / |         /  /\r\n    |     || |        /  /\r\n     `r-._||/   __   /  /\r\n __,-<_     )`-/  `./  /\r\n'  \\   `---'   \\   /  /\r\n    |           |./  /\r\n    /           //  /\r\n\\_/' \\         |/  /\r\n |    |   _,^-'/  /\r\n |    , ``  (\\/  /_\r\n  \\,.->._    \\X-=/^\r\n  (  /   `-._//^`\r\n   `Y-.____(__}\r\n    |     {__)\r\n          ()";
        mainStack[1].AsciiArt = "                    ____ \r\n                  .'* *.'\r\n               __/_*_*(_\r\n              / _______ \\\r\n             _\\_)/___\\(_/_ \r\n            / _((\\- -/))_ \\\r\n            \\ \\())(-)(()/ /\r\n             ' \\(((()))/ '\r\n            / ' \\)).))/ ' \\\r\n           / _ \\ - | - /_  \\\r\n          (   ( .;''';. .'  )\r\n          _\\\"__ /    )\\ __\"/_\r\n            \\/  \\   ' /  \\/\r\n             .'  '...' ' )\r\n              / /  |  \\ \\\r\n             / .   .   . \\\r\n            /   .     .   \\\r\n           /   /   |   \\   \\\r\n         .'   /    b    '.  '.\r\n     _.-'    /     Bb     '-. '-._ \r\n _.-'       |      BBb       '-.  '-. \r\n(________mrf\\____.dBBBb.________)____)";
        firstEnemyStack[0].AsciiArt = "                              __\r\n                            .d$$b\r\n                          .' TO$;\\\r\n                         /  : TP._;\r\n                        / _.;  :Tb|\r\n                       /   /   ;j$j\r\n                   _.-\"       d$$$$\r\n                 .' ..       d$$$$;\r\n                /  /P'      d$$$$P. |\\\r\n               /   \"      .d$$$P' |\\^\"l\r\n             .'           `T$P^\"\"\"\"\"  :\r\n         ._.'      _.'                ;\r\n      `-.-\".-'-' ._.       _.-\"    .-\"\r\n    `.-\" _____  ._              .-\"\r\n   -(.g$$$$$$$b.              .'\r\n     \"\"^^T$$$P^)            .(:\r\n       _/  -\"  /.'         /:/;\r\n    ._.'-'`-'  \")/         /;/;\r\n `-.-\"..--\"\"   \" /         /  ;\r\n.-\" ..--\"\"        -'          :\r\n..--\"\"--.-\"         (\\      .-(\\\r\n  ..--\"\"              `-\\(\\/;`\r\n    _.                      :\r\n                            ;`-\r\n                           :\\\r\n                           ;  ";
        firstEnemyStack[1].AsciiArt = "⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⢛⣩⣭⣝⡻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⢋⣼⣿⣿⣿⣿⣿⣦⡙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⠏⣾⣿⣿⣿⣿⣿⣿⣿⣷⣌⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⢏⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⠟⣡⣾⣿⣿⣿⣿⣿⣿⣿⣽⣿⣛⣛⢿⣷⣌⠻⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⠟⣡⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣮⡻⣿⣿⣿⣿⣿⣿\r\n⡟⣡⣾⣿⠿⠟⠛⣛⣛⣛⣛⡛⠛⣛⣛⣛⣛⠛⠿⠿⢿⣿⣿⣿⣮⡛⣿⣿⣿⣿\r\n⠜⣫⣥⣄⠻⠞⠡⠻⠟⠹⣿⡃⠃⠻⠿⠿⠟⠹⣣⢧⢄⣠⣦⠍⣙⠷⡌⢿⣿⣿\r\n⢸⣭⡍⢛⢣⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣦⣤⣛⠩⣓⣬⣽⣶⠀⣸⣿⣿\r\n⣦⣍⣙⣓⠘⢿⣿⣿⣿⣿⣿⠟⠀⠀⠈⢻⣿⣿⣿⣿⣿⠡⣿⡿⠍⣩⣴⣿⣿⣿\r\n⣿⣿⣿⣿⣧⠠⡝⣼⣿⣿⣿⣶⣦⣄⣤⣾⣿⣿⣿⡿⢣⣭⡴⢢⣾⡿⠿⠛⣽⣿\r\n⣿⣿⣿⣿⣿⢸⣈⣹⣉⣩⣿⣿⣿⣿⣿⣿⣿⣿⠟⣑⣛⣠⣶⣿⡏⣎⢁⠘⣿⣿\r\n⣿⣿⣿⣿⣿⣆⡻⠿⠿⣿⣿⣿⣿⣿⣿⠿⢛⣥⣾⣿⡟⠛⢿⠃⡁⣿⣿⢠⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣦⣤⣤⣭⢰⣿⢞⣜⡩⠐⣉⡻⠿⠀⢁⣴⡇⡿⢉⣀⣍⢿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢏⠆⣼⠿⠛⣡⣴⣿⣶⣝⠀⠀⢻⣿⠀⣰⣿⣿⣯⡜\r\n⣿⣿⣿⣿⣿⣿⣿⣿⠟⣡⡎⡞⢁⣴⣿⣿⡿⢯⠙⠿⣷⣄⠸⡇⡾⠛⢦⢹⣷⢰\r\n⣿⣿⣿⣿⣿⣿⠟⣱⡾⣫⢌⢠⣿⣯⣭⣭⣴⣿⣟⢐⣦⡘⢷⣄⠑⣐⠚⣘⣡⣾\r\n⣿⣿⣿⠿⣋⣴⣿⡉⣴⡇⢢⣿⣿⣿⣿⣿⣿⣿⣿⠇⡙⣿⣦⢹⣧⣙⡻⢿⣿⣿\r\n⣿⣿⠇⣺⡿⢛⡅⡇⣿⡇⢼⣛⣿⣿⣿⣿⠿⢛⡥⠴⠀⡻⢿⡸⢿⣿⣿⠢⢉⣿\r\n⣿⣿⡀⣿⢰⣿⣧⣡⣿⡇⢊⠙⣛⣛⣩⠀⣚⣡⣶⣿⡇⣩⣾⣿⣦⣝⠮⣉⠂⡽\r\n⣿⣿⣇⣛⣼⣿⣿⣿⣿⣿⣶⡌⣽⣷⢂⣾⣿⣿⣿⡿⢃⣭⣬⡛⣿⣿⣿⣦⣥⣤\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣬⢱⣿⣿⣿⣿⡟⣱⠟⣿⣿⣷⡌⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿⡇⢉⣨⣴⠎⣻⣿⣿⣿⠘⣿⣿⣿⡿\r\n⣿⣿⣿⣿⣿⣿⣿⠿⣋⣭⣭⣙⠛⠈⣽⡿⢇⣾⣿⢃⣾⣿⣿⣿⣷⡅⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⡟⣴⡿⠿⢿⣿⣿⣿⣿⣿⣷⢸⣿⣿⣦⣝⣛⣛⠻⢛⣃⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣮⡙⠻⠶⠮⣝⣻⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣦⣬⣭⣭⣼⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        
        LargeBattle(mainStack, firstEnemyStack);

        SystemMessage("Битва была жестокой и изнурительной. Оба героя получили множество ранений, но всё же смогли одолеть своих противников. Когда последние удары были нанесены, чудовища исчезли в клубах дыма, оставив за собой лишь следы крови на земле.", 1);
        ForReading(1);
        SystemMessage("Дмитрий и Рандовыч опустились на колени, тяжело дыша. Они оба знали, что им повезло выжить. Но теперь перед ними стояла новая задача — найти выход из этого проклятого места.", 1);
        ForReading(1);
        SystemMessage("— Ты ранен, — заметил Рандовыйч, глядя на глубокую рану на плече Дмитрия.", 5);
        ForReading(1);
        SystemMessage("— Ничего серьёзного, — ответил тот, пытаясь улыбнуться. — Главное, мы справились. Теперь надо найти те руны и выбраться отсюда.", 5);
        ForReading(1);
        SystemMessage("Они снова поднялись на ноги и продолжили путь, зная, что лес ещё хранит много тайн и опасностей. Но они были готовы к любым испытаниям, ведь вместе они могли преодолеть любые преграды...", 1);
        ForReading(0);
        AnimatedText.ShowAnimText("THE END... but only for now ;P", 20);

    }

}