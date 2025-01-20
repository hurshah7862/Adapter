using DataAccess.IRepository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.LinQtoSQLRepository
{
    internal class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;
        public TransactionRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

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
