using System;


namespace HelloWorld
{
    public class delete_text
    {
        public void text_deleting (int x1, int y1, int x2, int y2)
        {
            for (int a = y1; a < y2; a++) 
              {
                for (int j = x1; j < x2; j++)
                {
                  Console.SetCursorPosition(j, a);
                  Console.WriteLine(" ");
                }
              }
           }
        public void delete_upper_console ()
          {
              //ОЧИСТКА ВЕРХНЕЙ КОНСОЛИ
              for (int a = 2; a < 28; a++) 
              {
                for (int j = 1; j < 157; j++)
                {
                  Console.SetCursorPosition(j, a);
                  Console.WriteLine(" ");
                }
              }
          }
        public void delete_lower_console ()
          {
              //ОЧИСТКА НИЖНЕЙ КОНСОЛИ
              for (int a = 29; a < 36; a++) 
              {
                for (int j = 1; j < 157; j++)
                {
                  Console.SetCursorPosition(j, a);
                  Console.WriteLine(" ");
                }
              }
          }
        public void delete_all ()
          {
              //ОЧИСТКА ВЕРХНЕЙ КОНСОЛИ
              for (int a = 2; a < 28; a++) 
              {
                for (int j = 1; j < 157; j++)
                {
                  Console.SetCursorPosition(j, a);
                  Console.WriteLine(" ");
                }
              }
              //ОЧИСТКА НИЖНЕЙ КОНСОЛИ
              for (int a = 29; a < 36; a++) 
              {
                for (int j = 1; j < 157; j++)
                {
                  Console.SetCursorPosition(j, a);
                  Console.WriteLine(" ");
                }
              }
          }
        }
    }    