using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
  public  class Person
    {

        public int Age { get; private set; }
        public string Name { get; private set; }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void GoToTheZoo()
        {
            Console.WriteLine("I am going to the zoo");
        }
    }
}
