﻿using DataAccess.IRepository;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.LinQtoSQLRepository
{
    internal class DatabaseRepository : IDatabasesRepository
    {
        private readonly ApplicationDbContext _context;
        public DatabaseRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task<int> Add(Database entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Database> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetByConnectionString(string ConnectionString)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetByDatabaseType(int DatabaseTypeId)
        {
            throw new NotImplementedException();
        }

        public Task<Database> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Database>> GetByUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Database entity)
        {
            throw new NotImplementedException();
        }
    }
}
