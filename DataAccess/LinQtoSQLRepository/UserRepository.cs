using DataAccess.IRepository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.LinQtoSQLRepository
{
    internal class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<int> Add(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _context.Users.FindAsync(id);
            if (entity != null)
            {
                _context.Users.Remove(entity);
                await _context.SaveChangesAsync();
                return entity.Id;
            }
            return 0;
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return _context.Users.AsQueryable();
        }

        public Task<IEnumerable<User>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByMobile(string Mobile)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetByType(bool IsSuperAdmin)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUsername(string Username)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
