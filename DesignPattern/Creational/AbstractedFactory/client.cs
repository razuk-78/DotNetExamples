using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    class Client
    {
        IFactory _factory;
        public Client(IFactory factory)
        {
            _factory = factory;
        }
         public void PrintProduct()
        {
            Console.WriteLine(_factory.CreateProduct().GetName());
        }

    }
}
