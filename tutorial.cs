using System;
using System.Threading;

namespace HelloWorld
{
    public class tutorial
    {
        public void meet_text ()
        {
          text_print main = new text_print();
          delete_text major = new delete_text();
          menu can = new menu();
          WriteLeftLine left = new WriteLeftLine();

          string text = @"
                                            ████████████████████████████████████████████████████████████████████████████████
                                            █▌       █▄  ▀██▀ `▄▌       ██▀▀   `▀██▌     `▀▀▌  ████▀▐█████▀▀█████████▀  `███
                                            ████░ ▐█████,    ▄█████░ ▐███  ▄████, ▐▌  ████  ▌  █▀`  ▐████`  ▀███████▌    ███
                                            ████░ ▐██████▌ ░███████  ▐██▌ ░██████  ▌  -` ` ▄▌    ,░ ▐███` ╓  ╙█████▌  [  ███
                                            ████░ ▐██████▌  ███████  ▐███Ç ╙▀██▀' ▄▌  ██████▌  ▄██░ ▐██   └    ███▀  ▄▌  ███
                                            ████▄▄▐██████▌▄▄███████▄▄▐█████▄,,,▄▄███▄▄██████▌▄████▄▄▐█▄▄▄████▄▄▄█▄▄▄▄█▌▄▄███
                                            ████████████████████████████████████████████████████████████████████████████████
";
          Console.SetCursorPosition(1, 10);
          Console.WriteLine(text);
          left.line();
          Thread.Sleep(2000);
          major.delete_upper_console();

          text = "ПРИВЕТСТВУЮ ТЕБЯ НА ОБУЧЕНИИ ОСНОВАМ БОЯ!";
          main.text_printing( (Console.WindowWidth / 2) - (text.Length / 2), 2, text, 50 );
          text = "ЭТО ВЕРХНЕЕ ПОЛЕ.";
          main.text_printing( 30, 5, text, 50 );
          text = " В НЕМ ПРОИСХОДИТ ВСЁ ПОВЕСТВОВАНИЕ - ОПИСАНИЕ, ДИАЛОГИ, ВНЕШНОСТЬ ПЕРСОНАЖЕЙ И ТАК ДАЛЕЕ";
          main.text_printing_with_stop( text, 50 );
          text = "А НИЖНЕЕ ПОЛЕ - ПОЛЕ ДЕЙСТВИЯ. ВЫБОР В ДИАЛОГАХ ИЛИ В СРАЖЕНИЯХ. КСТАТИ О ПОСЛЕДНЕМ..";
          main.text_printing_with_stop ((Console.WindowWidth / 2) - (text.Length / 2), 31, text, 50);
          major.delete_all();
        
          
          text = "ПО МЕРЕ ПРОХОЖДЕНИЯ ТЕБЕ БУДУТ ПОПАДАТЬСЯ ЧУДОВИЩА";
          main.text_printing( (Console.WindowWidth / 2) - (text.Length / 2), 2, text, 50 );
          text = "КОГДА ТЫ ВСТРЕЧАЕШЬСЯ С ОДНИМ ИЗ НИХ - ТЫ ПОПАДАЕШЬ В ''БОЕВУЮ КОНСОЛЬ''.";
          main.text_printing( (Console.WindowWidth / 2) - (text.Length / 2), 3, text, 50 );
          text = "ДАВАЙ ПОТРЕНИРУЕМСЯ НА МОЁМ МАКЕТЕ ЧУДОВИЩА!";
          main.text_printing((Console.WindowWidth / 2) - (text.Length / 2), 5, text, 50 );
          
          can.Menu("1. КОНЕЧНО!", "2. Я НЕ ХОЧУ..", "ТОГДА В БОЙ!", @"
                                       ████████████████████████████████████████████████████████████████████████████████
                                       ██,,,▀█▌`  `█▀▀  ▀▀███▌ ██ ▐ `  ▐███ ,▄ ▀██▀; ▀▀█ , ,`▌   -▀█▀▀ ,▀██▀ ,,▐▌ █████
                                       ███▌▀` ██ ▐█▌ ████ ███▌ ▀▀ ▐  ▀▀████ ╙▀'²█ ████ ▐ ██▌ ▌ ▀▀▀ ▌ ███▌ F ████▌ █████
                                       ██▀▀▀ ▄██ ▐██,╙▀▀`,███▌ ██ ▐  ▀▀▀███ ╚▀▀ █▄`▀▀▀,█ ██▌ ▌ █████ ▀▀▀ ▄█,`▀▀▀█▀█████
                                       ████████████████████████████████████████████████████████████████████████████████
");
          major.delete_all();

          text = "НО, ЧТОБЫ У ТЕБЯ БЫЛИ ХОТЬ КАКИЕ-ТО ШАНСЫ - РАССКАЖУ ОСНОВЫ";
          main.text_printing_with_stop((Console.WindowWidth / 2) - (text.Length / 2), 5, text, 50 );

          major.delete_upper_console();

          text = "НЕМНОГО ПРО ВИЗУАЛЬНУЮ ЧАСТЬ";
          main.text_printing((Console.WindowWidth / 2) - (text.Length / 2), 5, text, 50 );
          text = "СЛЕВА БУДЕТ НАХОДИТЬСЯ ИКОНКА С ХАРАКТЕРИСТИКАМИ ПЕРСОНАЖА, А СПРАВА - ПАРАМЕТРЫ ЧУДОВИЩА";
          main.text_printing((Console.WindowWidth / 2) - (text.Length / 2), 7, text, 50 );
          text = $"СУЩЕСТВУЕТ 3 ВИДА ЧУДОВИЩ - ";
          main.text_printing( 30, 9, text, 50 );
          Console.ForegroundColor = ConsoleColor.Green;
          text = "ЗЕЛЁНЫЕ";
          main.text_printing(text, 50);
          Console.ResetColor();
          text = "(НИЖНЕГО УРОВНЯ),";
          main.text_printing(text, 50);
          Console.ForegroundColor = ConsoleColor.Yellow;
          text = "- ЖЁЛТЫЕ";
          main.text_printing(56, 10, text, 50);
          Console.ResetColor();
          text = "(СРЕДНЕГО УРОВНЯ),";
          main.text_printing( text, 50 );
          Console.ForegroundColor = ConsoleColor.Red;
          text = "- КРАСНЫЕ";
          main.text_printing( 56, 11, text, 50);
          Console.ResetColor();
          text = "(ВЫСОКОГО УРОВНЯ)";
          main.text_printing(text, 50);
          text = "КАЖДЫЙ МОНСТР БУДЕТ ПОДСВЕЧИВАТЬСЯ СВОИМ ЦВЕТОМ, ТАК ЧТО БУДЕТ ЛЕГКО ОПРЕДЕЛИТЬ ЕГО УРОВЕНЬ";
          main.text_printing_with_stop( 30, 13, text, 50 );

          major.delete_upper_console();

          text = "А ТЕПЕРЬ ПРО МЕХАНИКУ";
          main.text_printing((Console.WindowWidth / 2) - (text.Length / 2), 5, text, 50 );
          
          text = "ЕСЛИ В ТВОЕЙ БАНДЕ БОЛЬШЕ 1 ИГРОКА, ТО ВЫ ХОДИТЕ ПО ОЧЕРЕДИ, ПОКА КАЖДЫЙ НЕ СДЕЛАЕТ СВОЙ ХОД. ПОСЛЕ ЭТОГО НАСТУПАЕТ ХОД МОНСТРА";
          main.text_printing( (Console.WindowWidth / 2) - (text.Length / 2), 7, text, 50 );
          text = "У ТЕБЯ ЕСТЬ 4 ДЕЙСТВИЯ: - АТАКА,";
          main.text_printing( 40, 9, text, 50 );
          text = "- ВОССТАНОВЛЕНИЕ ЗДОРОВЬЯ,";
          main.text_printing( 64, 10, text, 50 );
          text = "- СПЕЦИАЛЬНАЯ АТАКА,";
          main.text_printing( 64, 11, text, 50 );
          text = "- УБЕЖАТЬ";
          main.text_printing_with_stop( 64, 12, text, 50 );

          text = "АТАКА - СПОСОБ НАНЕСЕНИЯ УРОНА. НО КАЖДЫЙ МОНСТР ИМЕЕТ СВОЮ МЕХАНИКУ БОЯ, ПОЭТОМУ НЕТ СМЫСЛА ОБЪЯСНЯТЬ БОЛЬШЕ";
          main.text_printing_with_stop( 20, 14, text, 50 );
          text = "ВОССТАНОВЛЕНИЕ - СПОСОБ ВЫЛЕЧИТЬ СВОЕГО ''ГЕРОЯ''. У ТЕБЯ ЕСТЬ ИНВЕНТАРЬ С ПРИПАСАМИ, КОТОРЫЕ МОЖНО ПОПОЛНЯТЬ";
          main.text_printing_with_stop( 20, 16, text, 50 );
          text = "СПЕЦИАЛЬНАЯ АТАКА - ИСПОЛЬЗОВАНИЕ УНИКАЛЬНОГО ПРИЁМА, НО ЕЁ ИСПОЛЬЗОВАНИЕ ТРЕБУЕТ МАНЫ, ТАК ЧТО БУДЬ ВНИМАТЕЛЬНЕЕ";
          main.text_printing_with_stop( 20, 18, text, 50 );
          text = "И ''ПОБЕГ'' - ВОЗМОЖНОСТЬ УЙТИ ИЗ БИТВЫ, НО НЕ СОВЕТУЮ ИСПОЛЬЗОВАТЬ.";
          main.text_printing( 20, 20, text, 50 );
          text = "ВО-ПЕРВЫХ, ТЫ НЕ ПОЛУЧАЕШЬ ЗОЛОТО, КОГДА ПОБЕЖДАЕШЬ ЧУДОВИЩЕ, А ОНО МОЖЕТ ПРИГОДИТЬСЯ В БУДУЩЕМ. А ВО-ВТОРЫХ, ЧЕМ СИЛЬНЕЕ МОНСТР - ";
          main.text_printing( 20, 21, text, 50 );
          text = "- ТЕМ МЕНЬШЕ ШАНСОВ УБЕЖАТЬ, ТЫ МОЖЕШЬ ПРОСТО ТАК ПОТРАТИТЬ СВОЙ ХОД";
          main.text_printing_with_stop( 20, 22, text, 50 );

          major.delete_upper_console();

          text = "ТЕПЕРЬ ПОСМОТРИМ КАК ТЫ УСВОИЛ МАТЕРИАЛ";
          main.text_printing_with_stop((Console.WindowWidth / 2) - (text.Length / 2), 10, text, 50 );

          major.delete_upper_console();
        }
  }
}