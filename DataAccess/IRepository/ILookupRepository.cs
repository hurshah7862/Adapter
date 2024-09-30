using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    internal interface ILookupRepository: IRepository<Lookup>
    {
        Task<IEnumerable<Lookup>> GetByGroup(int GroupId);
        Task<IEnumerable<Lookup>> GetByParent(int ParentId);
        Task<IEnumerable<Lookup>> GetAllQueried();
    }
}
