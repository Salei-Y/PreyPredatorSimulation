using System;
using System.Windows.Forms;

namespace PreyPredatorWinForms
{
    public partial class StartWindow : Form
    {
        #region [Constructor]

        public StartWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region [Events]

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingWindow settings = new SettingWindow() { ReturnForm = this };
            settings.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}