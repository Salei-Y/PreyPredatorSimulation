using SimulationLib;
using SimulationLib.Interfaces;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace PreyPredatorWinForms
{
    public partial class MainWindow : Form
    {
        #region [Variables]

        public Ocean ocean = new Ocean(false);
        public IConsoleView oceanView = new DisplayStat();
        public DisplayStat display = new DisplayStat();

        private Bitmap start = new Bitmap(Properties.Resources.Start);
        private Bitmap pause = new Bitmap(Properties.Resources.Pause);
        private Bitmap close = new Bitmap(Properties.Resources.Close);

        int iteration = 0;

        #endregion

        #region [Constructor]

        public MainWindow()
        {
            InitializeComponent();
            DoubleBuffered();
        }

        #endregion

        #region [Events]

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = iterationLabel;

            oceanDataGridView.MultiSelect = false;

            PrepareField(oceanDataGridView, ocean);

            timer.Interval = Variable.TimerInterval;

            ocean.Initialize(display);
            DisplayIteration();
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            if (startSimulationButton.Text == "R")
            {
                timer.Start();
                startSimulationButton.Text = "P";
                startSimulationButton.BackgroundImage = pause;
            }
            else if (startSimulationButton.Text == "P")
            {
                timer.Stop();
                startSimulationButton.Text = "R";
                startSimulationButton.BackgroundImage = start;
            }
            else if (startSimulationButton.Text == "C")
            {
                Application.Exit();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ocean.NumPrey > 0 && ocean.NumPredators > 0)
            {
                if (iteration <= display.UserNumIteration)
                {
                   ocean.Run(iteration);

                    DisplayIteration();
                }
            }

            if (ocean.NumPrey == 0 || ocean.NumPredators == 0)
            {
                startSimulationButton.Text = "C";
                startSimulationButton.BackgroundImage = close;
                endLabel.Visible = true;
            }

            if (iteration == display.UserNumIteration)
            {
                startSimulationButton.Text = "C";
                startSimulationButton.BackgroundImage = close;
                endLabel.Visible = true;
            }
        }

        private void oceanDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataGridView)sender).SelectedCells[0].Selected = false;
            }
            catch { }
        }

        #endregion

        #region [Methods]

        private void DisplayIteration()
        {
            display.CountParticipants(ocean);
            display.DisplayStats(numIterationLabel, numObstacleLabel, numPreyLabel, numPredatorLabel, ocean, iteration);
            display.DisplayOcean(oceanDataGridView, ocean);

            iteration++;
        }

        private void PrepareField(DataGridView gridView, Ocean owner)
        {
            for (int i = 0; i < owner.NumCols; i++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imageCol.DefaultCellStyle.NullValue = null;

                gridView.Columns.Add(imageCol);
                gridView.Columns[i].Width = 16;
            }

            for (int i = 0; i < owner.NumRows; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Height = 16;
            }
        }

        private new void DoubleBuffered()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
            | BindingFlags.Instance | BindingFlags.NonPublic, null,
            oceanDataGridView, new object[]
            {
                true
            });
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion


    }
}
