using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Managers
{
    internal class LoggingManager : ILoggingManager
    {
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
