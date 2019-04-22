using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrStruc
{
  abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; protected set; }
        public abstract void GetInfo();
    }
}
