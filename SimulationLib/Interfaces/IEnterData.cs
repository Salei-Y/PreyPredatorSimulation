using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.Interfaces
{
    public interface IEnterData
    {
        void EnterNumOfObjects(IConsoleView view);
        void EnterNumOfIterations(IConsoleView view);
        void Display(int iteration, Ocean ocean, int numIterations);
        void EndSimulation();
    }
}
