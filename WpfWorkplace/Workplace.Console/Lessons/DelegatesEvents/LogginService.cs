using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.ConsoleApp.DelegatesEvents
{
    public class LogginService : IMathPerformService
    {
        public void OnMathPerformed(object s, MathPerformedEventArgs args)
        {
            System.Console.WriteLine($"Logging result {args.MathResult}");  
        }
    }
    public class NotificationService : IMathPerformService
    {
        public void OnMathPerformed(object s, MathPerformedEventArgs args)
        {
            System.Console.WriteLine($"Notifaication result is {args.MathResult}");
        }
    }
}
