using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IUserRepository: IRepository<User>
    {
        Task<IEnumerable<User>> GetByType(bool IsSuperAdmin);
        Task<User> GetByEmail(string Email);
        Task<User> GetByUsername(string Username);
        Task<User> GetByMobile(string Mobile);
        Task<IEnumerable<User>> GetAllQueried();
    }
}
