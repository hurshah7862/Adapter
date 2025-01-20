using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class DatabaseType: BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        public IEnumerable<Database> Databases { get; set; }
    }
}
