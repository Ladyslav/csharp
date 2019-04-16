using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Zombies
{
    class Fight : Program
    {

      static player player
        {
            get { return Program.player; }
            set { Program.player = value;
 }
        }


        public static void FightEnemy(enemy enemy)
        {
            Console.WriteLine($"На вас напал {enemy.Name} с уроном {enemy.Damage} с защитой {enemy.Armor} и с жизнью {enemy.MaxHealth}");
            Console.WriteLine("Нажмите enter чтобы продолжить");
            Console.ReadLine();
            Console.Clear();

        go:
            Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
            Console.WriteLine($"{player.name}: {player.health} HP");
            Console.WriteLine("1: Ydarit, 2: Run away");

            ConsoleKey key = GetButtom();

            if (key == ConsoleKey.D1)
            {
                enemy.Health -= Math.Max(player.damage -= enemy.Armor, 1);
            }
            else if (key == ConsoleKey.D2)
            {
                int r = Program.random.Next(1, 5);

                if (r == 2)
                {
                    Console.WriteLine("Вам удалось убежать");
                    goto run;
                }
                else
                {
                    Console.WriteLine("Вам не удалось убежать");
                }
            }
            else
            {
                Console.WriteLine("команды не существует");
                Thread.Sleep(2000);
                Console.Clear();
                goto go;
            }


            if (enemy.Health > 0)
            {
                player.health -= Math.Max(enemy.Damage -= player.Armor, 1);
            } 

            if (player.health<=0)
            {
                goto lose;
            }
            else if (enemy.Health<=0)
            {
                goto win;
            }
            else
            {
                Console.Clear();
                goto go;
            }

        win:
            Console.Clear();
            Console.WriteLine("You win!");
            Console.WriteLine("You got experience");
            return;

        lose:
            Console.Clear();
            Console.WriteLine("You lose");
            return;
              






        run:
            ;

        }
        
        
    }
}
