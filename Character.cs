// using System;

// namespace HelloWorld
// {
//     class Character
//     {
//         public int health = 0;
//         public int power = 0;
//         public int mana = 0;
//         public int gold = 0;
//         public void set_parameters(int number_of_hero) {
//             if (number_of_hero == 1)
//             {
//                 health = 70;
//                 power = 20;
//                 mana = 55;
//                 gold = 0;
//             }
//             else if (number_of_hero == 2)
//             {
//                 health = 100;
//                 power = 50;
//                 mana = 5;
//                 gold = 0;
//             }
//             else if (number_of_hero == 3)
//             {
//                 health = 30;
//                 power = 30;
//                 mana = 90;
//                 gold = 0;
//             }
//             else if (number_of_hero == 4)
//             {
//                 health = 80;
//                 power = 35;
//                 mana = 0;
//                 gold = 0;
//             }
//         }
//         public void update_parameters(int health, int power, int mana, int gold) {
//             this.health = health;
//             this.power = power;
//             this.mana = mana;
//             this.gold = gold;
//         }
//         public void update_parameters(int health) {
//             this.health = health;
//         }

//         public void show_parameters (){
//             Console.WriteLine("ОЧКИ ЗДОРОВЬЯ -> " + health);
//             Console.WriteLine("ОЧКИ УРОНА -> " + power);
//             Console.WriteLine("ОЧКИ МАНЫ -> " + mana);
//             Console.WriteLine("ЗОЛОТО -> " + gold);
//         } 
//     }
// }