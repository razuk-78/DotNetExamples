using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structrual.Adapter
{
    interface IEmailAdapter
    {
        void SendMessage(Tuple<string, string> SenderReciever);
    }
    class Gmail
    {
        public void SendMessage(string sender, string reciever)
        {

        }
    }
    class EmailService : IEmailAdapter
    {
        
        public void SendMessage(Tuple<string,string> SenderReciever)
        {
            new Gmail().SendMessage(SenderReciever.Item1, SenderReciever.Item2);
        }
    }
    class Client
    {
        EmailService email;
        public void sendMessage()
        {
            email.SendMessage(new Tuple<string, string>("some sender","some receiver"));
        }
    }
}
