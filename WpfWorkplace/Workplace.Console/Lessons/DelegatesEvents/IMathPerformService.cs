using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workplace.ConsoleApp.DelegatesEvents
{
    public interface IMathPerformService
    {

        void OnMathPerformed(object s, MathPerformedEventArgs args);
    }
}
