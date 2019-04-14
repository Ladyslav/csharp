using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04
{
    public class Slon : Animals
    {
        private int _reauiredCallories = 15000;
        public override void Eat(Korm food)
        {
            if (food.Callories < _reauiredCallories)
                Console.WriteLine("not enough food");
            else
                Console.WriteLine("Yea");
         
        }
    }
}
