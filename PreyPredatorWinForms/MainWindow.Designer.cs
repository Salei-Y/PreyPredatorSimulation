namespace PreyPredatorWinForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.oceanDataGridView = new System.Windows.Forms.DataGridView();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.numPredatorLabel = new System.Windows.Forms.Label();
            this.numPreyLabel = new System.Windows.Forms.Label();
            this.numObstacleLabel = new System.Windows.Forms.Label();
            this.numIterationLabel = new System.Windows.Forms.Label();
            this.predatorLabel = new System.Windows.Forms.Label();
            this.preyLabel = new System.Windows.Forms.Label();
            this.obstacleLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).BeginInit();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // oceanDataGridView
            // 
            this.oceanDataGridView.AllowUserToAddRows = false;
            this.oceanDataGridView.AllowUserToDeleteRows = false;
            this.oceanDataGridView.AllowUserToResizeColumns = false;
            this.oceanDataGridView.AllowUserToResizeRows = false;
            this.oceanDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oceanDataGridView.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oceanDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.oceanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oceanDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.oceanDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.oceanDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.oceanDataGridView.Location = new System.Drawing.Point(23, 72);
            this.oceanDataGridView.Name = "oceanDataGridView";
            this.oceanDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oceanDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.oceanDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            this.oceanDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.oceanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.oceanDataGridView.ShowCellToolTips = false;
            this.oceanDataGridView.Size = new System.Drawing.Size(1124, 457);
            this.oceanDataGridView.TabIndex = 0;
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.startSimulationButton);
            this.statsPanel.Controls.Add(this.numPredatorLabel);
            this.statsPanel.Controls.Add(this.numPreyLabel);
            this.statsPanel.Controls.Add(this.numObstacleLabel);
            this.statsPanel.Controls.Add(this.numIterationLabel);
            this.statsPanel.Controls.Add(this.predatorLabel);
            this.statsPanel.Controls.Add(this.preyLabel);
            this.statsPanel.Controls.Add(this.obstacleLabel);
            this.statsPanel.Controls.Add(this.iterationLabel);
            this.statsPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statsPanel.Location = new System.Drawing.Point(20, 20);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1124, 46);
            this.statsPanel.TabIndex = 1;
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.BackColor = System.Drawing.Color.Black;
            this.startSimulationButton.BackgroundImage = global::PreyPredatorWinForms.Properties.Resources.Start;
            this.startSimulationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startSimulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSimulationButton.Font = new System.Drawing.Font("OCR A Extended", 1F);
            this.startSimulationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startSimulationButton.Location = new System.Drawing.Point(1078, 0);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(43, 43);
            this.startSimulationButton.TabIndex = 12;
            this.startSimulationButton.Text = "R";
            this.startSimulationButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.startSimulationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startSimulationButton.UseVisualStyleBackColor = false;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // numPredatorLabel
            // 
            this.numPredatorLabel.AutoSize = true;
            this.numPredatorLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numPredatorLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numPredatorLabel.Location = new System.Drawing.Point(953, 11);
            this.numPredatorLabel.Name = "numPredatorLabel";
            this.numPredatorLabel.Size = new System.Drawing.Size(20, 20);
            this.numPredatorLabel.TabIndex = 11;
            this.numPredatorLabel.Text = "0";
            // 
            // numPreyLabel
            // 
            this.numPreyLabel.AutoSize = true;
            this.numPreyLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numPreyLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numPreyLabel.Location = new System.Drawing.Point(634, 11);
            this.numPreyLabel.Name = "numPreyLabel";
            this.numPreyLabel.Size = new System.Drawing.Size(20, 20);
            this.numPreyLabel.TabIndex = 10;
            this.numPreyLabel.Text = "0";
            // 
            // numObstacleLabel
            // 
            this.numObstacleLabel.AutoSize = true;
            this.numObstacleLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numObstacleLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numObstacleLabel.Location = new System.Drawing.Point(381, 11);
            this.numObstacleLabel.Name = "numObstacleLabel";
            this.numObstacleLabel.Size = new System.Drawing.Size(20, 20);
            this.numObstacleLabel.TabIndex = 9;
            this.numObstacleLabel.Text = "0";
            // 
            // numIterationLabel
            // 
            this.numIterationLabel.AutoSize = true;
            this.numIterationLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numIterationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numIterationLabel.Location = new System.Drawing.Point(117, 11);
            this.numIterationLabel.Name = "numIterationLabel";
            this.numIterationLabel.Size = new System.Drawing.Size(20, 20);
            this.numIterationLabel.TabIndex = 8;
            this.numIterationLabel.Text = "1";
            // 
            // predatorLabel
            // 
            this.predatorLabel.AutoSize = true;
            this.predatorLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.predatorLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.predatorLabel.Location = new System.Drawing.Point(845, 11);
            this.predatorLabel.Name = "predatorLabel";
            this.predatorLabel.Size = new System.Drawing.Size(108, 20);
            this.predatorLabel.TabIndex = 7;
            this.predatorLabel.Text = "Predators";
            // 
            // preyLabel
            // 
            this.preyLabel.AutoSize = true;
            this.preyLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.preyLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.preyLabel.Location = new System.Drawing.Point(564, 11);
            this.preyLabel.Name = "preyLabel";
            this.preyLabel.Size = new System.Drawing.Size(64, 20);
            this.preyLabel.TabIndex = 6;
            this.preyLabel.Text = "Preys";
            // 
            // obstacleLabel
            // 
            this.obstacleLabel.AutoSize = true;
            this.obstacleLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.obstacleLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.obstacleLabel.Location = new System.Drawing.Point(267, 11);
            this.obstacleLabel.Name = "obstacleLabel";
            this.obstacleLabel.Size = new System.Drawing.Size(108, 20);
            this.obstacleLabel.TabIndex = 5;
            this.obstacleLabel.Text = "Obstacles";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.iterationLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iterationLabel.Location = new System.Drawing.Point(3, 11);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(108, 20);
            this.iterationLabel.TabIndex = 4;
            this.iterationLabel.Text = "Iteration";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label.Location = new System.Drawing.Point(584, 545);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 12;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.endLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.endLabel.Location = new System.Drawing.Point(464, 545);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(251, 20);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "The simulation is over";
            this.endLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1166, 597);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.oceanDataGridView);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1182, 593);
            this.Name = "MainWindow";
            this.Text = "Prey Predator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oceanDataGridView)).EndInit();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView oceanDataGridView;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label numPredatorLabel;
        private System.Windows.Forms.Label numPreyLabel;
        private System.Windows.Forms.Label numObstacleLabel;
        private System.Windows.Forms.Label numIterationLabel;
        private System.Windows.Forms.Label predatorLabel;
        private System.Windows.Forms.Label preyLabel;
        private System.Windows.Forms.Label obstacleLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button startSimulationButton;
        private System.Windows.Forms.Label endLabel;
    }
}

