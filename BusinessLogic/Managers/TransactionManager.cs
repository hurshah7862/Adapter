using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Managers
{
    internal class TransactionManager : ITransactionManager
    {
        public Task<int> Add(Transaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetBySourceDatabase(int SourceDatabaseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetByTargetDatabase(int TargetDatabaseId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetByUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
