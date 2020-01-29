using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

public class Examples
{
    public static void Main()
    {
        MyScheduler m = new MyScheduler(5);
        Task t = new Task(() => {
            while (true)
                Console.WriteLine("iam alive");
        });
        t.Start();
        Thread.Sleep(1000);
        Console.ReadLine();
    }

}
