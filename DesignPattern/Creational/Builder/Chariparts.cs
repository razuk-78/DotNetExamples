using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ChairLeg
    {
        public string Shape { get; set; }
        public int Height { get; set; }
        public int width { get; set; }
        public ChairLeg Clone()
        {

            return new ChairLeg
            {
                Height = this.Height,
                Shape = this.Shape,
                width = this.width
            };
        }
    }
    class ChairSit
    {
        public string Shape { get; set; }
        public int length { get; set; }
        public int width { get; set; }
    }
    class Chairback
    {
        public string Shape { get; set; }
        public int Height { get; set; }
        public int width { get; set; }
    }
}
