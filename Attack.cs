// using System;

// namespace HelloWorld
// {
//     class Attack : Character
//     { 

//         public void fight(int health_hero, int power_hero, int mana_hero, int health_monster, int power_monster)
//         {
//             Character GG = new Character();
//             while (health_monster > 0)
//             {
//                 health_monster = health_monster - power_hero;
//                 health_hero = health_hero - power_monster;
//                 Console.WriteLine("ОЧКИ ЗДОРОВЬЯ ПЕРСОНАЖА -> " + health_hero);
//                 Console.WriteLine("ОЧКИ ЗДОРОВЬЯ ЧУДОВИЩА -> " + health_monster);
//             }
//             GG.update_parameters(health_hero);
//             GG.show_parameters();
//         }
//     }
// }