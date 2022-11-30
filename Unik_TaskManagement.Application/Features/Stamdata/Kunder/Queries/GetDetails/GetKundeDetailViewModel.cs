using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails
{
    public class GetKundeDetailViewModel
    {
        public Guid KundeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ProjectsDto KundesProject { get; set; }
    }
}
