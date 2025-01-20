using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;

namespace BusinessLogic.Managers
{
    public interface IUserManager: IManager<User>
    {
        Task<IEnumerable<User>> GetByType(bool IsSuperAdmin);
        Task<User> GetByEmail(string Email);
        Task<User> GetByUsername(string Username);
        Task<User> GetByMobile(string Mobile);
        Task<IEnumerable<User>> GetAllQueried();
    }
}
