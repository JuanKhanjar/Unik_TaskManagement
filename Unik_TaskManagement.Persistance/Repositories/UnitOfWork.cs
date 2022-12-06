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

        public IProjectRepository Project { get; private set; }

        public IOpgaveRepository Opgave { get; private set; }

        public IMedarbejdeRepository Medarbejde { get; private set; }

        public ISkillRepository Skill { get; private set; }

        public IBookingRepository Booking { get; private set; }
        

        private readonly ApplicationDbContext _db;
        public UnitOfWork ( ApplicationDbContext db )
        {
            _db = db;
            Kunde = new KundeRepository(_db);
            Project = new ProjectRepository(_db);
            Opgave = new OpgaveRepository(_db);
            Medarbejde = new MedarbejdeRepository(_db);
            Skill = new SkillRepository(_db);
            Booking = new BookingRepository(_db);

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
