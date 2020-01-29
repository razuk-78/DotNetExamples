using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.ChainOfResponsibilty
{
    //EventHandler style
    public delegate void EventHandler(object sender, EventArgs e);
    public class MyEventArgs : EventArgs
    {
        public object obj;
    }
   public class HandlerRoaming
    {
        public static event EventHandler MyEventHandler;

        public static void OnRequestHappend(object sender, MyEventArgs e)
        {
            MyEventHandler(sender, e);
        }
    }
    public class HttpApp
    {
        public string redirect;
        public void ReceiveRequest(string path)
        {
            HandlerRoaming.OnRequestHappend(this, new MyEventArgs() { obj = path });
        }
        public void SendAnswer()
        {
            HandlerRoaming.OnRequestHappend(this, new MyEventArgs() { obj = "some answer" });
        }
    }
    public class client
    {
        public static void Run()
        {
            using (var chk = new Check()) { 
            new HttpApp().ReceiveRequest("/blog");
            new HttpApp().SendAnswer();
}
        }
    }
    public class Check:IDisposable
    {
        
        public Check()
        {
            HandlerRoaming.MyEventHandler += OnEventHappend;
        }
        public void OnEventHappend(Object sender, object data)
        {
            this.Validate(sender, data);
            this.Authenticate(sender, data);
            this.Authorize(sender, data);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public void Validate(object sender, object data)
        {
            HttpApp app = (HttpApp)sender;
            app.redirect = "to some thing";
            
        }
        public void Authenticate(object sender, object data)
        {

        }
        public void Authorize(object sender, object data)
        {

        }

        public void Dispose()
        {
            HandlerRoaming.MyEventHandler -= OnEventHappend;
        }
    }
   
}
