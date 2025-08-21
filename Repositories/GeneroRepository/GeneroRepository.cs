using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.Model;
using Microsoft.EntityFrameworkCore;

namespace APIClothingMAYIOZ.Repositories.GeneroRepository
{
    public class GeneroRepository : RepositoryBase<Genero>, IGeneroRepository
    {
        public GeneroRepository(ClothingDbContext context): base(context)
        {
        }
    }
}
