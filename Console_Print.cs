using System;


namespace HelloWorld
{
    public class Console_Print
    {
        public void Console_Printing ()
            {
              string text = "";
              int centerX;
              int centerY;

              text_print MEET = new text_print();
              delete_text MET = new delete_text();

              int WindHeight = Console.WindowHeight - 1;
              int WindWidth = Console.WindowWidth;
              Console.ForegroundColor = ConsoleColor.Green;
              for (int i = 0; i < WindWidth; i++) // верх
              {
                  Console.SetCursorPosition(i, 1);
                  Console.Write("*");
              }
              for (int a = 1; a < WindHeight; a++) // лево право
              {
                  Console.SetCursorPosition(0, a);
                  Console.WriteLine("*");
                  Console.SetCursorPosition(WindWidth - 1, a);
                  Console.WriteLine("*");
              }
              for (int i = 0; i < WindWidth; i++) //низ
              {
                  Console.SetCursorPosition(i, WindHeight - 8);
                  Console.Write("*");
              }
              for (int i = 0; i < WindWidth; i++) //низ-низ
              {
                  Console.SetCursorPosition(i, WindHeight);
                  Console.Write("*");
              }
////////////////////////////////////////////////////////////////////////////////////
              System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Олег\Desktop\work\HelloWorld\Kavinsky_feat_Cautious_Clay_-_Renegade_73358101.wav");
              // player.Play();
              player.PlayLooping();
////////////////////////////////////////////////////////////////////////////////////
              Console.ForegroundColor = ConsoleColor.White;
////////////////////////////////////////////////////////////////////////////////////

              text = "ДОБРО ПОЖАЛОВАТЬ В ЭПИЧЕСКОЕ ПРИКЛЮЧЕНИЕ!";
              centerX = (WindWidth / 2) - (text.Length / 2); // 65 - cередина ширины
              centerY = (WindHeight / 2) - 4;                 // 12 - середина высоты
              MEET.text_printing(centerX, centerY, text, 50);
            
              text = "ЭТА ИГРА БЫЛА НАПИСАНА СКВОЗЬ КРОВЬ, ПОТ И СЛЁЗЫ";
              centerX = (WindWidth / 2) - (text.Length / 2); // 65 - cередина ширины
              centerY = (WindHeight / 2) - 2;                 // 12 - середина высоты
              MEET.text_printing(centerX, centerY, text, 50);
            
              text = "ИГРАЙТЕ С УДОВОЛЬСТВИЕМ, НАДЕЮСЬ ВАМ ПОНРАВИТСЯ";
              centerX = (WindWidth / 2) - (text.Length / 2); // 65 - cередина ширины
              centerY = (WindHeight / 2);                 // 12 - середина высоты
              MEET.text_printing(centerX, centerY, text, 50);

              text = "ПРИЯТНОЙ ИГРЫ!!!";
              centerX = (WindWidth / 2) - (text.Length / 2); // 65 - cередина ширины
              centerY = (WindHeight / 2) + 1;                 // 12 - середина высоты
              MEET.text_printing(centerX, centerY, text, 50);

              // text = "ТЫ КТО?????????????????????????????";
              // centerX = (WindWidth / 2) - (text.Length / 2);
              // centerY = (WindHeight / 2) + 14;
              // MEET.text_printing(centerX, centerY, text, 50);
            
              // text = "КТО ПРОИГРАЕТ, ТОТ ЛОХ";
              // centerX = (WindWidth / 2) - (text.Length / 2);
              // centerY = (WindHeight / 2) + 18;
              // MEET.text_printing(centerX, centerY, text, 50);


              text = "НАЖМИТЕ ЛЮБУЮ КНОПКУ, ЧТОБЫ НАЧАТЬ ИГРУ";
              centerX = (WindWidth / 2) - (text.Length / 2);
              centerY = (WindHeight / 2) + 14;
              MEET.text_printing(centerX, centerY, text, 50);    

              Console.ReadKey();
//////////////////////////////////////////////////////////////////////////////////////////////
              MET.delete_upper_console();
//////////////////////////////////////////////////////////////////////////////////////////////
              MET.delete_lower_console();
              // Console.WriteLine($"Ширина - {Console.WindowWidth}"); // 158
              // Console.WriteLine($"Высота - {Console.WindowHeight - 1}"); // 36
              // Console.Read();
            }
          }
        }