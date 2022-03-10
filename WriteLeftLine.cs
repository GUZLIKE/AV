using System;

namespace HelloWorld
{
    public class WriteLeftLine
    {
        public void line()
        {
            for (int a = 1; a < 37; a++) // лево право
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("*");
                }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}