using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using AutoMapper;

namespace APIClothingMAYIOZ.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<Producto, ProductoDetalleDTO>()
                .ForMember(dest => dest.Marca, opt => opt.MapFrom(src => src.Marca.NombreMarca))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero.NombreGenero))
                .ForMember(dest => dest.Talle, opt => opt.MapFrom(src => src.Talle.NombreTalle));
        }
    }
}
