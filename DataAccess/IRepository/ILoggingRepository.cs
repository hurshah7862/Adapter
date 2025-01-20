using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    internal interface ILoggingRepository: IRepository<Logging>
    {
        Task<IEnumerable<Logging>> GetAllQueried();
    }
}
