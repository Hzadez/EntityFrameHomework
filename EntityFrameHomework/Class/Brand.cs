using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameHomework.Class
{
    public class Brand : BaseEntity
    {
        public List<Brand> Brands { get; set; }
        public override string ToString()
        {
            return ($"Id {Id} -- Name {Name}");
        }
    }
}
