using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workplace.Console.DelegatesEvents;

namespace Workplace.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            new List<IMathPerformService> { new LogginService(), new NotificationService()
            }.ForEach(serv => service.MathPerformed += serv.OnMathPerformed);
           // service.MathPerformed += OnOutBountEvent;
            service.AddNumbers(4, 5);
            System.Console.ReadLine();
        }

        //static void OnOutBountEvent(object sender, MathPerformedEventArgs args)
        //{
        //    System.Console.WriteLine($"OnOutBountDelegate perform {args.MathResult}");
        //} 
        // After we have added two services for notif. and logging we dont need this method anymore

    }
}
