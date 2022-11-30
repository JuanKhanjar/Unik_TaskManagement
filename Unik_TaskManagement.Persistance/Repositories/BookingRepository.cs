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
    public class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _db;
        public BookingRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db = db;
        }

        public async Task Update ( Booking booking )
        {
            Booking objFromDb = await _db.Booking.FirstOrDefaultAsync(B => B.BookId == booking.BookId);
            if (objFromDb != null)
            {
                objFromDb.StartDate = booking.StartDate;
                objFromDb.EndDate = booking.EndDate;
                objFromDb.Duration = booking.Duration;
                objFromDb.ProjectId = booking.ProjectId;
                objFromDb.MedarbejdeId = booking.MedarbejdeId;
                objFromDb.OpgaveId = booking.OpgaveId;

            }
        }
    }
}
