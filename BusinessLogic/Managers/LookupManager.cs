using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Managers
{
    internal class LookupManager : ILookupManager
    {
        public Task<int> Add(Lookup entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Lookup> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lookup>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lookup>> GetAllQueried()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lookup>> GetByGroup(int GroupId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Lookup>> GetByParent(int ParentId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Lookup entity)
        {
            throw new NotImplementedException();
        }
    }
}
