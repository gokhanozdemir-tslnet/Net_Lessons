using FluentValidation;
using Lesson019_FluentValidation.Entities;

namespace Lesson019_FluentValidation.Validations
{
    public class PersonValidator:AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x=>x.Name)                
                .NotNull().WithMessage("xxName cannot be blank")
                .NotEmpty().WithMessage("xxxName cannot be blank")
                .MinimumLength(8).WithMessage("8 karakterden az olmamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("xxEmail cannot  be blank")
                .EmailAddress().WithMessage("xxEmail should be valid");
        }
    }
}
