using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class Transaction: BaseEntity
    {
        public int SourceDatabaseId { get; set; }
        public int? TargetDatabaseId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Database SourceDatabase { get; set; }
        public virtual Database TargetDatabase { get; set; }
    }
}
