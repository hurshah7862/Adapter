

namespace BusinessLogic.ManagersAbstractions
{
    public interface IManager<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(int id);
    }
}
