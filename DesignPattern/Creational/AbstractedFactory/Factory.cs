using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
   public class FurentureFactor : IFactory

    {
        IProduct _product;
       public FurentureFactor(IProduct product)
        {
            _product = product;
        }
        
        public IProduct CreateProduct()
        {
            return _product;
        }
    }


}
