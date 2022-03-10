using System;

namespace HelloWorld
{

    class menu
    {

        WriteLeftLine left = new WriteLeftLine();
        public void Menu(string first, string second, string first_answer, string second_answer)
                {
                    Console.SetCursorPosition(2, 30);
                    // first = "АТАКОВАТЬ";
                    Console.Write(first);
                    Console.SetCursorPosition(2, 31);
                    // second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                    Console.Write(second);

                    Console.SetCursorPosition(3, 30);
                        int num = keys();//вызов менюшки 
                        switch (num)
                        {
                            case 1: 
                            { 
                                Console.SetCursorPosition(80, 15);
                                Console.WriteLine($"{first_answer}"); 
                                left.line();
                                Console.ReadKey(); 
                                } break;

                            case 2: 
                            { 
                                Console.SetCursorPosition(50, 10);
                                Console.WriteLine($"{second_answer}");
                                left.line(); 
                                Console.ReadKey(); 
                                } break;
                }
                    void Text(int i)//Замена цвета менющки
                        {
                            // string first = "АТАКОВАТЬ";
                            // string second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                            if (i==1)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(2, 30);
                                Console.WriteLine(first);
                                Console.ResetColor();
                                Console.SetCursorPosition(2, 31);
                                Console.WriteLine(second);
                            }
                            if (i == 2)
                            {
                                Console.SetCursorPosition(2, 30);
                                Console.WriteLine(first);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(2, 31);
                                Console.WriteLine(second);
                                Console.ResetColor();
                            }
                        }
                    int keys()//работа менюшки
                    {
                        int num = 0;
                        bool flag=false;
                        do
                        {
                            ConsoleKeyInfo keyPushed = Console.ReadKey();
                            if (keyPushed.Key == ConsoleKey.DownArrow)
                            {
                                num++;
                                Text(num);
                            }
                            if (keyPushed.Key == ConsoleKey.UpArrow)
                            {
                                num--;
                                Text(num);
                            }
                            if (keyPushed.Key == ConsoleKey.Enter)
                            {
                                flag = true;
                            }
                            if (num == 0)
                            {
                                num = 2;
                                Text(2);
                            }
                            if (num == 3)
                            {
                                num = 1;
                                Text(1);
                            }
                        }while(!flag);
                        return num;
                    }   
                }    
            public void Menu(string first, string second, string third, string first_answer, string second_answer, string third_answer)
                {
                    Console.SetCursorPosition(2, 30);
                    // first = "АТАКОВАТЬ";
                    Console.Write(first);
                    Console.SetCursorPosition(2, 31);
                    // second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                    Console.Write(second);
                    Console.SetCursorPosition(2, 32);
                    // second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                    Console.Write(third);

                    Console.SetCursorPosition(3, 30);
                        int num = keys();//вызов менюшки 
                        switch (num)
                        {
                            case 1: 
                            { 
                                Console.SetCursorPosition(50, 15);
                                Console.WriteLine($"{first_answer}"); 
                                left.line(); 
                                Console.ReadKey(); 
                                } break;

                            case 2: 
                            { 
                                Console.SetCursorPosition(50, 15);
                                Console.WriteLine($"{second_answer}"); 
                                left.line(); 
                                Console.ReadKey(); 
                                } break;
                            case 3: 
                            { 
                                Console.SetCursorPosition(50, 15);
                                Console.WriteLine($"{third_answer}"); 
                                left.line(); 
                                Console.ReadKey(); 
                                } break;
                }
                    void Text(int i)//Замена цвета менющки
                        {
                            // string first = "АТАКОВАТЬ";
                            // string second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                            if (i==1)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(2, 30);
                                Console.WriteLine(first);
                                Console.ResetColor();
                                Console.SetCursorPosition(2, 31);
                                Console.WriteLine(second);
                                Console.SetCursorPosition(2, 32);
                                Console.WriteLine(third);
                            }
                            if (i == 2)
                            {
                                Console.SetCursorPosition(2, 30);
                                Console.WriteLine(first);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(2, 31);
                                Console.WriteLine(second);
                                Console.ResetColor();
                                Console.SetCursorPosition(2, 32);
                                Console.WriteLine(third);
                            }
                            if (i == 3)
                            {
                                Console.SetCursorPosition(2, 30);
                                Console.WriteLine(first);
                                Console.SetCursorPosition(2, 31);
                                Console.WriteLine(second);
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(2, 32);
                                Console.WriteLine(third);
                                Console.ResetColor();
                            }
                        }
                    int keys()//работа менюшки
                    {
                        int num = 0;
                        bool flag=false;
                        do
                        {
                            ConsoleKeyInfo keyPushed = Console.ReadKey();
                            if (keyPushed.Key == ConsoleKey.DownArrow)
                            {
                                num++;
                                Text(num);
                            }
                            if (keyPushed.Key == ConsoleKey.UpArrow)
                            {
                                num--;
                                Text(num);
                            }
                            if (keyPushed.Key == ConsoleKey.Enter)
                            {
                                flag = true;
                            }
                            if (num == 0)
                            {
                                num = 3;
                                Text(3);
                            }
                            if (num == 4)
                            {
                                num = 1;
                                Text(1);
                            }
                        }while(!flag);
                        return num;
                    }   
                }    
    }
}