using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Domain
{
    public class Skill
    {
        public Guid SkillId { get; set; }
        public string? SkillTitle { get; set; }
        public string? Description { get; set; }
    }
}
