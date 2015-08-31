using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLR.Common.Contracts
{
        public interface ICommand
        {
            void Execute();
        }

        public interface ICommand<T> : ICommand
        {
            T Parameters { set; }
        }

        public interface ICommnad<T, TResult> : ICommand<T>
        {
            T Results { get; }
        }
}
