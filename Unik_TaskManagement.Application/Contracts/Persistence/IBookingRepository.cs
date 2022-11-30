using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Contracts.Persistence
{
    public interface IBookingRepository:IBaseRepository<Booking>
    {
        Task Update ( Booking booking );
    }
}
