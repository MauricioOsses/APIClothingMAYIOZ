using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories.GeneroRepository;
using APIClothingMAYIOZ.Services.IServiceBase;

namespace APIClothingMAYIOZ.Services.ServiceGenero
{
    public class GeneroService: ServiceBase<Genero>, IGeneroService
    {
        public GeneroService(IGeneroRepository repo): base(repo) { }
    }
}
