using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;

namespace BusinessLogic.Managers
{
    internal interface ILoggingManager : IManager<Logging>
    {
        Task<IEnumerable<Logging>> GetAllQueried();
    }
}
