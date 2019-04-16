using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game_Zombies
{
    class Program
    {
       public static player player;
       public static Random random;



        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("После крушения корабля");
            Thread.Sleep(2000);
        go:
            Console.Clear();
            Console.WriteLine("1:Информация, 2:Инвентарь, 3:Иследовать, 4:Охота");

            ConsoleKey key = GetButtom();

            if (key == ConsoleKey.D1)
            {
                Console.WriteLine($"имя:{player.name}");
                Console.WriteLine($"жизнь:{player.health}/{player.healthMax}");
                Console.WriteLine($"энергия:{player.power}/{player.powerMax}");
                Console.WriteLine("Нажмите на любую кнопку");
                Console.ReadKey();
                goto go;
            }
            else if (key == ConsoleKey.D2)
            {
                player.invetory.GetAllItems();
            }
            else if (key == ConsoleKey.D3)
            {
                if (player.power > 0)
                {
                    player.power--;
                    explore();
                }
                else
                    Console.WriteLine("Вы устали");
            }
            else if (key == ConsoleKey.D4)
            {
                Fight.FightEnemy(DataBase.GetEnemy(0));
            }
            else
            {
                Console.WriteLine("команды не существует");
                Thread.Sleep(2000);             
                goto go;
            }
            Console.WriteLine("Нажмите на любую клавишу чтобы продолжить");
            Console.ReadKey();
            goto go;
        



        }

        private static ConsoleKey GetButtom()
        {
            throw new NotImplementedException();
        }
        public static void explore()
        {

        }

    }
}
