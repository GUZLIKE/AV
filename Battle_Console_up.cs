using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HelloWorld
{
    public class Battle_Console_up
    {
        delete_text monster = new delete_text();
        WriteLeftLine left = new WriteLeftLine();
        text_print main = new text_print();

        string battle = @"
                                        ████████████████████████████████████████████████████████████████████████████████
                                        █████▌░░░░░░░░███▌░░░░░░░░░░▀████████░░████████░░░▐███▀░░░░▄██████████░░████████
                                        █████▌░░░██░░░███▌░░░█████▒░░▐██████░░░░▀██████░░░▐█▀░░░░▄██████████▀░░░░███████
                                        █████▌░░░██░░░███▌░░░████▀▒░░▐█████░░░░░░▀█████░░░░░░░░████████████▀░░░░░░██████
                                        ███▌░░░░░░░░░░░░█▌░░░░░░░░░░▄█████░░░▐█░░░░████░░░░░░░░░▀█████████▒░░░▐█░░░░████
                                        ███▌░░▄▄▄▄▄▄▄░░░█▌░░░███████████▀░░░░░░░░░░░███░░░▐██▄░░░░▀██████ ░░░░░░░░░░▀███
                                        ███▌░░███████▒░░█▌░░░███████████░░░▄▄▄▄▄▄░░░░██░░░▐████▄░░░░▀███░░░▄▄▄▄▄▄▄░░░███
                                        ████████████████████████████████████████████████████████████████████████████████
";
        public void upper_battle_print (int color, string mnstr ,string text)
        {
          System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Олег\Desktop\work\HelloWorld\mizuna-steps5-by-inium_effectoid.wav");
          player.PlayLooping();
          Console.SetCursorPosition(1, 10);
          Console.Write(battle);
          left.line();
          Thread.Sleep(2000);
          monster.delete_upper_console();
          
          main.text_printing((Console.WindowWidth / 2) - (text.Length / 2), 31, text, 50);
          Console.SetCursorPosition(1, 1);

          if (color == 1) Console.ForegroundColor = ConsoleColor.Green;
          else if (color == 2) Console.ForegroundColor = ConsoleColor.Yellow;
          else if (color == 3) Console.ForegroundColor = ConsoleColor.Red;
          
          Console.Write(mnstr);
          left.line();
          Console.ReadKey();
          monster.delete_lower_console();
        }
    }
}