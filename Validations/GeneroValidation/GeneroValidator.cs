using APIClothingMAYIOZ.Model;
using FluentValidation;

namespace APIClothingMAYIOZ.Validations.GeneroValidation
{
    public class GeneroValidator : AbstractValidator<Genero>
    {
        public GeneroValidator()
        {
            RuleFor(g => g.NombreGenero)
                .NotEmpty().WithMessage("El nombre del género no puede estar vacío.")
                .MaximumLength(50).WithMessage("El nombre del género no puede exceder los 50 caracteres.");
        }
    }
}
