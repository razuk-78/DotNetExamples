using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibilty.Main
{
    public interface IHandler
    {
        Object Handle(object request);
        IHandler setNextHandler(IHandler h);
    }
    public class BaseHandler : IHandler
    {
        IHandler _handler;
        public virtual object Handle(object request)
        {
            if (_handler != null)
            {
                return _handler.Handle(request);
            }
            return null;
        }

        public IHandler setNextHandler(IHandler h)
        {
            return _handler = h;
        }
    }
    public class ValidateA : BaseHandler
    {
        public override object Handle(object request)
        {
            if ((string)request == "A")
            {
                return null;
            }
            return base.Handle(request);
        }
    }
    public class ValidateB : BaseHandler
    {
        public override object Handle(object request)
        {
            if ((string)request == "B")
            {
                return null;
            }
            return base.Handle(request);
        }
    }
    public class ValidateC : BaseHandler
    {
        public override object Handle(object request)
        {
            if ((string)request == "C")
            {
                return null;
            }
            return base.Handle(request);
        }
    }
    class HttpApp
    {
        BaseHandler ValA = new ValidateA();
        BaseHandler ValB = new ValidateB();
        BaseHandler ValC = new ValidateC();
        public void Request(string path)
        {
            ValA.setNextHandler(ValB).setNextHandler(ValC);
            ValA.Handle(path);
        }
    }
    class Client
    {
        public static void Run(){
            new HttpApp().Request("C");
        }
}
}
