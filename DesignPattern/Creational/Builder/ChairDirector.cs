using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ChairDirector
    {
        IChairBuilder _builder;
        public ChairDirector(IChairBuilder builder)
        {
             _builder = builder;
        }
        public void Main()
        {
            _builder.CreateSit();
            _builder.CreateLage();
            _builder.CreateBack();

        }
    }
}
