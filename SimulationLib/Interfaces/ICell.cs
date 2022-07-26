using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.Interfaces
{
    public interface ICell
    {
            int NumRows { get; set; }
            int NumCols { get; set; }
            Cell[,] Cells { get; }
    }
}
