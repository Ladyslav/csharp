using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client : People
    {
        public Client(int age, string name) : base(age, name)
        {
        }
        private int _scoreOfDollars = 100;
        private int _scoreOfEuros = 150;

        public override void SaySomeAboutMoney()
        {
            base.SaySomeAboutMoney();
            Console.WriteLine("Got it");
        }
        public void Credit(Money money)
        {
            if (money.ScoreOfMoney > (_scoreOfDollars + _scoreOfEuros))
            {
                Console.WriteLine("You can get credit");

            }
            else Console.WriteLine("Sorry,you have enough of money");
        }
    }
}
