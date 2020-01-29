using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    class Prototype : ICloneable
    {
        int _id;
        string _name;
        public Prototype(int id, string name)
        {
            _id = id;_name = name;
        }
        public object Clone()
        {
           return new Prototype(this._id,this._name) { 
               
           };
        }
    }
}
