using System;
using System.Threading;

namespace HelloWorld
{
    public class Print_meet_icon
    {
        public void Print_new_icon (int number_of_character)
            {                
                int WindHeight = Console.WindowHeight - 1;
                int WindWidth = Console.WindowWidth;
                string icon = "";
                string text = "";
                var icon_color = ConsoleColor.White;

                string name = "";
                string race = "";
                string special_attack = "";

                string hp = "";
                string mp = "";
                string ap = "";


                text_print main = new text_print();
                delete_text Now = new delete_text();
                WriteLeftLine left = new WriteLeftLine();

                if (number_of_character == 0){
                        icon = @"
                    # # # # # # # # # # # # # # # # # # # # # # # #
                    #                                             #
                    #             # # #     # # #                 #
                    #             #     #   #     #               #
                    #               #     #   #     #             #
                    #               #     #   #     #             #
                    #             # #     # # #     #             #
                    #             # #     #   #     #             #
                    #             #                 #             #
                    #             #                 #             #
                    #     # # # # #       #     #   # # # # #     #
                    #     #       #       #     #   #       #     #
                    #       #     #       #     #   #     #       #
                    #         #   #                 #   #         #
                    #           # #                 # #           #
                    #         # # #         # #     # # #         #
                    #       #     #                 #     #       #
                    #     #       # # # # # # # # # #       #     #
                    #   #           #             #           #   #
                    #     #         #             #         #     #
                    #       # # # # #             # # # # #       #
                    # # # # # # # # # # # # # # # # # # # # # # # #";
                        
                        name = "gg";
                        race = "gg";
                        special_attack = "gg";

                        hp = "100";
                        mp = "30";
                        ap = "20";
                        icon_color = ConsoleColor.DarkRed;
                }
                else if (number_of_character == 1){
                        icon = @"
                    2 # # # # # # # # # # # # # # # # # # # # # # #
                    #                                             #
                    #             # # #     # # #                 #
                    #             #     #   #     #               #
                    #               #     #   #     #             #
                    #               #     #   #     #             #
                    #             # #     # # #     #             #
                    #             # #     #   #     #             #
                    #             #                 #             #
                    #             #                 #             #
                    #     # # # # #       #     #   # # # # #     #
                    #     #       #       #     #   #       #     #
                    #       #     #       #     #   #     #       #
                    #         #   #                 #   #         #
                    #           # #                 # #           #
                    #         # # #         # #     # # #         #
                    #       #     #                 #     #       #
                    #     #       # # # # # # # # # #       #     #
                    #   #           #             #           #   #
                    #     #         #             #         #     #
                    #       # # # # #             # # # # #       #
                    # # # # # # # # # # # # # # # # # # # # # # # #";
                        
                        name = "second";
                        race = "second";
                        special_attack = "second";

                        hp = "80";
                        mp = "45";
                        ap = "15";
                        icon_color = ConsoleColor.DarkYellow;
                }

                else if (number_of_character == 2){
                        icon = @"
                    3 # # # # # # # # # # # # # # # # # # # # # # #
                    #                                             #
                    #             # # #     # # #                 #
                    #             #     #   #     #               #
                    #               #     #   #     #             #
                    #               #     #   #     #             #
                    #             # #     # # #     #             #
                    #             # #     #   #     #             #
                    #             #                 #             #
                    #             #                 #             #
                    #     # # # # #       #     #   # # # # #     #
                    #     #       #       #     #   #       #     #
                    #       #     #       #     #   #     #       #
                    #         #   #                 #   #         #
                    #           # #                 # #           #
                    #         # # #         # #     # # #         #
                    #       #     #                 #     #       #
                    #     #       # # # # # # # # # #       #     #
                    #   #           #             #           #   #
                    #     #         #             #         #     #
                    #       # # # # #             # # # # #       #
                    # # # # # # # # # # # # # # # # # # # # # # # #";
                        
                        name = "third";
                        race = "third";
                        special_attack = "third";

                        hp = "50";
                        mp = "95";
                        ap = "17";
                        icon_color = ConsoleColor.DarkBlue;
                }
                else if (number_of_character == 3){
                        icon = @"
                    4 # # # # # # # # # # # # # # # # # # # # # # #
                    #                                             #
                    #             # # #     # # #                 #
                    #             #     #   #     #               #
                    #               #     #   #     #             #
                    #               #     #   #     #             #
                    #             # #     # # #     #             #
                    #             # #     #   #     #             #
                    #             #                 #             #
                    #             #                 #             #
                    #     # # # # #       #     #   # # # # #     #
                    #     #       #       #     #   #       #     #
                    #       #     #       #     #   #     #       #
                    #         #   #                 #   #         #
                    #           # #                 # #           #
                    #         # # #         # #     # # #         #
                    #       #     #                 #     #       #
                    #     #       # # # # # # # # # #       #     #
                    #   #           #             #           #   #
                    #     #         #             #         #     #
                    #       # # # # #             # # # # #       #
                    # # # # # # # # # # # # # # # # # # # # # # # #";
                        
                        name = "fourth";
                        race = "fourth";
                        special_attack = "fourth";

                        hp = "80";
                        mp = "45";
                        ap = "15";
                        icon_color = ConsoleColor.DarkMagenta;
                    }
                else if (number_of_character == 4){
                        icon = @"
                    5 # # # # # # # # # # # # # # # # # # # # # # #
                    #                                             #
                    #             # # #     # # #                 #
                    #             #     #   #     #               #
                    #               #     #   #     #             #
                    #               #     #   #     #             #
                    #             # #     # # #     #             #
                    #             # #     #   #     #             #
                    #             #                 #             #
                    #             #                 #             #
                    #     # # # # #       #     #   # # # # #     #
                    #     #       #       #     #   #       #     #
                    #       #     #       #     #   #     #       #
                    #         #   #                 #   #         #
                    #           # #                 # #           #
                    #         # # #         # #     # # #         #
                    #       #     #                 #     #       #
                    #     #       # # # # # # # # # #       #     #
                    #   #           #             #           #   #
                    #     #         #             #         #     #
                    #       # # # # #             # # # # #       #
                    # # # # # # # # # # # # # # # # # # # # # # # #";
                        
                        name = "fifth";
                        race = "fifth";
                        special_attack = "fifth";  

                        hp = "150";
                        mp = "5";
                        ap = "30";
                        icon_color = ConsoleColor.Gray;             
                }
///////////////////////////////////////////////////////////////////////////////////
                Console.ForegroundColor = ConsoleColor.White;
                
                text = "ВАМ ДОСТУПЕН НОВЫЙ ПЕРСОНАЖ!";
                main.text_printing(93, 3, text, 50);

                text = $"ИМЯ ПЕРСОНАЖА: {name}";
                main.text_printing(70, 5, text, 50);

                text = $"РАСА: {race}";
                main.text_printing(120, 5, text, 50);

                text = $"СПЕЦИАЛЬНЫЕ НАВЫКИ: {special_attack}";
                main.text_printing(93, 7, text, 50);

                text = $"ОЧКИ ЗДОРОВЬЯ -> {hp}";
                main.text_printing(70, 9, text, 50);

                text = $"ОЧКИ МАНЫ     -> {mp}";
                main.text_printing(70, 11, text, 50);

                text = $"ОЧКИ УРОНА    -> {ap}";
                main.text_printing(70, 13, text, 50);


                Console.ForegroundColor = icon_color;
                Console.SetCursorPosition(30, 3);
                Console.Write(icon);
                left.line();

                Thread.Sleep(1000);

                Now.text_deleting(20, 3, 67, 27);

                Console.ForegroundColor = icon_color;
                Thread.Sleep(1000);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine(icon);
                left.line();

                Thread.Sleep(1000);

                Now.text_deleting(20, 3, 67, 27);

                Console.ForegroundColor = icon_color;
                Thread.Sleep(1000);
                Console.SetCursorPosition(30, 3);
                Console.WriteLine(icon);

                left.line();
///////////////////////////////////////////////////////////////////////////////////            
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
        Now.delete_upper_console();
    }
  }
}