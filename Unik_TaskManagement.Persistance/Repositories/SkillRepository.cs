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
    public class SkillRepository : BaseRepository<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext _db;
        public SkillRepository ( ApplicationDbContext db ) : base(db)
        {
            this._db = db;
        }

        public async Task Update ( Skill skill )
        {
            Skill objFromDb= await _db.Skills.FirstOrDefaultAsync(S=>S.SkillId==skill.SkillId);
            if(objFromDb != null)
            {
                objFromDb.SkillTitle=skill.SkillTitle;
                objFromDb.Description=skill.Description;
            }
        }
    }
}
