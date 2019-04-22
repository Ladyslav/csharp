using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Client : Steam, User
{
        int _sum;
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public int CountOfMoney { get { return _sum; } }
        public void Put(int sum) { _sum += sum; }
        public void Take(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
       
}
}
