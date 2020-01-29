using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

    class CancellationTokenExample
    {
        public static void Run()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;

            Task t;

            t = Task.Run(() => {
                Task.Run(() => {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("something");
                    }
                });
                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }
                    
                }

            }, token);
            Console.WriteLine("Task {0} executing", t.Id);
            Thread.Sleep(3000);
            tokenSource.Cancel();
            Thread.Sleep(5000);
            // the status must be canceld
            Console.WriteLine(t.Status);
            Console.ReadLine();
        }
    }

