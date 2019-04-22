using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrStruc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Parrot("Kesha"));
            animals.Add(new Cat("Basya"));
            foreach (Animal animal in animals)
                animal.GetInfo();
            Console.ReadKey();
        }
    }
}
