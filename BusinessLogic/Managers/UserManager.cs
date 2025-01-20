using AutoMapper;
using BusinessLogic.Models;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Managers
{
    public class UserManager : IUserManager
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;
        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<int> Add(User entity)
        {
            return await _userRepository.Add(_mapper.Map<DataAccess.Models.User>(entity));
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return _mapper.Map<List<User>>((await _userRepository.GetAll()).ToList());
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
