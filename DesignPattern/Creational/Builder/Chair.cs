using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Chair
    {
        public List<ChairLeg> Lages { get; set; }
        public Chairback Back { get; set; }
        public ChairSit Sit { get; set; }
    }
}
