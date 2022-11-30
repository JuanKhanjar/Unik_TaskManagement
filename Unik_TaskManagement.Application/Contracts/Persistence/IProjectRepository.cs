using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Contracts.Persistence
{
    public interface IProjectRepository:IBaseRepository<Project>
    {
        Task Update ( Project project );
    }
}
