﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IKundeRepository Kunde { get; }
        IProjectRepository Project { get; }
        IOpgaveRepository Opgave { get; }
        IMedarbejdeRepository Medarbejde { get; }
        ISkillRepository Skill { get; }
        IBookingRepository Booking { get; }
        Task Save ( );
    }
}
