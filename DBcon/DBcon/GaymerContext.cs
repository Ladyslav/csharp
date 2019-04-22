using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBcon
{
    class GaymerContext : DbContext
    {
        public GaymerContext()
           : base("DbConnection")
        { }

        public DbSet<Gaymer> Users { get; set; }
    }
}
