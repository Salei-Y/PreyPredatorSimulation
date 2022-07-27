using SimulationLib;
using SimulationLib.CustomExceptions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PreyPredatorWinForms
{
    public partial class SettingWindow : Form
    {
        #region [Variables]

        public Form ReturnForm;

        private ExceptionInform _inform = new ExceptionInform();

        #endregion

        #region [Constructor]

        public SettingWindow()
        {
            InitializeComponent();
            _inform.RegisterHandler(PrintExceptionMessage);
        }

        #endregion

        #region [Events]

        private void SettingWindow_Load(object sender, EventArgs e)
        {
            numIterationsTextBox.MaxLength = 4;
            numObstaclesTextBox.MaxLength = 4;
            numPredatorsTextBox.MaxLength = 4;
            numPreysTextBox.MaxLength = 4;

            SetTextBoxDefaultSettings();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainWindow ocean = new MainWindow();

            SetData(ocean, numIterationsTextBox, numObstaclesTextBox, numPredatorsTextBox, numPreysTextBox);
            this.Opacity = 0.0;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnForm.Show();
        }

        #region [Enters TextBoxes]

        private void numPreysTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(numPreysTextBox);
        }

        private void numPreysTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(numPreysTextBox, Variable.numPreys);
        }

        private void numPredatorsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(numPredatorsTextBox);
        }

        private void numPredatorsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(numPredatorsTextBox, Variable.numPredators);
        }

        private void numObstaclesTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(numObstaclesTextBox);
        }

        private void numObstaclesTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(numObstaclesTextBox, Variable.numObstacles);
        }

        private void numIterationsTextBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(numIterationsTextBox);
        }

        private void numIterationsTextBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(numIterationsTextBox, Variable.defaultNumIterations);
        }

        #endregion

        #endregion

        #region [Methods]

        private void SetData(MainWindow ocean, TextBox iteratinonTextBox, TextBox obstaclesTextBox, TextBox predatorsTextBox, TextBox preysTextBox)
        {
            bool isConvertedIterations;
            bool isConvertedObstacles;
            bool isConvertedPredators;
            bool isConvertedPreys;
            bool isNotOverflowed;

            int maxObjects = Variable.numRows * Variable.numCols;
            int sumObjects;

            try
            {
                ocean.display.UserNumIteration = Int32.Parse(iteratinonTextBox.Text);

                if (ocean.display.UserNumIteration > Variable.defaultNumIterations || ocean.display.UserNumIteration <= 0)
                {
                    throw new InvalidInputIterationsException();
                }

                isConvertedIterations = true;
            }
            catch (InvalidInputIterationsException ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                isConvertedIterations = false;
            }
            catch (Exception ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                isConvertedIterations = false;
            }

            (isConvertedObstacles, ocean.display.UserNumObstacles) = CheckNumOfParticipants(ocean.display.UserNumObstacles, obstaclesTextBox);
            (isConvertedPredators, ocean.display.UserNumPredators) = CheckNumOfParticipants(ocean.display.UserNumPredators, predatorsTextBox);
            (isConvertedPreys, ocean.display.UserNumPrey) = CheckNumOfParticipants(ocean.display.UserNumPrey, preysTextBox);

            if (isConvertedIterations && isConvertedObstacles && isConvertedPredators && isConvertedPreys)
            {
                try
                {
                    sumObjects = ocean.display.UserNumObstacles + ocean.display.UserNumPredators + ocean.display.UserNumPrey;

                    if (sumObjects >= maxObjects)
                    {
                        throw new OceanOverflowException();
                    }

                    isNotOverflowed = true;
                }
                catch (OceanOverflowException ex)
                {
                    _inform.Inform(ex.Message);

                    SetTextBoxDefaultSettings();

                    isNotOverflowed = false;
                }
                catch (Exception ex)
                {
                    _inform.Inform(ex.Message);

                    SetTextBoxDefaultSettings();

                    isNotOverflowed = false;
                }

                if (isNotOverflowed)
                {
                    ocean.Show();
                }
            }
        }

        private void EnterTextBox(TextBox numTextBox)
        {
            if (numTextBox.ForeColor == Color.Silver)
            {
                numTextBox.Text = null;
                numTextBox.ForeColor = Color.Gray;
            }
        }

        private void LeaveTextBox(TextBox numTextBox, int defaultNum)
        {
            if (numTextBox.Text == "")
            {
                numTextBox.Text = defaultNum.ToString();
                numTextBox.ForeColor = Color.Silver;
            }
        }

        private (bool, int) CheckNumOfParticipants(int numParticipants, TextBox participantsTextBox)
        {
            try
            {
                numParticipants = Int32.Parse(participantsTextBox.Text);

                if (numParticipants <= 0)
                {
                    throw new InvalidValueForObjectsException();
                }

                return (true, numParticipants);
            }
            catch (InvalidValueForObjectsException ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                return (false, numParticipants);
            }
            catch (Exception ex)
            {
                _inform.Inform(ex.Message);

                SetTextBoxDefaultSettings();

                return (false, numParticipants);
            }
        }

        private void SetTextBoxDefaultSettings()
        {

            numPreysTextBox.Text = Variable.numPreys.ToString();
            numPreysTextBox.ForeColor = Color.Silver;

            numPredatorsTextBox.Text = Variable.numPredators.ToString();
            numPredatorsTextBox.ForeColor = Color.Silver;

            numObstaclesTextBox.Text = Variable.numObstacles.ToString();
            numObstaclesTextBox.ForeColor = Color.Silver;

            numIterationsTextBox.Text = Variable.defaultNumIterations.ToString();
            numIterationsTextBox.ForeColor = Color.Silver;
        }

        void PrintExceptionMessage(string message)
        {
            MessageBox.Show(message);
        }

        #endregion
    }
}
