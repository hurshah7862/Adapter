using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    internal interface IDatabaseTypeRepository: IRepository<DatabaseType>
    {
        Task<IEnumerable<DatabaseType>> GetByType(int TypeId);
        Task<DatabaseType> GetByName(string Name);
        Task<IEnumerable<DatabaseType>> GetAllQueried();
    }
}
