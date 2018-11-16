using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Core;
using System.Data.Entity;

namespace Data
{
    public class TournamentRepository: ITournamentRepository
    {
        private BasicContext db;

        public TournamentRepository()
        {
            this.db = new BasicContext();
        }

        public IEnumerable<Tournament> GetTournamentsList()
        {
            return db.Tournaments.Include(t=>t.Rounds).ToList();
        }

        public Tournament GetTournament(Guid id)
        {
            return db.Tournaments.Find(id);
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
