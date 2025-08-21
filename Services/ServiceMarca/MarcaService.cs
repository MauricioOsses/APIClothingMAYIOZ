using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories.MarcaRepository;
using APIClothingMAYIOZ.Services.IServiceBase;

namespace APIClothingMAYIOZ.Services.ServiceMarca
{
    public class MarcaService: ServiceBase<Marca>, IMarcaService
    {
        public MarcaService(IMarcaRepository repo): base(repo) { }
    }
}
