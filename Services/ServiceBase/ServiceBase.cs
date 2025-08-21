using APIClothingMAYIOZ.Repositories.InterfazRepository;

namespace APIClothingMAYIOZ.Services.IServiceBase
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<T>> GetAll() => _repository.GetAll();
        public Task<T?> GetById(int id) => _repository.GetById(id);
        public Task Create(T entity) => _repository.Add(entity);
        public Task Update(T entity) => _repository.Update(entity);
        public Task Delete(int id) => _repository.Delete(id);
    }
}
