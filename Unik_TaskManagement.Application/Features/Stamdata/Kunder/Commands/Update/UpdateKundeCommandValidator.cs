using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.Update
{
    public class UpdateKundeCommandValidator: AbstractValidator<UpdateKundeCommand>
    {
        public UpdateKundeCommandValidator ( )
        {
            RuleFor(kunde => kunde.FullName).NotNull( ).Length(3, 100).NotEmpty();
            RuleFor(kunde => kunde.Email).EmailAddress( ).NotEmpty( ).NotNull( );
            RuleFor(kunde => kunde.Phone).NotNull( ).NotEmpty( ).WithMessage("Pleease Provid A tlf.");
        }
    }
}
