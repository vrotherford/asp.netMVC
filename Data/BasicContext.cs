using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Core;

namespace Data
{
    public class BasicContext: DbContext
    {
        public BasicContext(): base("Default") { }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Round> Rounds { get; set; }
    }
}
