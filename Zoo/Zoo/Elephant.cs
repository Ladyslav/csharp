using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Elephant : Animal
    {
        private int _requiredCallories = 15000;

        public void Eat(Food food)
        {
            if (food.Callories < _requiredCallories)
                Console.WriteLine("Not enough food for elephant, require more calories.");
            else
                Console.WriteLine("Yea, i am not hungry anymore");
        }
    }
}
