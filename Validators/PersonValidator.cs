using FluentAPIAndValidation.Core.Domain;
using FluentValidation;

namespace FLuentAPIAndValidation.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().MaximumLength(30).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
            RuleFor(e => e.LastName).NotEmpty().MaximumLength(30).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        }

    }
}