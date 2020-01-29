using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Abstraction

    {
        public IImpementation _implementation;
        public Abstraction(IImpementation impl)
        {
            this._implementation = impl;
        }
        public virtual void Feature1()
        {
            this._implementation.MethodA();
            this._implementation.MethodB();
        }
        public virtual void Feature2()
        {
            this._implementation.MethodC();
        }
    }
}
