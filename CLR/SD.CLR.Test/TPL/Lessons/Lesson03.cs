using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL.Lessons
{
    class Lesson03
    {
        public async Task Execute()
        {
            Console.WriteLine("Thread: {0}. Main.", Thread.CurrentThread.ManagedThreadId);

            WebClient client = new WebClient();
            Task<string> task = client.DownloadStringTaskAsync("http://www.google.com");


            Lazy<Task<string>> google = new Lazy<Task<string>>(() => task);

            Console.WriteLine("Call result: {0}", google.Value.Result.Substring(0, 2000));
        }
    }
}
