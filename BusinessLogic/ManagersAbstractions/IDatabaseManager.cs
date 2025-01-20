using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;

namespace BusinessLogic.Managers
{
    internal interface IDatabasesManager : IManager<Database>
    {
        Task<IEnumerable<Database>> GetByUser(int UserId);
        Task<IEnumerable<Database>> GetByDatabaseType(int DatabaseTypeId);
        Task<Database> GetByName(string Name);
        Task<IEnumerable<Database>> GetByConnectionString(string ConnectionString);
        Task<IEnumerable<Database>> GetAllQueried();
    }
}
