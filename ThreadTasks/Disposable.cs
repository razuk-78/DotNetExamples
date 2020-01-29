using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Disposable : IDisposable
    {
        ~Disposable()
        {
            this.Dispose(false);
            
        }
        public void Dispose(bool disposing)
        {
            if(disposing)
            Console.WriteLine("releasing resources from dispose");
            else
            {
               Console.WriteLine("releasing resources from finalze");
            }
        }
            public void Dispose()
        {

            this.Dispose(true);
            GC.SuppressFinalize(this);
            
        }
    }

