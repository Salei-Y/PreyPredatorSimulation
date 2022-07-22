using System;

namespace SimulationLib.UI
{
    public class ConsoleView:Variable
    {
        private int lastIterationRows = numRows + 3;
        private int lastIterationCols = numCols + 4;

        private char[,] lastIterationImage;
        private char[,] newIterationImage;
        private string updatedStats;
        private DoubleBuffered getImage = new DoubleBuffered();

        public void Display(int iteration, Ocean ocean, int numIterations)
        {
            lastIterationImage = new char[lastIterationRows, lastIterationCols];
            newIterationImage = new char[lastIterationRows, lastIterationCols];

            updatedStats = String.Format("Iteration: {0}     Obstacles: {1}" +
                "     Prey: {2}     Predators: {3}", iteration + 1,
                ocean.NumObstacles, ocean.NumPrey, ocean.NumPredators);


            newIterationImage = getImage.GetIterationImage(newIterationImage, updatedStats, ocean, lastIterationRows, lastIterationCols);

                for (int i = 0; i < lastIterationRows; i++)
                {
                    for (int j = 0; j < lastIterationCols; j++)
                    {
                        if (newIterationImage[i, j] != lastIterationImage[i, j])
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(newIterationImage[i, j]);
                        }
                    }
                }

            lastIterationImage = getImage.GetIterationImage(lastIterationImage, updatedStats, ocean, lastIterationRows, lastIterationCols);
        }
        public void EndSimulation()
        {
            Console.WriteLine();
            Console.WriteLine("The simulation is complete");
            Console.CursorVisible = true;
            Console.ReadKey();
        }
    }
}
