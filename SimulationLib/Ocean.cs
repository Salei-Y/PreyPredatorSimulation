using System;
using System.Threading;
using System.Collections.Generic;
using SimulationLib.UI;
using SimulationLib.Interfaces;

namespace SimulationLib
{
    public class Ocean : ISimulation
    {

        #region [Variables]
        public static int numRows = Variable.numRows;
        public static int numCols = Variable.numCols;
        private static int size;

        private int numPrey = Variable.numPrey;
        private int numPredators = Variable.numPredators;
        private int numObstacles = Variable.numObstacles;
        private int TimeToFeed = Variable.TimeToFeed;
        private int TimeToReproduce = Variable.TimeToReproduce;
        private int defaultPreyImage = Variable.defaultPreyImage;
        private int defaultPredatorImage = Variable.defaultPredatorImage;

        public static ConsoleView consoleView = new ConsoleView();
        public static DoubleBuffered counter = new DoubleBuffered();
        public static Random random = new Random();
        private static Cell[,] cells;

        #endregion

        public int NumRows
        {
            get { return numRows; }
            set { numRows = value; }
        }
        public int NumCols
        {
            get { return numCols; }
            set { numCols = value; }
        }
        public int NumPrey
        {
            get { return numPrey; }
            set { numPrey = value; }
        }
        public int NumObstacles
        {
            get { return numObstacles; }
            set { numPredators = value; }
        }
        public int NumPredators
        {
            get { return numPredators; }
            set { numPredators = value; }
        }
        public static int Size
        {
            get { return size; }
        }
        public Cell[,] Cells
        {
            get { return cells; }
        }

        public void Initialize()
        {
            cells = new Cell[numRows, numCols];
            size = numCols * numRows;
            random = new Random();
            InitCells();
            AddEmptyCells();
            AddObstacles();
            AddPredators();
            AddPrey();
        }

        public void Run()
        {
            int numIterations;
            Console.Write("Input a number of iterations: ");
            bool IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numIterations);
            while (!IsConvertedNum)
            {
                Console.Write("Wrong data! Reenter: ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numIterations);
            }
            Console.CursorVisible = false;
            for (int k = 0; k < numIterations; k++)
            {
                for (int i = 0; i < numRows; i++)
                    for (int j = 0; j < numCols; j++)
                        cells[i, j].wasNotProcessed = true;
                Thread.Sleep(1000);
                CountParticipants();
                consoleView.Display(k, this, numIterations);
                if (NumPrey > 0 && NumPredators > 0)
                {
                    for (int i = 0; i < numRows; i++)
                        for (int j = 0; j < numCols; j++)
                            cells[i, j].Process(k);
                }
                else
                {
                    break;
                }
            }
        }

        public Coordinate GetEmptyCellLocation() //Returns empty cell
        {
            Coordinate location = new Coordinate();
            for (int i = 0; i < size; i++)
            {
                int rowLocation = random.Next(0, numRows);
                int colLocation = random.Next(0, numCols);

                if (cells[rowLocation, colLocation].GetType() == typeof(Cell))
                {
                    location.X = rowLocation;
                    location.Y = colLocation;

                    break;
                }
            }

            return location;
        }

        private void AddEmptyCells() //Initialize default field
        {
            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numCols; j++)
                    cells[i, j] = new Cell(new Coordinate
                    {
                        X = i,
                        Y = j,
                    }, this);
        }

        private void AddObstacles() //Add obstacles in ocean
        {
            for (int i = 0; i < numObstacles; i++)
            {
                Coordinate location = GetEmptyCellLocation();
                cells[location.X, location.Y] = new Obstacle(location, this);
            }
        }

        private void AddPredators() //Add predators in ocean
        {
            for (int i = 0; i < numPredators; i++)
            {
                Coordinate location = GetEmptyCellLocation();
                cells[location.X, location.Y] = new Predator(location, this, TimeToReproduce, TimeToFeed);
            }
        }

        private void AddPrey() //Add prey in ocean
        {
            for (int i = 0; i < numPrey; i++)
            {
                Coordinate location = GetEmptyCellLocation();
                cells[location.X, location.Y] = new Prey(location, this, TimeToReproduce);
            }
        }

        public Coordinate GetEmptyNeighborCoord(Coordinate location)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (location.X + 1 < NumRows)
            {
                if (Cells[location.X + 1, location.Y].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[location.X + 1, location.Y].Offset);
                }
            }

            if (location.X - 1 >= 0)
            {
                if (Cells[location.X - 1, location.Y].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[location.X - 1, location.Y].Offset);
                }
            }

            if (location.Y + 1 < NumCols)
            {
                if (Cells[location.X, location.Y + 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[location.X, location.Y + 1].Offset);
                }
            }

            if (location.Y - 1 >= 0)
            {
                if (Cells[location.X, location.Y - 1].GetType() == typeof(Cell))
                {
                    coordinates.Add(Cells[location.X, location.Y - 1].Offset);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.Next(0, coordinates.Count - 1);

            return coordinates[choice];
        }

        public void AssignCellAt(Coordinate location, Cell cell)
        {
            if (location != null)
            {
                Cells[location.X, location.Y] = cell;
            }
        }

        public Coordinate GetPreyNeighborCoord(Coordinate location)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (location.X + 1 < NumRows)
            {
                if (Cells[location.X + 1, location.Y].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[location.X + 1, location.Y].Offset);
                }
            }

            if (location.X - 1 >= 0)
            {
                if (Cells[location.X - 1, location.Y].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[location.X - 1, location.Y].Offset);
                }
            }

            if (location.Y + 1 < NumCols)
            {
                if (Cells[location.X, location.Y + 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[location.X, location.Y + 1].Offset);
                }
            }

            if (location.Y - 1 >= 0)
            {
                if (Cells[location.X, location.Y - 1].GetType() == typeof(Prey))
                {
                    coordinates.Add(Cells[location.X, location.Y - 1].Offset);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.Next(0, coordinates.Count - 1);

            return coordinates[choice];
        }

        private void CountParticipants()
        {
            int preys = 0;
            int predators = 0;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (cells[i, j].Image == defaultPreyImage)
                    {
                        preys++;
                    }
                    else if (cells[i, j].Image == defaultPredatorImage)
                    {
                        predators++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            NumPrey = preys;
            NumPredators = predators;
        }

        public void InitCells() //Init cells
        {
            int sumOfObjects;
            do
            {
                bool IsConvertedNum;
                try
                {
                    Console.Write("Input a number prey (default value is 150): ");
                    numPrey = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Wrong data! ");
                    InitCells();
                }
                Console.Write("Input a number predators (default value is 20): ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPredators);
                while (!IsConvertedNum)
                {
                    Console.Write("Wrong data! Reenter: ");
                    IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPredators);
                }
                Console.Write("Input a number obstacles (default value is 75): ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numObstacles);
                while (!IsConvertedNum)
                {
                    Console.Write("Wrong data! Reenter: ");
                    IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numObstacles);
                }
                sumOfObjects = numPrey + numPredators + numObstacles;
                if (sumOfObjects >= size)
                {
                    Console.WriteLine("The maximum number of objects should be lower than number of cells (Maximum Allowed Number of Objects: {0})", size);
                }
            } while (sumOfObjects >= size);
        }
    }
}
