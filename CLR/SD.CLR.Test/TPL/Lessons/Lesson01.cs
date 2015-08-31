using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLR.Common.Contracts;
using TPL.BusinessLogic;
using System.Threading;

namespace TPL.Lessons
{
    /// <summary>
    /// Basic Tasks start examples
    /// </summary>
    public class Lesson01 
    {
        public async Task Execute()
        {
            // create the new escalation policy
            TaskScheduler.UnobservedTaskException +=
            (object sender, UnobservedTaskExceptionEventArgs eventArgs) =>
            {
                // mark the exception as being handled
                eventArgs.SetObserved();
                // get the aggregate exception and process the contents
                ((AggregateException)eventArgs.Exception).Handle(ex =>
                {
                    // write the type of the exception to the console
                    Console.WriteLine("Exception type: {0}. Message: {1}", ex.GetType(), ex.Message);
                    return true;
                });
            }; 

            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            source.Token.Register(() => {
                Console.WriteLine("Cancelled !!!");
            });

            //Task.Factory.StartNew((obj) => new Probe("gmail", token).RunAsync((string)obj), "http://www.gmail.com")
            //    .ContinueWith((tresult) => { Console.WriteLine(tresult.Exception); }, TaskContinuationOptions.OnlyOnFaulted);

            Task.Factory.StartNew((obj) => new Probe("mail.ru", token).RunAsync((string)obj), "http://www.mail.ru");

            Probe(token);

            source.Cancel();
        }

        public async Task Probe(CancellationToken token)
        {
            await new Probe("X", token).RunAsync("http://www.uz.gov.ua");
        }
    }
}
