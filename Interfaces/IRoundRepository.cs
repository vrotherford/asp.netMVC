using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Interfaces
{
    public interface IRoundRepository: IDisposable
    {
        IEnumerable<Round> GetRoundsList();
        IEnumerable<Round> GetRoundsInTournamentList(Guid TournamentsID);
        Round GetRound(Guid Id);
        int GetRoundsInTournamentCount(Guid TournamentsID);
    }
}
