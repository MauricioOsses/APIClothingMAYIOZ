using APIClothingMAYIOZ.Model;
using FluentValidation;

namespace APIClothingMAYIOZ.Validations.TalleValidation
{
    public class TalleValidator : AbstractValidator<Talle>
    {
        public TalleValidator()
        {
            RuleFor(t => t.NombreTalle)
                .NotEmpty().WithMessage("El nombre del talle no puede estar vacío.")
                .MaximumLength(10).WithMessage("El nombre del talle no puede exceder los 10 caracteres.");
        }
    }
}
