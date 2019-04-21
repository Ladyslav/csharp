using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Game_Zombies
{
    [Serializable]
    class Program
    {
       public static player player;
       public static Random random;



        static void Main(string[] args)
        {


             random = new Random();
             player = new player();
            BinaryFormatter formatter = new BinaryFormatter();
           
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, random);

            }
            using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
            {
                player newPlayer = (player)formatter.Deserialize(fs);
                
            }
            DataBase.Load();
        
            Console.Clear();
            Console.WriteLine("1:играть");
            Console.WriteLine("2:загрузить");
            Console.WriteLine("3:выйти");

            ConsoleKey key = GetButtom();
            Console.Clear();


            if (key == ConsoleKey.D1)
            {
                Console.WriteLine("Напишите имя");
                player.name = Console.ReadLine();
                Game();
            }
            else if (key == ConsoleKey.D2)
            {

            }
            else if (key == ConsoleKey.D3)
            {

            }
            else
            {
                Console.WriteLine("Комнады не существует");
                Thread.Sleep(2000);
                
            }

        }





        public static void Game()
        {
            Console.WriteLine(DataBase.GetItem(1).name);
            Console.Clear();
            Console.WriteLine("После крушения корабля");
            Thread.Sleep(2000);
            while (true)
            {


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
                    Console.WriteLine("Kоманды не существует");
                    Thread.Sleep(2000);                   
                }
                Console.WriteLine("Нажмите на любую клавишу чтобы продолжить");
                Console.ReadKey();
                


            }
        }

        public static ConsoleKey GetButtom()
        {
            var but = Console.ReadKey(true).Key;
            return but;
        }
        public static void explore()
        {
            int ran = random.Next(0, 20);

            if (ran <5)
            {
                Console.WriteLine("Вы нашли пещеру");
            }
            else if (ran<=10)
            {
                Console.WriteLine("Вы нашли сундук");
            }
            else if (ran <= 15)
            {
                Console.WriteLine("Вы нашли кристал");
            }
            else
            {
                Console.WriteLine("Вы ничего не нашли");
            }

          

        }




        }

     

    }

