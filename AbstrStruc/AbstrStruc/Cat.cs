using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrStruc
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
            Type = "Kotenok";
        }
        public override void GetInfo()
        {
            Console.WriteLine(Type + Name);
        }
    }
}
