using System;
using System.Threading;

namespace PreyPredatorSimulation
{
    internal class Ocean
    {
        static int numRows = 25;
        static int numCols = 70;
        static int size = numRows * numCols;
        int numPrey = 150;
        int numPredators = 20;
        int numObstacles = 75;
        public static Random random = new Random();
        private static Cell[,] cells = new Cell[numRows, numCols];
        public int NumPrey
        {
            get { return numPrey; }
            set { numPrey = value; }
        }
        public int NumPredators
        {
            get { return numPredators; }
            set { numPredators = value; }
        }
        public static int NumRows
        {
            get { return numRows; }
        }
        public static int NumCols
        {
            get { return numCols; }
        }
        public static int Size
        {
            get { return size; }
        }
        public static Cell[,] Cells
        {
            get { return cells; }
        }
        private Coordinate GetEmptyCellPosition() //Returns empty cell
        {
            Coordinate position = new Coordinate();
            for (int i = 0; i < size; i++)
            {
                int currentRowPosition = random.Next(0, numRows);
                int currentColPosition = random.Next(0, numCols);

                if (cells[currentRowPosition, currentColPosition].Image == '-')
                {
                    position.X = currentRowPosition;
                    position.Y = currentColPosition;

                    break;
                }
            }

            return position;
        }

        private void AddEmptyCells() //Initialize default field
        {
            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numCols; j++)
                    cells[i, j] = new Cell(new Coordinate
                    {
                        X = i,
                        Y = j,
                    });
        }

        private void AddObstacles() //Add obstacles in ocean
        {
            for (int i = 0; i < numObstacles; i++)
            {
                Coordinate position = GetEmptyCellPosition();
                cells[position.X, position.Y] = new Obstacle(position);
            }
        }

        private void AddPredators() //Add predators in ocean
        {
            for (int i = 0; i < numPredators; i++)
            {
                Coordinate position = GetEmptyCellPosition();
                cells[position.X, position.Y] = new Predator(position);
            }
        }

        private void AddPrey() //Add prey in ocean
        {
            for (int i = 0; i < numPrey; i++)
            {
                Coordinate position = GetEmptyCellPosition();
                cells[position.X, position.Y] = new Prey(position);
            }
        }

        private void DisplayBorder() //Display the field boundary
        {
            for (int i = 0; i < numCols; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        private void DisplayCells() //Display the field (ocean)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                    cells[i, j].Display();
                Console.WriteLine();
            }
        }

        private void DisplayStats(int iteration) //Display information about objects and iteration
        {
            Console.Write("\nIteration number: {0}", iteration++);
            Console.Write("\tObstacles: {0}", numObstacles);
            Console.Write("\tPrey: {0}", numPrey);
            Console.WriteLine("\tPredators: {0}", numPredators);
        }

        /*private void InitCells() //Init cells
        {
            bool IsConvertedNum;
            Console.Write("Input a number prey (default is 150): ");
            IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPrey);
            while (!IsConvertedNum)
            {
                Console.Write("Wrong data! Reinput: ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPrey);
            }
            Console.Write("Input a number predators (default is 20): ");
            IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPredators);
            while (!IsConvertedNum)
            {
                Console.Write("Wrong data! Reinput: ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numPredators);
            }
            Console.Write("Input a number obstacles (default is 75): ");
            IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numObstacles);
            while (!IsConvertedNum)
            {
                Console.Write("Wrong data! Reinput: ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numObstacles);
            }
        }*/

        private void Initialize()
        {
            cells = new Cell[numRows, numCols];
            size = numCols * numRows;
            random = new Random();
            AddEmptyCells();
            //InitCells();
            AddObstacles();
            AddPredators();
            AddPrey();
        }

        public void Run()
        {
            /*int numIterations;
            Console.Write("Input a number of iterations: ");
            bool IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numIterations);
            while (!IsConvertedNum)
            {
                Console.Write("Wrong data! Reinput: ");
                IsConvertedNum = Int32.TryParse(Console.ReadLine(), out numObstacles);
            }
            Initialize();
            for (int m = 0; m < numIterations; m++)
            {*/
            Initialize();
            DisplayStats(0);
                DisplayBorder();
                DisplayCells();
                DisplayBorder();
                for (int i = 0; i < numRows; i++)
                    for (int j = 0; j < numCols; j++)
                        cells[i, j].Process();

                Thread.Sleep(2000);
            //}

            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numCols; j++)
                    Console.WriteLine($"Position: X - {cells[i, j].Offset.X} Y - {cells[i, j].Offset.Y}");
        }
    }
}
