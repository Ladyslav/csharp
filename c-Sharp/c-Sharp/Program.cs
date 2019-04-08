using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("Список задач:\r\n 1 - сложение\r\n 2 - разница\r\n 3 - умножение\r\n 4 - деление\r\n 5 - Задача №1\r\n 6 - Задача №2 \r\n 7 - Задача №3\r\n 8 - задача №4\r\n 9 - Выход ");
                choice = (Console.ReadLine());
                Console.Clear();

                switch (choice)
                {

                    case "1":


                        System.Console.WriteLine("Напишите 3 числа с типом int");
                        {
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());
                            int result = First(A, B, C);
                            if (result > 100)
                            {
                                Console.WriteLine("Результат сложения  >  100: " + result);
                            }
                            if (result < 100)
                            {
                                Console.WriteLine("Результат сложения < 100: " + result);
                            }
                            if (result == 100)
                            {
                                System.Console.WriteLine("Результат сложения = 100: " + result);
                            }
                        }

                        break;

                    case "2":

                        {
                            System.Console.WriteLine("Напишите 3 числа с типом int");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());
                            int result = Second(A, B, C);
                            if (result > 100)
                            {
                                Console.WriteLine("Результат разницы > 100: " + result);
                            }
                            if (result < 100)
                            {
                                Console.WriteLine("Результат разницы < 100: " + result);
                            }
                            if (result == 100)
                            {
                                System.Console.WriteLine("Результат разницы = 100: " + result);
                            }

                         
                        }

                        break;

                    case "3":

                        {
                            System.Console.WriteLine("Напишите 3 числа с типом int");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());
                            int result = Third(A, B, C);
                            if (result > 100)
                            {
                                Console.WriteLine("Результат умножения > 100: " + result);
                            }
                            if (result < 100)
                            {
                                Console.WriteLine("Результат умножения < 100: " + result);
                            }
                            if (result == 100)
                            {
                                System.Console.WriteLine("Результат умножения = 100: " + result);
                            }

                          
                        }

                        break;

                    case "4":
                        {
                            System.Console.WriteLine("Напишите 3 числа с типом int");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());
                            float result = Forth(A, B, C);
                            if (result > 100)
                            {
                                Console.WriteLine("Результат деления > 100: " + result);
                            }
                            if (result < 100)
                            {
                                Console.WriteLine("Результат деления < 100: " + result);
                            }
                            if (result == 100)
                            {
                                System.Console.WriteLine("Результат деления = 100: " + result);
                            }

                         
                        }

                        break;

                    case "5":
                        {
                            System.Console.WriteLine("Напишите 2 числа с типом int");
                            int A = int.Parse(Console.ReadLine());
                            int B = int.Parse(Console.ReadLine());

                            if (A < B)
                            {
                                System.Console.WriteLine("-1");
                            }

                            if (A == B)
                            {
                                System.Console.WriteLine("0");
                            }

                            else
                            {
                                System.Console.WriteLine("1");
                            }
                        }

                        break;

                    case "6":

                        {

                            System.Console.WriteLine("Add - A, B, C");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());

                            if (C < 0)
                            {
                                System.Console.WriteLine("Rezultat: 1");
                            }

                            if (C == 0)
                            {
                                System.Console.WriteLine("Rezultat: " + A);
                            }

                            if (C > 0)
                            {
                                System.Console.WriteLine("Rezultat: " + TASK6(A, B));
                            }
                        }

                        break;

                    case "7":
                        {
                            System.Console.WriteLine("Add - A, B, C");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());

                            if (-2 <= B && B < 2)

                            {
                                System.Console.WriteLine("Rezultat: " + TASK6(A));
                            }
                            else
                            {
                                System.Console.WriteLine("Rezultat: " + Task7(A, C));
                            }

                        }

                        break;

                    case "8":
                        {
                            System.Console.WriteLine("Add - A, B, C");
                            var A = int.Parse(Console.ReadLine());
                            var B = int.Parse(Console.ReadLine());
                            var C = int.Parse(Console.ReadLine());
                            if (B == 1)
                            {
                                System.Console.WriteLine("Rezultat: " + Task8(A, B, C));
                            }

                            if (B == 2)
                            {
                                System.Console.WriteLine("Rezultat: " + Task8(A, C));
                            }
                        }
                        break;
                        


                    case "9":
                        
                        exit = true;
                        break;

                    default:

                        Console.WriteLine("Вы не выбрали задачу");
                     

                        break;
                       


                }
            }
            /*var A = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());
            if (A < 0)
            {
                int result = First(A, B, C);
                
                Console.WriteLine(result);
                
            }
            if (A > 0)
            {
                int result = Second(A, B, C);
             
                Console.WriteLine(result);
            }
          else 
            {
                int result = Third(A, B, C);
                
                Console.WriteLine(result);
            }

                 
            System.Console.ReadLine(); */

        }


        public static int First(int a, int b, int c)
        {
            return a + b + c;

        }

        public static int Second(int a, int b, int c)
        {
            return a - b - c;

        }

        public static int Third(int a, int b, int c)
        {
            return a * b * c;

        }

        public static float Forth(float a, float b, float c)
        {
            return a / b / c;
        }

        public static int TASK6(int a, int b)
        {
            return a + b;
        }

        public static int TASK6(int a)
        {
            return a * a;
        }

        public static int Task7(int a, int c)
        {
            return a * a + 2 * a * c + c * c;

        }

        public static int Task8(int a, int b, int c)
        {
            return a * a + 4 * b + c;
        }

        public static float Task8(float a, float c)
        {
            return 1 / (2 * a + c);
        }





    }
}
