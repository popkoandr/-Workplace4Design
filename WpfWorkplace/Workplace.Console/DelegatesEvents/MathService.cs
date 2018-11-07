using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.Console.DelegatesEvents
{
    class MathService
    {
        //public delegate double ResultHandler(double value1, double value2); 
        //public delegate void OutBoundHandler(double res);
        //public ResultHandler MathDelegate;
        // //public OutBoundHandler OutboundDelegate; after we've create an event we dont need this anymore.
        //public event OutBoundHandler OutboundEvent;

        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public double AddNumbers(double value1, double value2)
        {
            var res = value1 + value2;
            MathPerformed(this, new MathPerformedEventArgs(res));
            return res;
        }

        public double MultiplyNumbers(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}
