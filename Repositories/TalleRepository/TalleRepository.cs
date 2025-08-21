using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.Model;

namespace APIClothingMAYIOZ.Repositories.TalleRepository
{
    public class TalleRepository : RepositoryBase<Talle>, ITalleRepository
    {
        public TalleRepository(ClothingDbContext context) : base(context)
        {
        }
    }
}
