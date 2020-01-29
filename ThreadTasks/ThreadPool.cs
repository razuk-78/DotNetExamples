using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
namespace ThreadTasks
{
    class ThreadPoolExample
    {
        public static void Run()
        {
            ConcurrentBag<int> bg = new ConcurrentBag<int>();
            ThreadPool.SetMaxThreads(12, 9);
            for (int i = 0; i < 20; i++)
            {
                ThreadPool.QueueUserWorkItem((a) => {

                    bg.Add(Thread.CurrentThread.ManagedThreadId);
                });
            }


            Thread.Sleep(1000);
            foreach (var item in bg.Distinct())
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
