using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unik_TaskManagement.Domain;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos
{
	public class KundeViewModel
	{

		[Key]
		public Guid KundeId { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Udfyld venligst de påkrævede felter")]
		[Display(Name = "Fuldnavn")]
		public string FullName { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "Udfyld venligst de påkrævede felter")]
		[Display(Name = "Email Address")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }


		[Required(AllowEmptyStrings = false, ErrorMessage = "Udfyld venligst de påkrævede felter")]
		[Display(Name = "Tlf. Nummer")]
		[DataType(DataType.PhoneNumber)]
		public string Phone { get; set; }
	}
}
