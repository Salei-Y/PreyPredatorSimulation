using System;
using System.Threading;
using System.Windows.Forms;
using SimulationLib.Interfaces;
using SimulationLib.CustomExceptions;

namespace SimulationLib
{
    public class Ocean : ICell
    {

        #region [Variables]
        public static int numRows = Variable.numRows;
        public static int numCols = Variable.numCols;
        private static int size = Variable.numRows*Variable.numCols;

        private int numPreys = Variable.numPreys;
        private int numPredators = Variable.numPredators;
        private int numObstacles = Variable.numObstacles;
        private bool _isConsole;

        private AddCell addCells;
        public static Randomize random = new Randomize();
        private ExceptionInform inform = new ExceptionInform();
        public Cell[,] cells;
        #endregion

        public int NumRows
        {
            get { return numRows; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidRowsValueException();
                    }
                    else if (value > Variable.numRows)
                    {
                        throw new InvalidRowsValueException("The number of rows value is too big.");
                    }
                    else
                    {
                        numRows = value;
                    }
                }
                catch (InvalidRowsValueException ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
            }
        }
        public int NumCols
        {
            get { return numCols; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new InvalidColumnsValueException();
                    }
                    else if (value > Variable.numCols)
                    {
                        throw new InvalidColumnsValueException("The number of columns value is too big.");
                    }
                    else
                    {
                        numCols = value;
                    }
                }
                catch (InvalidColumnsValueException ex)
                {
                    inform.Inform(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        public int NumPrey
        {
            get { return numPreys; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= size)
                    {
                        throw new InvalidValueForObjectsException("The amount of preys cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        numPreys = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
            }
        }
        public int NumObstacles
        {
            get { return numObstacles; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= size)
                    {
                        throw new InvalidValueForObjectsException("The amount of obstacles cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        numObstacles = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
            }
        }
        public int NumPredators
        {
            get { return numPredators; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new InvalidValueForObjectsException();
                    }
                    else if (value >= size)
                    {
                        throw new InvalidValueForObjectsException("The amount of predators cannot be greater than the size of the ocean.");
                    }
                    else
                    {
                        numPredators = value;
                    }
                }
                catch (InvalidValueForObjectsException ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    inform.Inform(ex.Message);

                    Environment.Exit(0);
                }
            }
        }
        public static int Size
        {
            get { return size; }
        }
        public Cell[,] Cells
        {
            get { return cells; }
        }
        public Ocean(bool isConsole)
        {
            _isConsole = isConsole;
            inform.RegisterHandler(PrintExceptionMessage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oceanView"></param>
        public void Initialize(IConsoleView oceanView)
        {
            CheckValues();
            cells = new Cell[numRows, numCols];
            random = new Randomize();
            addCells = new AddCell();

            InitializeCells(oceanView);
        }

        private void InitializeCells(IConsoleView oceanView)
        {
            numPreys = oceanView.UserNumPrey;
            numPredators = oceanView.UserNumPredators;
            numObstacles = oceanView.UserNumObstacles;

            addCells.AddAllCells(this);
        }

        /// <summary>
        /// <summary>
        /// Що рбоить метод
        /// </summary>
        /// <param name="iteration">параметр такий то такий то потрібен для того то</param>
        public void Run(int iteration)
        {
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    cells[i, j].wasNotProcessed = true;
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    cells[i, j].Process(iteration);
                }
            }
        }

        private void CheckValues()
        {
            int sumObjects;

            NumPrey = numPreys;
            NumPredators = numPredators;
            NumObstacles = numObstacles;

            NumRows = numRows;
            NumCols = numCols;

            try
            {
                sumObjects = NumPrey + NumPredators + NumObstacles;

                if (sumObjects >= size)
                {
                    throw new OceanOverflowException();
                }
            }
            catch (OceanOverflowException ex)
            {
                inform.Inform(ex.Message);

                Environment.Exit(0);
            }
        }
        private void PrintExceptionMessage(string message)
        {
            if (_isConsole)
            {
                Console.WriteLine(message);
                Console.ReadKey();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
