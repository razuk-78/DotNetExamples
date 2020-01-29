using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Visitor : IVisitor
    {
        public void VisitCircle(Circle comp)
        {
            comp.excute();
        }

        public void VisitRectangle(Rectangle comp)
        {
            comp.excute();
        }

        public void VisitText(Text comp)
        {
            comp.excute();
        }
    }
}
