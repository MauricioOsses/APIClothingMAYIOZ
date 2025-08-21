using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories.TalleRepository;
using APIClothingMAYIOZ.Services.IServiceBase;

namespace APIClothingMAYIOZ.Services.ServiceTalle
{
    public class TalleService : ServiceBase<Talle>, ITalleService
    {
        public TalleService(ITalleRepository repo) : base(repo)
        {

        }
    }
}
