using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Lookup: BaseEntity
    {
        public int? ParentId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int GroupId { get; set; }
        public virtual Lookup ParentLookup { get; set; }
        public IEnumerable<Lookup> ChildLookups { get; set; }
    }
}
