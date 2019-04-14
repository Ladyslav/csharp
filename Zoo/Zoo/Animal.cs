using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class Animal
    {
        public virtual void Eat(Food food)
        {
            Console.WriteLine("Food");
        }
    }
}
