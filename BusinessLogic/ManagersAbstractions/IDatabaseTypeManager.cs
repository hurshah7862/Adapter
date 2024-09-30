using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;

namespace BusinessLogic.Managers
{
    internal interface IDatabaseTypeManager : IManager<DatabaseType>
    {
        Task<IEnumerable<DatabaseType>> GetByType(int TypeId);
        Task<DatabaseType> GetByName(string Name);
        Task<IEnumerable<DatabaseType>> GetAllQueried();
    }
}
