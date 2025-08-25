using APIClothingMAYIOZ.DTO_s;
using FluentValidation;

namespace APIClothingMAYIOZ.Validations.ProductoValidation
{
    public class ProductoDtoValidator : AbstractValidator<ProductoDTO>
    {
        public ProductoDtoValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("El nombre es obligatorio!").MaximumLength(100).WithMessage("El nombre no puede ser de mas de 100 caracteres!");
            
            RuleFor(p => p.IdMarca).NotNull().WithMessage("Debe seleccionar una marca").GreaterThan(0).WithMessage("Debe seleccionar una marca valida!");

            RuleFor(p => p.IdGenero).NotNull().WithMessage("Debe seleccionar un genero").GreaterThan(0).WithMessage("Debe seleccionar un genero valido!");

            RuleFor(p => p.IdTalle).NotNull().WithMessage("Debe seleccionar un talle").GreaterThan(0).WithMessage("Debe seleccionar un talle valido!");

            RuleFor(p => p.Precio).NotNull().WithMessage("Debe ingresar un precio").GreaterThan(0).WithMessage("El precio debe ser mayor a 0");
        }
    }
}
