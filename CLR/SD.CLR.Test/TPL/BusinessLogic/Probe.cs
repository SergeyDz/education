using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL.BusinessLogic
{
    class Probe
    {
        private readonly string name;
        private readonly CancellationToken token;
        private int N = 5;

        public Probe(string probeName, CancellationToken cancelationToken)
        {
            name = probeName;
            token = cancelationToken;
        }

        public void Run()
        {
            Console.WriteLine("Thread: {0}.   | Probe: {1}.", Thread.CurrentThread.ManagedThreadId, name);
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Thread: {1}.   | i={0}, Probe={2}", i, Thread.CurrentThread.ManagedThreadId, name);
                ProbeWebClient client = new ProbeWebClient();
                client.GetProbe();
            }
        }


        public async Task RunAsync(string url = "http://www.google.com")
        {
            for (int i = 0; i < N; i++)
            {
                token.ThrowIfCancellationRequested(); 
                Console.WriteLine("Thread: {0}. i={1}.", Thread.CurrentThread.ManagedThreadId, i);
                token.WaitHandle.WaitOne(10);
                ProbeWebClient client = new ProbeWebClient();
                await client.GetProbeAsync(url);
            }
        }
    }
}
