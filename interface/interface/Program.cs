using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Vladislav", 300);
            client.Put(50);
            Console.WriteLine(client.CountOfMoney);
            client.Take(25);
            Console.WriteLine(client.CountOfMoney);
            Console.Read();
        }
    }
}
