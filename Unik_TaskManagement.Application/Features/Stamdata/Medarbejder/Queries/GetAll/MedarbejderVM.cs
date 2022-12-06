using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Medarbejder.Queries.GetAll
{
	public class MedarbejderVM
	{
		public Guid MedarbejdeId { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Udfyld venligst de påkrævede felter")]
		public string FirstName { get; set; }
		public string LastName { get; set; }

		[Required, Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required, Display(Name = "Tlf. nummer"), DataType(DataType.PhoneNumber)]
		public string Phone { get; set; }

	}
}
