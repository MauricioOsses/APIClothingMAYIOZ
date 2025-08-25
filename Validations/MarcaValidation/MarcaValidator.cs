using APIClothingMAYIOZ.Model;
using FluentValidation;

namespace APIClothingMAYIOZ.Validations.MarcaValidation
{
    public class MarcaValidator : AbstractValidator<Marca>
    {
        public MarcaValidator()
        {
            RuleFor(m => m.NombreMarca)
                .NotEmpty().WithMessage("El nombre de la marca no puede estar vacío.")
                .MaximumLength(100).WithMessage("El nombre de la marca no puede exceder los 100 caracteres.");
        }
    }
}
