using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DesignPattern.Structrual.Decorator.Atter
{
    interface IDataStream
    {
        void WriteToDisk(string data);
        string ReadFromDisk();

    }
    class DataStream : IDataStream
    {
        [return:DeCompress]
        public string ReadFromDisk()
        {
            return  "some data";
        }
        
        public void WriteToDisk([Compress] string  data)
        {
            Console.WriteLine(data);
        }
    }
    [System.AttributeUsage(System.AttributeTargets.Parameter)]
    class CompressAttribute : Attribute
    {
    
    }
    [System.AttributeUsage(System.AttributeTargets.ReturnValue)]
    class DeCompressAttribute : Attribute
    {

    }
    [System.AttributeUsage(System.AttributeTargets.Parameter)]
    class EncryptAttribute : Attribute
    {
   
    }
    [System.AttributeUsage(System.AttributeTargets.ReturnValue)]
    class DecryptAttribute : Attribute
    {

    }
    class ApplayDecoratorDataStream : IDataStream
    {
        DataStream _data = new DataStream();
        public string ReadFromDisk()
        {
         
               
            return "";
           
        }

        public void WriteToDisk(string data)
        {
          
            var m = _data.GetType().GetMethod("");
            if (m.GetParameters().
             First(e => e.GetCustomAttribute<CompressAttribute>() != null) != null)
            {    data += "<Compress>";
                string[] val = new string[1] { data };
                m.Invoke(_data, val);
            }
        }
    }

}
