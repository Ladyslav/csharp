using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephant = new Slon();
            var bird = new Bird();

            var employee = new Spivrobitnik(23, "Petro");
            var visitor = new Vidviduvach(15, "Ivan");

            employee.GoToTHeZoo();
            visitor.GoToTHeZoo();

            var plant = new Roslunu();
            var birdAviary = new Voler();
            var elephantA= new Voler();
            birdAviary.PlacePlant(plant);
            elephantA.PlacePlant(plant);
               

        }
    }
}
