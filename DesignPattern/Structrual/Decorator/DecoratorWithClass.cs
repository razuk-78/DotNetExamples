using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual.Decorator
{
    interface IDataStream
    {
        void WriteToDisk(string data);
        string ReadFromDisk();
        
    }
    class DataStream : IDataStream
    {
        public string ReadFromDisk()
        {
            return Console.ReadLine();
        }

        public void WriteToDisk(string data)
        {
            Console.WriteLine(data);
        }
    }
    class DecoratDataStream : IDataStream
    {
       protected DataStream _data =new DataStream();
        public virtual string ReadFromDisk()
        {
            throw new NotImplementedException();
        }

        public virtual void WriteToDisk(string data)
        {
            throw new NotImplementedException();
        }
    }
    class CompressDecoratorData : DecoratDataStream
    {
       string compressBeforeWrite(string data)
        {
            return "<compressed>"+data + "</compressed>";
        }
        string DecompressData(string data)
        {
            return data.Replace("<compressed>", "").Replace("</compressed>", "");
        }
        public override string ReadFromDisk()
        {
            // add some behavior after data being reading from harddisk, which is decompress;
            var data = this.DecompressData(this._data.ReadFromDisk());
            return data;
        }

        public override void WriteToDisk(string data)
        {
            // add some behavior before data being writing to harddisk, which is compress;
            _data.WriteToDisk(this.compressBeforeWrite(data));
        }
    }
    class EncryptDecoratorData : DecoratDataStream
    {
        string EncryptBeforeWrite(string data)
        {
            return "<Encrypt>" + data + "</Encrypt>";
        }
        string DecryptData(string data)
        {
            return data.Replace("<Encrypt>", "").Replace("</Encrypt>", "");
        }
        public override string ReadFromDisk()
        {
            // add some behavior after data being reading from harddisk, which is DecryptData;
            var data = this.DecryptData(this._data.ReadFromDisk());
            return data;
        }

        public override void WriteToDisk(string data)
        {
            // add some behavior before data being writing to harddisk, which is EncryptBeforeWrite;
            _data.WriteToDisk(this.EncryptBeforeWrite(data));
        }
    }

}
