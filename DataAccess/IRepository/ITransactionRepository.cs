using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    internal interface ITransactionRepository: IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetBySourceDatabase(int SourceDatabaseId);
        Task<IEnumerable<Transaction>> GetByTargetDatabase(int TargetDatabaseId);
        Task<IEnumerable<Transaction>> GetByUser(int UserId);
        Task<IEnumerable<Transaction>> GetAllQueried();
    }
}
