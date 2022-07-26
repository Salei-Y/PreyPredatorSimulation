using SimulationLib;
using SimulationLib.UI;
using SimulationLib.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean(true);

            Settings oceanView = new Settings();

                    IDisplayElements elements = new ConsoleView();
                    IConsoleView viewer = new Settings();
                    IEnterData data = new Settings();

                    data.EnterNumOfObjects(viewer);
                    data.EnterNumOfIterations(viewer);

                    ocean.Initialize(viewer);

                    Console.Clear();


            Console.CursorVisible = false;

            for (int iteration = 0; iteration < viewer.UserNumIteration; iteration++)
            {
                if (ocean.NumPrey > 0 && ocean.NumPredators > 0)
                {
                    ocean.Run(iteration);

                    elements.CountParticipants(ocean);
                    data.Display(iteration, ocean, viewer.UserNumIteration);

                    Thread.Sleep(Variable.FrameChangeDelay);
                }
                else
                {
                    break;
                }
            }

            data.EndSimulation();

            oceanView.CloseApp();
        }
    }
}
