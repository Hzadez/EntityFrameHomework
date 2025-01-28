using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameHomework.Class
{
    public class Model : BaseEntity
    {
        public Brand Brand { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }

        public override string ToString()
        {
            return ($"Id {Id} -- Name {Name}");
        }

    }
}
