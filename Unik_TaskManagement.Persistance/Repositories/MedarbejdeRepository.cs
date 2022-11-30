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
    public class MedarbejdeRepository : BaseRepository<Medarbejde>, IMedarbejdeRepository
    {
        private readonly ApplicationDbContext _db;
        public MedarbejdeRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db= db;
        }

        public async Task Update ( Medarbejde medarbejde )
        {
            Medarbejde objFromDb = await _db.Medarbejder.FirstOrDefaultAsync(M => M.MedarbejdeId == medarbejde.MedarbejdeId);
            if (objFromDb != null)
            {
                objFromDb.FirstName=medarbejde.FirstName;
                objFromDb.LastName=medarbejde.LastName;
                objFromDb.Email=medarbejde.Email;
                objFromDb.Phone=medarbejde.Phone;
                objFromDb.Job=medarbejde.Job;
            }
        }
    }
}
