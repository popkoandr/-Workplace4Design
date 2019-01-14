using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Workplace.ConsoleApp.DelegatesEvents;
using Workplace.ConsoleApp.Lessons.CovarianceContravariance;

namespace Workplace.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DelegatesEvents
            MathService service = new MathService();
            new List<IMathPerformService> { new LogginService(), new NotificationService()
            }.ForEach(serv => service.MathPerformed1 += serv.OnMathPerformed);
            // service.MathPerformed += OnOutBountEvent;
            service.MathPerformed1 += (sender, e) => //is the same as = delegate(object sender, MathPerformedEventArgs args){ 
            {
                System.Console.WriteLine($"Calculation RESULT {e.MathResult}");
            };
            service.AddNumbers(4, 5);


            service.MathPerformed2 += (res) =>
             {
                 System.Console.WriteLine($"Calculation RESULT {res}");
             };

            service.CalculateNumbers2(3, 3, (val1, val2) => val1 + val2); //(val1, val2) => {return val1 + val2;}); 2.1 
            #endregion

            #region Covariance and Contravariance
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account acc1 = depositBank.CreateAccount(34);

            IBank<Account> ordinaryBank = new Bank<DepositAccount>();
            Account acc2 = ordinaryBank.CreateAccount(45);



            #endregion

            System.Console.ReadLine();
        }

        //static void OnOutBountEvent(object sender, MathPerformedEventArgs args)
        //{
        //    System.Console.WriteLine($"OnOutBountDelegate perform {args.MathResult}");
        //} 
        // After we have added two services for notif. and logging we dont need this method anymore



    }
}
