using SimulationLib;
using SimulationLib.UI;

namespace PreyPredatorSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean();
            ConsoleView consoleView = new ConsoleView();
            ocean.Initialize();
            ocean.Run();
            consoleView.EndSimulation();
        }
    }
}
