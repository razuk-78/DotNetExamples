using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        IComponent _rect;
        IVisitor _visitor;
       public void CreateComponent()
        {
             _rect= new Rectangle();
            IComponent circle = new Circle();
            IComponent circlea = new Circle();
            IComponent circleb = new Circle();
            IComponent text = new Text();
            IComponent texta = new Text();
            IComponent textb = new Text();
            circle.Add(text);
            circlea.Add(texta);
            circle.Add(circlea);
            _rect.Add(circle);

        }
   public  void addVisitor()
        {
            _visitor = new Visitor();
            _rect.AcceptVisitor(_visitor);
        }
        public void Run()
        {
            CreateComponent();
            addVisitor();

        }
    }
}
