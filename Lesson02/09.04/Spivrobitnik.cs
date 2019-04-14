using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._04
{
    public class Spivrobitnik : People
    {
        int _availableMoney;
        public Spivrobitnik(int age, string name) : base(age, name)
        {
        }
        public void FeedAnimal(Animals animal)
        {
            
        }
        public void CleanAvary(Voler aviary)
        {

        }
        public void ReceivePayement(int salary)
        {
            _availableMoney += salary;
        }
    }
}
