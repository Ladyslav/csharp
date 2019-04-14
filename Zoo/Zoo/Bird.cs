using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Bird : Animal
    {
        public override void Eat(Food food)
        {
            Console.WriteLine($"Yea, foor with {food.Callories} calories is good");
        }
    }
}
