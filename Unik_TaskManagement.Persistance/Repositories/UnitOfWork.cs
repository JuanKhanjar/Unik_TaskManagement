using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Contracts.Persistence;
using Unik_TaskManagement.Persistence.Data;

namespace Unik_TaskManagement.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IKundeRepository Kunde { get; private set; }

        private readonly ApplicationDbContext _db;
        public UnitOfWork ( ApplicationDbContext db )
        {
            _db = db;
            Kunde = new KundeRepository(_db);
        }

        public void Dispose ( )
        {
            _db.Dispose( );
        }

        public async Task Save ( )
        {
            await _db.SaveChangesAsync( );
        }
    }
}
