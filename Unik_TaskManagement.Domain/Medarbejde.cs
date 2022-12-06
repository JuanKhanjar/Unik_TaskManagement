using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Domain
{
    public class Medarbejde
    {
        [Key]
        public Guid MedarbejdeId { get; set; }

        [Required ( AllowEmptyStrings = false, ErrorMessage = "Udfyld venligst de påkrævede felter" )]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required,Display(Name = "Email Address"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Display(Name = "Tlf. nummer"), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        public JobeType Job { get; set; }
        public IReadOnlyCollection<Skill>? Skilles { get; set; }
    }
    public enum JobeType
    {
        Technical,
        Converter,
        Consultanat
    }
}
