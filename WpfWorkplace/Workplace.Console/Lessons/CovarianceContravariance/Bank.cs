using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workplace.ConsoleApp.Lessons.CovarianceContravariance;

namespace Workplace.ConsoleApp.Lessons.CovarianceContravariance
{
    interface IBank<out T>
    {
        T CreateAccount(int sum);
    }

    class Bank<T> : IBank<T> where T : Account, new()
    {
        public T CreateAccount(int sum)
        {
            T acc = new T();  // создаем счет
            acc.DoTransfer(sum);
            return acc;
        }
    }
}
