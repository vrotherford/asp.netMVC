using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Tournament
    {
        public Guid Id { get; set; }
        public string Caption { get; set; }
        public string Info { get; set; }
        public ICollection<Round> Rounds { get; set; }
        public Tournament()
        {
            Rounds = new List<Round>();
        }
    }
}
