using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteA : IImpementation
    {
        public void MethodA()
        {
            throw new NotImplementedException();
        }

        public void MethodB()
        {
            throw new NotImplementedException();
        }

        public void MethodC()
        {
            throw new NotImplementedException();
        }

        public void MethodD()
        {
            throw new NotImplementedException();
        }
    }
    class ConcreteB : IImpementation
    {
        public void MethodA()
        {
            throw new NotImplementedException();
        }

        public void MethodB()
        {
            throw new NotImplementedException();
        }

        public void MethodC()
        {
            throw new NotImplementedException();
        }

        public void MethodD()
        {
            throw new NotImplementedException();
        }
    }
}
