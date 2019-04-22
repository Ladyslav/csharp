using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrStruc
{
    class Parrot : Animal 
    {
        public Parrot(string name)
        {
            Name = name;
            Type = "Popugay";
        }
        public override void GetInfo()
        {
            Console.WriteLine(Type + Name);
        }
    }
}
