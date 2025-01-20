using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User: BaseEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public bool IsSuperAdmin { get; set; }
        public IEnumerable<Database> Databases { get; set; }
        public IEnumerable<Logging> Loggings { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}
