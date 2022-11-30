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
    internal class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        private readonly ApplicationDbContext _db;
        public ProjectRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db = db;
        }

        public async Task Update ( Project project )
        {
          
            var objFromDb = await _db.Projects.FirstOrDefaultAsync(p => p.ProjectId == project.ProjectId);
            if (objFromDb != null)
            {
                objFromDb.ProjectTitle = project.ProjectTitle;
            }
        }
    }
}
