using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Database: BaseEntity
    {
        public string Name { get; set; }
        public int DatabaseTypeId { get; set; }
        public string ConnectionString { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual DatabaseType DatabaseType { get; set; }
        public IEnumerable<Transaction> TransactionsAsSource { get; set; }
        public IEnumerable<Transaction> TransactionsAsTarget { get; set; }


    }
}
