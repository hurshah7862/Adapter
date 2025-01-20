using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    internal interface IDatabasesRepository: IRepository<Database>
    {
        Task<IEnumerable<Database>> GetByUser(int UserId);
        Task<IEnumerable<Database>> GetByDatabaseType(int DatabaseTypeId);
        Task<Database> GetByName(string Name);
        Task<IEnumerable<Database>> GetByConnectionString(string ConnectionString);
        Task<IEnumerable<Database>> GetAllQueried();
    }
}
