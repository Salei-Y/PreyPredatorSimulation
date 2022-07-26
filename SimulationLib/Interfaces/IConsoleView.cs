using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.Interfaces
{
    public interface IConsoleView
    {
        int UserNumPrey { get; set; }
        int UserNumPredators { get; set; }
        int UserNumObstacles { get; set; }
        int UserNumIteration { get; set; }
    }
}
