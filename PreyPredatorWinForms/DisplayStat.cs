using SimulationLib;
using SimulationLib.Interfaces;
using System.Windows.Forms;
using System.Drawing;

namespace PreyPredatorWinForms
{
    public class DisplayStat : IDisplayElements, IConsoleView
    {
        #region [Variables]

        private int numIterations;

        public int numOfOceans;

        private int numPrey;
        private int numPredators;
        private int numObstacles;

        private Bitmap _obstacleImage = new Bitmap(Properties.Resources.obstacle);
        private Bitmap _preyImage = new Bitmap(Properties.Resources.prey);
        private Bitmap _predatorImage = new Bitmap(Properties.Resources.predator);

        #endregion

        #region [Properties]

        public int UserNumPrey
        {
            get { return numPrey; }
            set { numPrey = value; }
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

        #endregion

        #region [Methods]

        public void CountParticipants(Ocean owner)
        {
            int preys = 0;
            int predators = 0;

            for (int i = 0; i < owner.NumRows; i++)
            {
                for (int j = 0; j < owner.NumCols; j++)
                {
                    if (owner.Cells[i, j].Image == 'f')
                    {
                        preys++;
                    }
                    else if (owner.Cells[i, j].Image == 'S')
                    {
                        predators++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            owner.NumPrey = preys;
            owner.NumPredators = predators;
        }

        public void DisplayStats(Label iterationNum, Label obstaclesNum, Label preysNum, Label predatorsNum, Ocean owner, int iteration)
        {
            iterationNum.Text = iteration.ToString()+"/"+UserNumIteration;
            obstaclesNum.Text = owner.NumObstacles.ToString();
            preysNum.Text = owner.NumPrey.ToString();
            predatorsNum.Text = owner.NumPredators.ToString();

        }

        public void DisplayOcean(DataGridView gridView, Ocean owner)
        {
            for (int i = 0; i < Variable.numRows; i++)
            {
                for (int j = 0; j < Variable.numCols; j++)
                {
                    if (owner.cells[i, j].Image == 'f')
                    {
                        gridView.Rows[i].Cells[j].Value = _preyImage;
                    }
                    else if (owner.cells[i, j].Image == 'S')
                    {
                        gridView.Rows[i].Cells[j].Value = _predatorImage;
                    }
                    else if (owner.cells[i, j].Image == '#')
                    {
                        gridView.Rows[i].Cells[j].Value = _obstacleImage;
                    }
                    else
                    {
                        gridView.Rows[i].Cells[j].Value = null;
                    }
                }
            }
        }

        #endregion
    }
}
