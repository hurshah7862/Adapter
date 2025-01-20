using DataAccess.IRepository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.LinQtoSQLRepository
{
    internal class DatabaseTypeRepository : IDatabaseTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public DatabaseTypeRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task<int> Add(DatabaseType entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseType> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DatabaseType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DatabaseType>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<DatabaseType> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DatabaseType>> GetByType(int TypeId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(DatabaseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
