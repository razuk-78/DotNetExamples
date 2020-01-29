using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
   abstract class  Composite : IComponent
    {
        List<IComponent> _children;
        
        public Composite(string name)
        {
            if(this.IsComposite())
            _children = new List<IComponent>();
        }
        public IEnumerable<IComponent> GetChildren()
        {
            return _children;
        }
        public void Remove(IComponent comp)
        {
            _children.Remove(comp);
        }
        public void Add(IComponent comp)
        {
            _children.Add(comp);
        }
        public virtual void excute()
        {        if (this.IsComposite())
            {
            Console.Write(this.ToString()+"->");
            }
            else
            {
                Console.Write(this.ToString());
            }
           
        }
        public virtual bool IsComposite()
        {
            return true;
        }

        public virtual void AcceptVisitor(IVisitor visitor)
        {
            if (this.IsComposite())
                foreach (var item in _children)
                    item.AcceptVisitor(visitor);
        }
     
    }

    class Circle:Composite
    {
        public Circle():base("circle")
        {

        }

        public override void AcceptVisitor(IVisitor visitor)
        {    visitor.VisitCircle(this);
            base.AcceptVisitor(visitor);
            
        }
    }
    class Rectangle : Composite
    {
        public Rectangle() : base("rectangle")
        {

        }

        public override void AcceptVisitor(IVisitor visitor)
        {  visitor.VisitRectangle(this);
            base.AcceptVisitor(visitor);
            
        }
    }
    class Text : Composite
    {
        public Text() : base("rectangle")
        {

        }

        public override void AcceptVisitor(IVisitor visitor)
        {   visitor.VisitText(this);
            base.AcceptVisitor(visitor);
            
        }
        public override bool IsComposite()
        {
            return  false;
                
          
        }

    }
}
