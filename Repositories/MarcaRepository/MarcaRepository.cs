using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.Model;

namespace APIClothingMAYIOZ.Repositories.MarcaRepository
{
    public class MarcaRepository : RepositoryBase<Marca>, IMarcaRepository
    {
        public MarcaRepository(ClothingDbContext context) : base(context) 
        {
        }
    }
}
