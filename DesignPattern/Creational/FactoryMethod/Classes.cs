using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.FactoryMethod
{
    interface IProduct
    {
        void doSomeStuf();
    }
    class ProductA : IProduct
    {
        public void doSomeStuf()
        {
            throw new NotImplementedException();
        }
    }
    abstract class ProductCreator
    {
      public abstract IProduct CreateProduct();
        public void someOperation()
        {
            CreateProduct().doSomeStuf();
        }
    }
    class ProductACreator : ProductCreator
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    class Client
    {
        public void SomOperation(ProductACreator creator)
        {
            creator.someOperation();
        }
        public void Main()
        {
            SomOperation(new ProductACreator());
        }
    }

}
