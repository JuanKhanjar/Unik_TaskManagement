using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Domain
{
    public class Kunde
    {
        [Key]
        public Guid KundeId { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage = "Udfyld venligst de påkrævede felter")]
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
        public IReadOnlyCollection<Project>? KundeProjects { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
