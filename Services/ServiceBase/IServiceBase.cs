using APIClothingMAYIOZ.Model;

namespace APIClothingMAYIOZ.Services.IServiceBase
{
    public interface IServiceBase<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int id);
        public Task Create(T producto);
        public Task Update(T producto);
        public Task Delete(int id);
    }
}
