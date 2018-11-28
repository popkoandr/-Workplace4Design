using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.ConsoleApp.DelegatesEvents
{
    public class MathPerformedEventArgs : EventArgs
    {

        public double MathResult { get; set; }

        public MathPerformedEventArgs(double res)
        {
            MathResult = res;
        }
        

    }
}
