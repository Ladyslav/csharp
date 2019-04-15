using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollars = new Dollars(1000);
            var euros = new Euros(2000);
            var employee = new Employee(20,"Vlad");
            var client = new Client(30,"Kate");

            client.SaySomeAboutMoney();
            client.SaySomethingAboutMoney();
            client.FriendlyClient();


            var storageOfDollars = new Storage();
            storageOfDollars.PlaceMoney(dollars);
            Console.WriteLine(storageOfDollars.GetStatus());

            Console.ReadKey();
        }
    }
}
