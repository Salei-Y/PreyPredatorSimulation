using System;
using SimulationLib;
using SimulationLib.UI;
using SimulationLib.CustomExceptions;
using SimulationLib.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Settings : IConsoleView, IEnterData
    {

        private const int maxObjects = Variable.numRows * Variable.numCols;
        private int sumOfObjects;
        private bool _isConverted;

        private int numIterations;

        private int numPreys;
        private int numPredators;
        private int numObstacles;

        private int lastIterationRows = Variable.numRows + 3;
        private int lastIterationCols = Variable.numCols + 4;

        private char[,] lastIterationImage;
        private char[,] newIterationImage;
        private string updatedStats;

        private ExceptionInform inform = new ExceptionInform();

        private ConsoleView getImage = new ConsoleView();

        public int UserNumPrey
        {
            get { return numPreys; }
            set { numPreys = value; }
        }

        public int UserNumPredators
        {
            get { return numPredators; }
            set { numPredators = value; }
        }

        public int UserNumObstacles
        {
            get { return numObstacles; }
            set { numObstacles = value; }
        }

        public int UserNumIteration
        {
            get { return numIterations; }
            set { numIterations = value; }
        }


        public Settings()
        {
            inform.RegisterHandler(PrintExceptionMessage);
        }

        public void EnterNumOfObjects(IConsoleView view)
        {
            Console.Clear();

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Input a number prey (default value is 150): ");

                    numPreys = Int32.Parse(Console.ReadLine());

                    if (numPreys <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (numPreys >= maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of preys cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);
                }
            }

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Input a number predators (default value is 20): ");

                    numPredators = Int32.Parse(Console.ReadLine());

                    if (numPredators <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (numPredators >= maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of predators cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                   inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);
                }
            }

            _isConverted = false;

            while (!_isConverted)
            {
                try
                {
                    Console.Write("Input a number obstacles (default value is 75): ");

                    numObstacles = Int32.Parse(Console.ReadLine());

                    if (numObstacles <= 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (numObstacles >= maxObjects)
                    {
                        throw new InvalidValueForObjectsException("The amount of obstacles cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        _isConverted = true;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    inform.Inform(ex.Message);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);
                }
            }

            try
            {
                sumOfObjects = numPreys + numPredators + numObstacles;

                if (sumOfObjects >= maxObjects)
                {
                    throw new OceanOverflowException();
                }

            }
            catch (OceanOverflowException ex)
            {
                inform.Inform(ex.Message);

                Console.WriteLine("The maximum allowable number of objects has been exceeded (maximum allowed number of objects is {0})", maxObjects);
                Console.ReadKey();

                EnterNumOfObjects(view);
            }

            view.UserNumPrey = this.UserNumPrey;
            view.UserNumPredators = this.UserNumPredators;
            view.UserNumObstacles = this.UserNumObstacles;
        }

        public void EnterNumOfIterations(IConsoleView view)
        {
            try
            {
                Console.Write("Input a number of iterations (maximum allowed number of iterations {0}): ", Variable.defaultNumIterations);

                numIterations = Int32.Parse(Console.ReadLine());

                if (numIterations <= 0 || numIterations > Variable.defaultNumIterations)
                {
                    throw new InvalidInputIterationsException();
                }
            }
            catch (InvalidInputIterationsException ex)
            {
                inform.Inform(ex.Message);

                EnterNumOfIterations(view);
            }
            catch (Exception ex)
            {
                inform.Inform(ex.Message);

                EnterNumOfIterations(view);
            }

            view.UserNumIteration = this.UserNumIteration;
        }
        public void Display(int iteration, Ocean ocean, int numIterations)
        {
            lastIterationImage = new char[lastIterationRows, lastIterationCols];
            newIterationImage = new char[lastIterationRows, lastIterationCols];

            updatedStats = String.Format("Iteration: {0}/{1}     Obstacles: {2}" +
                "     Prey: {3}     Predators: {4}", iteration + 1, numIterations,
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
                Console.SetCursorPosition(14, lastIterationRows + 2);
                Console.WriteLine("The simulation is complete");
                Console.WriteLine();
        }

        public void CloseApp()
        {
                Console.SetCursorPosition(10, lastIterationRows + 5);
                Console.WriteLine("Press any key to  close the window");
                Console.WriteLine();
                Console.ReadKey();
        }

        void PrintExceptionMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
