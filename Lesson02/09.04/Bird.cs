using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04
{
    public class Bird : Animals
    {
        public override void Eat(Korm food)
        {
            Console.WriteLine($"Yea, foor callor");
        }
    }
}
