using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Storage
    {
        private Money _money;
        
        public bool IsClean { get; set; }
        public void PlaceMoney(Money money)
        {
            _money = money;
        }

        public string GetStatus()
        {
            if (_money != null)
                return "Money is inside";
            else return "emty";
        }
    }
}
