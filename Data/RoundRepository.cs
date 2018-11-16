using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Core;

namespace Data
{
    public class RoundRepository: IRoundRepository
    {
        private BasicContext db;

        public RoundRepository()
        {
            this.db = new BasicContext();
        }

        public IEnumerable<Round> GetRoundsList()
        {
            return db.Rounds.ToList();
        }

        public IEnumerable<Round> GetRoundsInTournamentList(Guid TournamentsID)
        {
            return db.Rounds.Where(r=>r.TournamentsID == TournamentsID);
        }

        public int GetRoundsInTournamentCount(Guid TournamentsID)
        {
            return db.Rounds.Where(r => r.TournamentsID == TournamentsID).Count();
        }

        public Round GetRound(Guid Id)
        {
            return db.Rounds.Find(Id);
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
