using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Unik_TaskManagement.Application.Features.Stamdata.Kunder.Commands.AddNew
{
    public class CreateKundeCommandValidator : AbstractValidator<CreateKundeCommand>
    {
        public CreateKundeCommandValidator ( )
        {
            RuleFor(k => k.FullName)
                .NotEmpty( )
                .NotNull( )
                .Length(3, 100);

            RuleFor(k => k.Email).NotEmpty( ).WithMessage("Email address is required")
                     .EmailAddress( ).WithMessage("A valid email is required");
            RuleFor(k => k.Phone)
            .NotEmpty( )
           .NotNull( ).WithMessage("Phone Number is required.");
            //.MinimumLength(10).WithMessage("PhoneNumber must not be less than 10 characters.")
            //.MaximumLength(20).WithMessage("PhoneNumber must not exceed 50 characters.")
            //.Matches(new Regex(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")).WithMessage("PhoneNumber not valid");
        }
    }
}
