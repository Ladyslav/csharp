using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
  public  class Food
    {

        public Food(int callories)
        {
            Callories = callories;
        }

        public int Callories { get; private set; }
    }
}
