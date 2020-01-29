using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Client
    {
        FurntureFactory chair = new ChairFactory();
        FurntureFactory sofa = new SofaFactory();
        public Client()
        {
                          
        }
        public void printSofa()
        {
            Console.WriteLine(sofa.CreateProduct().GetName());
        }
        public void printChair()
        {
            Console.WriteLine(chair.CreateProduct().GetName());
        }
        public void Main()
        {
            this.printChair();
            this.printSofa();
        }
    }
}
