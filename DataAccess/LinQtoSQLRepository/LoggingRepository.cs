using DataAccess.IRepository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.LinQtoSQLRepository
{
    internal class LoggingRepository : ILoggingRepository
    {
        private readonly ApplicationDbContext _context;
        public LoggingRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task<int> Add(Logging entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Logging> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Logging>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Logging>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Logging entity)
        {
            throw new NotImplementedException();
        }
    }
}
