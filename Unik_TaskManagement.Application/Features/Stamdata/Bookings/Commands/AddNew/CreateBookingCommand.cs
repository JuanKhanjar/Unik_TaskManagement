using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Bookings.Commands.AddNew
{
	public class CreateBookingCommand:IRequest<Guid>
	{

		public Guid ProjectId { get; set; }
		public Guid OpgaveId { get; set; }
		public Guid MedarbejdeId { get; set; }

		[Required(ErrorMessage = "startdato er påkrævet")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		[DisplayName("Start dato")]
		public DateTime StartDate { get; set; } = DateTime.UtcNow;

		[Required(ErrorMessage = "slutdato er påkrævet")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		[DisplayName("Slut dato")]
		public DateTime EndDate { get; set; }
		public int Duration { get; set; }
	}
}
