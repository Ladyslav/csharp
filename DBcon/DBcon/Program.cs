using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcon
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GaymerContext db = new GaymerContext())
            {
              
                Gaymer gaymer1 = new Gaymer { Name = "VLAD", Age = 33, Id=1, NickName="killer" };
                Gaymer gaymer2 = new Gaymer { Name = "dIMA", Age = 26, Id=2, NickName = "Mchine" };

              
                db.Users.Add(gaymer1);
                db.Users.Add(gaymer2);               
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

             
                var gaymers = db.Users;
                Console.WriteLine("Список объектов:");
                foreach (Gaymer u in gaymers)
                {
                    Console.WriteLine("{0}.{1} - {3}", u.Id, u.Name, u.Age, u.NickName);
                }
                Console.ReadKey();
            }
        }
    }
}
