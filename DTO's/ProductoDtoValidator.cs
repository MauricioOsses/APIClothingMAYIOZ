using FluentValidation;

namespace APIClothingMAYIOZ.DTO_s
{
    public class ProductoDtoValidator : AbstractValidator<ProductoDTO>
    {
        public ProductoDtoValidator()
        {
            RuleFor(p => p.Nombre).NotEmpty().WithMessage("El nombre es obligatorio!").MaximumLength(100).WithMessage("El nombre no puede ser de mas de 100 caracteres!");
            
            RuleFor(p => p.IdMarca).GreaterThan(0).WithMessage("Debe seleccionar una marca valida!");

            RuleFor(p => p.IdGenero).GreaterThan(0).WithMessage("Debe seleccionar un genero valido!");

            RuleFor(p => p.IdTalle).GreaterThan(0).WithMessage("Debe seleccionar un talle valido!");

            RuleFor(p => p.Precio).GreaterThan(0).WithMessage("Debe seleccionar un precio valido!");
          
        }
    }
}
