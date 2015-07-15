using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL.BusinessLogic
{
    class ProbeWebClient
    {
        public void GetProbe()
        {
            Console.WriteLine("Thread: {0}.   | ProbeWebClient.GetProbe starting...", Thread.CurrentThread.ManagedThreadId);
            var client = new WebClient();
            string data = client.DownloadString("http://www.google.com");
            ProcessUserData(data, "http://www.google.com");
        }

        public async Task GetProbeAsync(string url)
        {
            Console.WriteLine("Thread: {0}.   | ProbeWebClient.GetProbe starting for {1}", Thread.CurrentThread.ManagedThreadId, url);
            string data = await this.RequestDataAsync(url);
            ProcessUserData(data, url);
        }

        private async Task<string> RequestDataAsync(string uri)
        {
            var client = new WebClient();
            return await client.DownloadStringTaskAsync(new Uri(uri));
        }

        private void ProcessUserData(string data, string url)
        { 
            Console.WriteLine("Thread: {1}.    | ProbeWebClient: Data read for {2} completed. Data length: {0}", data.Length, Thread.CurrentThread.ManagedThreadId, url);
        }
    }
}
