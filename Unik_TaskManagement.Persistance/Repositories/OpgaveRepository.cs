using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
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
    internal class OpgaveRepository : BaseRepository<Opgave>, IOpgaveRepository
    {
        private readonly ApplicationDbContext _db;
        public OpgaveRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db = db;
        }

        public async Task Update ( Opgave opgave )
        {
            //Get Opgave from Db
            Opgave objFromDb=await _db.Opgaver.FirstOrDefaultAsync(o=>o.OpgaveId==opgave.OpgaveId);
            if (objFromDb!=null)
            {
                objFromDb.Title = opgave.Title;
                objFromDb.Description = opgave.Description;
            }
        }
    }
}
