using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   public class Money
    {
        public Money(int scoreofmoney)
        {
            ScoreOfMoney = scoreofmoney;
        }
        public int ScoreOfMoney { get; private set; }

    }
}
