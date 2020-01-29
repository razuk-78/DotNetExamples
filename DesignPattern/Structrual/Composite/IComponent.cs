using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IComponent
    {
        void excute();
        void Add(IComponent comp);
        void Remove(IComponent comp);
        IEnumerable<IComponent> GetChildren();
         void AcceptVisitor(IVisitor visitor);
        bool IsComposite();
    }
}
