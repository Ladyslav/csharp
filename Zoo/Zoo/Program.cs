using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var elephant = new Elephant();
            var bird = new Bird();

            var employee = new ZooEmployee(23, "Petro");
            var visitor = new Visitor(15, "Ivan");

            employee.GoToTheZoo();
            visitor.GoToTheZoo();

            var plant = new Plant();
            var birdAviary = new Aviary();
            var elephantAviary = new Aviary();

            birdAviary.PlacePlant(plant);
            birdAviary.PlaxeAnimal(bird);
            elephantAviary.PlaxeAnimal(elephant);

            Console.WriteLine(birdAviary.GetStatus());

            employee.FeedAnimal(elephant);
            employee.FeedAnimal(bird);

            visitor.Observe(elephant);
            visitor.Observe(bird);
            Console.ReadKey();
        }
    }
}
