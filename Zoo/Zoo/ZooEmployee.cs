using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public class ZooEmployee : Person
    {
        int _availableMoney;
        public ZooEmployee(int age, string name) : base(age, name)
        {
        }

        public void FeedAnimal(Animal animal)
        {
            var food = new Food(12000);
            animal.Eat(food);
        }

       // public void CleanAvary(Aviary aviary)
        //{
  
        //}

        public void ReceivePayement(int sallary)
        {
            _availableMoney += sallary;
        }
    }
}
