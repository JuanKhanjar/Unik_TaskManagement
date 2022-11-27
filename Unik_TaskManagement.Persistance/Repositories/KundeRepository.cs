using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Domain;
using Unik_TaskManagement.Persistence.Data;

namespace Unik_TaskManagement.Persistence.Repositories
{
    public class KundeRepository : BaseRepository<Kunde>, IKundeRepository
    {
        private readonly ApplicationDbContext _db;
        public KundeRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db = db;
        }

        public async Task Update ( Kunde kunde )
        {
            var objFromDb = await _db.Kunder.FirstOrDefaultAsync(k => k.KundeId == kunde.KundeId);
            if (objFromDb != null)
            {
                objFromDb.FullName = kunde.FullName;
                objFromDb.Email = kunde.Email;
                objFromDb.Phone = kunde.Phone;
            }
        }
    }
}
