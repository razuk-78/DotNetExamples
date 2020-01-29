using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Chair : IProduct
    {
    
        public string GetName()
        {
            return "i am chair";
        }
    }
    class Sofa : IProduct
    {
        public string GetName()
        {
            return "i am sofa";
        }
    }
}
