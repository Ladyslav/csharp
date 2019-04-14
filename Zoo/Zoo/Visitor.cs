using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
  public  class Visitor : Person
    {
        public Visitor(int age, string name) : base(age, name)
        {
        }

        public override void GoToTheZoo()
        {
            base.GoToTheZoo();
            Console.WriteLine("Horray");
        }

        public void Observe(Animal animal)
        {
            Console.WriteLine("Such a nice animal");
        }
    }
}
