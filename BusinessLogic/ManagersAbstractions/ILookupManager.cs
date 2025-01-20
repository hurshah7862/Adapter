using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;

namespace BusinessLogic.Managers
{
    internal interface ILookupManager : IManager<Lookup>
    {
        Task<IEnumerable<Lookup>> GetByGroup(int GroupId);
        Task<IEnumerable<Lookup>> GetByParent(int ParentId);
        Task<IEnumerable<Lookup>> GetAllQueried();
    }
}
