using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace TPL.DomainModel
{
    [Synchronization]
    class AccountSynced : ContextBoundObject 
    {
        private int balance = 0;
        public void IncrementBalance()
        {
            balance++;
        }
        public int GetBalance()
        {
            return balance;
        } 
    }
}
