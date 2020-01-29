using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IVisitor
    {
        void VisitRectangle(Rectangle comp);
        void VisitCircle(Circle comp);
        void VisitText(Text comp);
    }
}
