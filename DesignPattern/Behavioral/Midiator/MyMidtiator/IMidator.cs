using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Midiator.MyMidtiator
{
    interface IMediator
    {
        void NotifySender(object sender);
    }
    class Mediator : IMediator
    {
        Component _cmpA; Component _cmpB; Component _cmpC;
        public Mediator(Component a, Component b, Component c)
        {
          _cmpA=a; 
         _cmpB = b; 
         _cmpC= c;
         _cmpA.setMediator(this);
            _cmpB.setMediator(this);
            _cmpC.setMediator(this);
        } 
        public void NotifySender(object sender)
        {
            if (sender.GetHashCode().Equals(_cmpA.GetHashCode()))
            {
                ReactOnA();
            }
            else if (sender.Equals(_cmpB))
            {
                ReactOnB();
            }
            else if (sender.Equals(_cmpC))
            {
                ReactOnC();
            }
        }

        private void ReactOnC()
        {
            Console.WriteLine("from C");
        }

        private void ReactOnB()
        {
            Console.WriteLine("from B");
        }

        public void ReactOnA()
        {
            Console.WriteLine("from A");
        }
    }
    abstract class  Component 
    {
        IMediator _mediator;
        public Component()
        {
            
        }
  
        public void Operation()
        {
            _mediator.NotifySender(this);
        }
        public void setMediator(IMediator m)
        {
            _mediator = m;
        }
    }
    class compA : Component
    {
   
    }
    class compB: Component
    {
   
    }
    class compC : Component
    {

    }

    class client
    {
        public static void Run()
        {
            var compA = new compA();
            var compB = new compA();
            var compC = new compA();
            Mediator m = new Mediator(compA, compB, compC);
            compA.Operation();
            compB.Operation();
            compC.Operation();
            Console.Read();
        }
        
    }
}
