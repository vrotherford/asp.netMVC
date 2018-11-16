using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Interfaces
{
    public interface ITournamentRepository : IDisposable
    {
        IEnumerable<Tournament> GetTournamentsList();
        Tournament GetTournament(Guid id);
    }
}
