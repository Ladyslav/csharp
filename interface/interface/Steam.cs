using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    interface Steam
{
        int CountOfMoney { get; }
        void Put(int sum);
        void Take(int sum);
}
}
