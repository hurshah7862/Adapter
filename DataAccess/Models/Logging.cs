using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Logging: BaseEntity
    {
        public string Route { get; set; }
        public int UserId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public virtual User User { get; set; }

    }
}
