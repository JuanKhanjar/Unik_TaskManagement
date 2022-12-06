using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Unik_TaskManagement.web.Models.MedarbejdeModels
{
	public class MedarbejderDto
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
