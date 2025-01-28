using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameHomework.Class
{
    public class Car
    {
        public int Id { get; set; }
        public int Maxspeed { get; set; }
        public double Fueltank { get; set; }
        public int Power { get; set; }
        public int Doorcount { get; set; }
        public Model Model { get; set; }

        public override string ToString()
        {
            return ($"Id {Id} -- Maxspeed {Maxspeed} -- Fueltank {Fueltank} -- Power {Power} -- Doorcount {Doorcount}");
        }

    }
}
