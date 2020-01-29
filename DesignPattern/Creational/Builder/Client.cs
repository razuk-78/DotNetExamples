using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Client
    {

        LonglagesChairBuilder _LongChair;
        ChairDirector _chairDirector;
        public Client()
        {
            _LongChair     = new LonglagesChairBuilder();
            _chairDirector = new ChairDirector(_LongChair);
        }
        public Chair GetChair()
        {
            _chairDirector.Main();
            var chair = _LongChair.GetChair();
           foreach(var pro in chair.GetType().GetProperties())
            {
                Console.WriteLine($"{pro.Name}: {chair.GetType().GetProperty(pro.Name)}");
            }
            return chair;
        }
    }
}
