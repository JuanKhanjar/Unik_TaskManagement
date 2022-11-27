using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Domain
{
    public class Booking
    {
        public Booking ( Guid bookId, Guid projectId,Guid opgaveId,
             Guid medarbejdeId,DateTime startDate, DateTime endDate)
        {
            BookId = bookId;
            ProjectId = projectId;
            MedarbejdeId = medarbejdeId;
            StartDate = startDate;
            EndDate = endDate;
            Duration = BusinessDaysLeft(startDate,endDate);
        }

        [Key]
        public Guid BookId { get; set; }

        public Guid ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        public Guid OpgaveId { get; set; }
        [ForeignKey("OpgaveId")]
        public Opgave Opgave { get; set; }

        public Guid MedarbejdeId { get; set; }
        [ForeignKey("MedarbejdeId")]
        public Medarbejde Medarbejde { get; set; }

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
        public double Duration { get; set; }
        private int BusinessDaysLeft ( DateTime first, DateTime last )
        {
            var count = 0;

            while (first.Date != last.Date)
            {
                if (first.DayOfWeek != DayOfWeek.Saturday && first.DayOfWeek != DayOfWeek.Sunday)
                    count++;

                first = first.AddDays(1);
            }

            return count;
        }

    }
}
