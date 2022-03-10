using System;


namespace HelloWorld
{
    public class text_print
    {
        public void text_printing (int x, int y,string text, int speed)
        {
          Console.SetCursorPosition(x, y);
            foreach(char ch in text) {
              Console.Write(ch);
              Thread.Sleep(speed); // пауза (чтобы не выводилось слишком быстро)
            }
        }
        public void text_printing (string text, int speed)
        {
            foreach(char ch in text) {
              Console.Write(ch);
              Thread.Sleep(speed); // пауза (чтобы не выводилось слишком быстро)
            }
        }
        public void text_printing_with_stop (int x, int y,string text, int speed)
        {
          Console.SetCursorPosition(x, y);
            foreach(char ch in text) {
              Console.Write(ch);
              Thread.Sleep(speed); // пауза (чтобы не выводилось слишком быстро)
            }
          ConsoleKey key = Console.ReadKey().Key;
        }

        public void text_printing_with_stop ( string text, int speed )
        {
            foreach(char ch in text) {
              Console.Write(ch);
              Thread.Sleep(speed); // пауза (чтобы не выводилось слишком быстро)
            }
          ConsoleKey key = Console.ReadKey().Key;
        }
  }
}