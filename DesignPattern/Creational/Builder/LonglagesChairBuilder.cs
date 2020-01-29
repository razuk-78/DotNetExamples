using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LonglagesChairBuilder : IChairBuilder
    {
        Chair _chair;
        public LonglagesChairBuilder()
        {
            this.Reset();
        }
       public Chair GetChair()
        {
            this.Reset();
            return _chair;
        }
        
        public void Reset()
        {
            _chair = new Chair();
        }
        public void CreateBack()
        {
           _chair.Back = new Chairback {Height=10,Shape="round",width=20 };
        }
        public void CreateLage()
        {
           var leg= new ChairLeg { Height = 30, width = 5, Shape = "round" };
            _chair.Lages=new List<ChairLeg>
            {
                leg,
                leg.Clone(),
                leg.Clone(),
                leg.Clone()
               
            };
        }
        public void CreateSit()
        {
            _chair.Sit = new ChairSit { length=30, Shape="round",width=30};
        }


    }
}
