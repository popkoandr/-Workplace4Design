using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Workplace.ConsoleApp.DelegatesEvents
{
    class MathService
    {
        //public delegate double ResultHandler(double value1, double value2); 
        //public delegate void OutBoundHandler(double res);
        //public ResultHandler MathDelegate;
        // //public OutBoundHandler OutboundDelegate; after we've create an event we dont need this anymore.
        //public event OutBoundHandler OutboundEvent;

        public event EventHandler<MathPerformedEventArgs> MathPerformed1;

        public double AddNumbers(double value1, double value2)
        {
            var res = value1 + value2;
            MathPerformed1(this, new MathPerformedEventArgs(res));
            
            MathPerformed2(res);
            return res;
        }

        public double MultiplyNumbers(double value1, double value2)
        {
            return value1 * value2;
        }

        //========== 2
        public delegate void MathPerformedHandler(double result);
        public event MathPerformedHandler MathPerformed2;

        //===========2.1
        public delegate double CalculatationHandler(double val1, double val2);       

        public void CalculateNumbers2(double val1, double val2, CalculatationHandler calculation)
        {
            //var res = val1 + val2;
            //MathPerformed1(this, new MathPerformedEventArgs(res));
            //MathPerformed2(res);
            Timer timer = new Timer(5000);
            MathPerformed2(calculation(val1, val2));  
        }

        ////=========2.2
        //public delegate void MathPerformedHandler(double result);
        //public event MathPerformedHandler MathPerformed2;
        // we can simply change this on 
        public Action<double> MathPerformed3;


        //public delegate double CalculatationHandler(double val1, double val2);
        // we can simply change this on 
        public Func<double, double, double> CalculatationHandler3;

        // 
        public void CalculateNumbers3(double v1, double v2, Func<double,double, double> calculation)
        {
            MathPerformed3(calculation(v1, v2));
        }




    }
}
