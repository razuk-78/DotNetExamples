using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// using abstract class, because there is some common/default,
    /// function that subclasses  are going to use
    /// </summary>
    abstract class  FurntureFactory
    {
       public abstract IProduct CreateProduct();
        public void DoSomeThing()
        {
            Console.WriteLine("some thing to do");
        }
    }

    class SofaFactory : FurntureFactory
    {
        public override IProduct CreateProduct()
        {
            return new Sofa();
        }
    }
    class ChairFactory : FurntureFactory
    {
        public override IProduct CreateProduct()
        {
            return new Chair();
        }
    }
}
