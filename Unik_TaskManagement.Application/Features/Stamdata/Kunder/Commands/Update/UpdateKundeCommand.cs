using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update
{
    public class UpdateKundeCommand: IRequest
    {
        public Guid KundeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
