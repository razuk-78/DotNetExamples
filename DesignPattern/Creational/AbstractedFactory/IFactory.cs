using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    interface IFactory
    {
        IProduct CreateProduct();
    }
}
