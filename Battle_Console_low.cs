using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace HelloWorld
{
class Battle_Console_low
    {
        delete_text now = new delete_text();  
            // public void lower_battle_print(int health, int power, int mana, int health_of_monster, int power_of_monster)
            public void lower_battle_print()
        {
            // int health_hero = health;
            // int power_hero = power;
            // int mana_hero = mana;
            // int health_monster = health_of_monster;
            // int power_monster = power_of_monster;

            Console.SetCursorPosition(30, 30);
            string first = "АТАКОВАТЬ";
            Console.Write(first);
            Console.SetCursorPosition(110, 30);
            string second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
            Console.Write(second);
            Console.SetCursorPosition(30, 32);
            string third = "СПЕЦИАЛЬНАЯ СПОСОБНОСТЬ";
            Console.Write(third);
            Console.SetCursorPosition(110, 32);
            string fourth = "УБЕЖАТЬ";
            Console.Write(fourth);

            Console.SetCursorPosition(31, 30);
                int num = keys();//вызов менюшки 
                switch (num)
                {
                    case 1: 
                    { 
                        // Attack U = new Attack();
                        // Character first_1 = new Character(); //Создаём объект для того, чтобы брать значения из класса
                        // monster first_2 = new monster(); //Создаём объект для того, чтобы брать значения из класса
                        // U.fight(health_hero, power_hero, mana_hero, health_monster, power_monster);
                        Console.SetCursorPosition(31, 35);
                        Console.WriteLine("АТАКА!!!"); 
                        } break;
                    case 2: 
                    { 
                        Console.SetCursorPosition(31, 35);
                        Console.WriteLine("ВОССТАНОВИТЬ ЗДОРОВЬЕ!!!"); 
                        Console.ReadKey(); 
                        now.delete_all();
                        } break;
                    case 3: 
                    { 
                        Console.SetCursorPosition(31, 35);
                        Console.WriteLine("СПЕЦИАЛЬНАЯ СПОСОБНОСТЬ!!!"); 
                        Console.ReadKey(); 
                        now.delete_all();
                        } break;
                    case 4: 
                    { 
                        Console.SetCursorPosition(31, 35);
                        Console.WriteLine("ВЫ УБЕЖАЛИ!!!"); 
                        Console.ReadKey(); 
                        now.delete_all();
                        } break;
                }
        }
            static void Text(int i)//Замена цвета менющки
                {
                    string first = "АТАКОВАТЬ";
                    string second = "ВОССТАНОВИТЬ ЗДОРОВЬЕ";
                    string third = "СПЕЦИАЛЬНАЯ СПОСОБНОСТЬ";
                    string fourth = "УБЕЖАТЬ";
                    if (i==1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(30, 30);
                        Console.WriteLine(first);
                        Console.ResetColor();
                        Console.SetCursorPosition(110, 30);
                        Console.WriteLine(second);
                        Console.SetCursorPosition(30, 32);
                        Console.WriteLine(third);
                        Console.SetCursorPosition(110, 32);
                        Console.WriteLine(fourth);
                    }
                    if (i == 2)
                    {
                        Console.SetCursorPosition(30, 30);
                        Console.WriteLine(first);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(110, 30);
                        Console.WriteLine(second);
                        Console.ResetColor();
                        Console.SetCursorPosition(30, 32);
                        Console.WriteLine(third);
                        Console.SetCursorPosition(110, 32);
                        Console.WriteLine(fourth);
                    }
                    if (i == 3)
                    {
                        Console.SetCursorPosition(30, 30);
                        Console.WriteLine(first);
                        Console.SetCursorPosition(110, 30);
                        Console.WriteLine(second);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(30, 32);
                        Console.WriteLine(third);
                        Console.ResetColor();
                        Console.SetCursorPosition(110, 32);
                        Console.WriteLine(fourth);
                    }
                    if (i == 4)
                    {
                        Console.SetCursorPosition(30, 30);
                        Console.WriteLine(first);
                        Console.SetCursorPosition(110, 30);
                        Console.WriteLine(second);
                        Console.SetCursorPosition(30, 32);
                        Console.WriteLine(third);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(110, 32);
                        Console.WriteLine(fourth);
                        Console.ResetColor();
                    }
                }
            static int keys()//работа менюшки
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
                    if (keyPushed.Key == ConsoleKey.LeftArrow)
                    {
                        num--;
                        Text(num);
                    }
                    if (keyPushed.Key == ConsoleKey.RightArrow)
                    {
                        num++;
                        Text(num);
                    }
                    if (keyPushed.Key == ConsoleKey.Enter)
                    {
                        flag = true;
                    }
                    if (num == 0)
                    {
                        num = 4;
                        Text(4);
                    }
                    if (num == 5)
                    {
                        num = 1;
                        Text(1);
                    }
                }while(!flag);
                return num;
            }   
   }
}