using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameHomework.Class
{
    public class Color : BaseEntity
    {
        public override string ToString()
        {
            return ($"Id {Id} -- Name {Name}");
        }
    }
}
