using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public class People
    {
        public int Age { get; private set; }
        public string Name { get; private set; }

        public People(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void SaySomeAboutMoney()
        {
            Console.WriteLine("Where is my fucking money?");
        }

        public virtual void SaySomethingAboutMoney()
        {
            Console.WriteLine("I want to destoy your bank");
        }
     
            public virtual void FriendlyClient()
        {
            Console.WriteLine("Can I get new credit?");
        }
    }
}
