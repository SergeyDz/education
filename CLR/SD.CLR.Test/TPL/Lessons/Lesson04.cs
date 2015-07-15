using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TPL.DomainModel;

namespace TPL.Lessons
{
    class Lesson04
    {
        public async Task Execute()
        {
            IncorrectExample();
            SyncUsingThreadLocal();
            SyncWithStateObject();
            SyncWithLock();
            SyncWithInterLocked();
            
            //SyncWithAttribute();
        }

        private void IncorrectExample()
        {
            Account account = new Account();
            int n = 10;
            Task[] wokers = new Task[n];
            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 100000; j++)
                    {
                        account.Balance = account.Balance + 1;
                    }
                    
                });
            }
            Task.WaitAll(wokers);
            Console.WriteLine("IncorrectExample: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.Balance);
        }

        private void SyncWithStateObject()
        {
            Account account = new Account();
        
            int n = 10;

            Task<int>[] wokers = new Task<int>[n];
            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task<int>.Factory.StartNew((obj) =>
                {
                    var a = (int)obj;

                    for (int j = 0; j < 100000; j++)
                    {
                        a++;
                    }
                    return a;
                },
                account.Balance);
            }
            Task.WaitAll(wokers);
            for (int i = 0; i < n; i++)
            {
                account.Balance += wokers[i].Result;
            }
            Console.WriteLine("SyncWithStateObjects: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.Balance);
        }

        private void SyncUsingThreadLocal()
        {
            Account account = new Account();
            ThreadLocal<int> localAccount = new ThreadLocal<int>();

            int n = 10;

            Task<int>[] wokers = new Task<int>[n];
            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task<int>.Factory.StartNew((obj) =>
                {
                    localAccount.Value = (int)obj;

                    for (int j = 0; j < 100000; j++)
                    {
                        localAccount.Value++;
                    }
                    return localAccount.Value;
                },
                account.Balance);
            }
            Task.WaitAll(wokers);

            for (int i = 0; i < n; i++)
            {
                account.Balance += wokers[i].Result;
            }
            Console.WriteLine("SyncUsingThreadLocal: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.Balance);
        }

        private void SyncWithLock()
        {
            Account account = new Account();
            int n = 10;
            Task[] wokers = new Task[n];

            object locker = new object();

            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 100000; j++)
                    {
                        lock (locker)
                        {
                            account.Balance++; 
                        }
                    }

                });
            }
            Task.WaitAll(wokers);
            Console.WriteLine("SyncWithLock: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.Balance);
        }

        private void SyncWithInterLocked()
        {
            Account account = new Account();
          
            int n = 10;
            Task[] wokers = new Task[n];

            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 100000; j++)
                    {
                        Interlocked.Increment(ref account.balanceField);
                    }

                });
            }
            Task.WaitAll(wokers);
            Console.WriteLine("SyncWithInterLocked: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.balanceField);
        }

        private void SyncWithAttribute()
        {
            AccountSynced account = new AccountSynced();
            int n = 10;
            Task[] wokers = new Task[n];
            for (int i = 0; i < n; i++)
            {
                wokers[i] = Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 100000; j++)
                    {
                        account.IncrementBalance();
                    }

                });
            }
            Task.WaitAll(wokers);
            Console.WriteLine("IncorrectExample: Total account balance. Expected: {0}, Calculated: {1}", 1000000, account.GetBalance());
        }

    }
}
