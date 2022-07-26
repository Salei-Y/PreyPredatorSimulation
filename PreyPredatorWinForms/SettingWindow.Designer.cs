namespace PreyPredatorWinForms
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            this.numIterationsTextBox = new System.Windows.Forms.TextBox();
            this.numObstaclesTextBox = new System.Windows.Forms.TextBox();
            this.numPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.numPreysTextBox = new System.Windows.Forms.TextBox();
            this.numIterationsLabel = new System.Windows.Forms.Label();
            this.numObstaclesLabel = new System.Windows.Forms.Label();
            this.numPredatorsLabel = new System.Windows.Forms.Label();
            this.numPreysLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numIterationsTextBox
            // 
            this.numIterationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numIterationsTextBox.BackColor = System.Drawing.Color.DimGray;
            this.numIterationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numIterationsTextBox.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.numIterationsTextBox.ForeColor = System.Drawing.Color.Silver;
            this.numIterationsTextBox.Location = new System.Drawing.Point(407, 159);
            this.numIterationsTextBox.Name = "numIterationsTextBox";
            this.numIterationsTextBox.Size = new System.Drawing.Size(104, 25);
            this.numIterationsTextBox.TabIndex = 21;
            this.numIterationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numObstaclesTextBox
            // 
            this.numObstaclesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numObstaclesTextBox.BackColor = System.Drawing.Color.DimGray;
            this.numObstaclesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numObstaclesTextBox.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.numObstaclesTextBox.ForeColor = System.Drawing.Color.Silver;
            this.numObstaclesTextBox.Location = new System.Drawing.Point(407, 115);
            this.numObstaclesTextBox.Name = "numObstaclesTextBox";
            this.numObstaclesTextBox.Size = new System.Drawing.Size(104, 25);
            this.numObstaclesTextBox.TabIndex = 20;
            this.numObstaclesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPredatorsTextBox
            // 
            this.numPredatorsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPredatorsTextBox.BackColor = System.Drawing.Color.DimGray;
            this.numPredatorsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPredatorsTextBox.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.numPredatorsTextBox.ForeColor = System.Drawing.Color.Silver;
            this.numPredatorsTextBox.Location = new System.Drawing.Point(407, 72);
            this.numPredatorsTextBox.Name = "numPredatorsTextBox";
            this.numPredatorsTextBox.Size = new System.Drawing.Size(104, 25);
            this.numPredatorsTextBox.TabIndex = 19;
            this.numPredatorsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPreysTextBox
            // 
            this.numPreysTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPreysTextBox.BackColor = System.Drawing.Color.DimGray;
            this.numPreysTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPreysTextBox.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.numPreysTextBox.ForeColor = System.Drawing.Color.Silver;
            this.numPreysTextBox.Location = new System.Drawing.Point(407, 31);
            this.numPreysTextBox.Name = "numPreysTextBox";
            this.numPreysTextBox.Size = new System.Drawing.Size(104, 25);
            this.numPreysTextBox.TabIndex = 18;
            this.numPreysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numIterationsLabel
            // 
            this.numIterationsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numIterationsLabel.AutoSize = true;
            this.numIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numIterationsLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numIterationsLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numIterationsLabel.Location = new System.Drawing.Point(54, 159);
            this.numIterationsLabel.Name = "numIterationsLabel";
            this.numIterationsLabel.Size = new System.Drawing.Size(317, 20);
            this.numIterationsLabel.TabIndex = 17;
            this.numIterationsLabel.Text = "Enter number  of iterations:";
            // 
            // numObstaclesLabel
            // 
            this.numObstaclesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numObstaclesLabel.AutoSize = true;
            this.numObstaclesLabel.BackColor = System.Drawing.Color.Transparent;
            this.numObstaclesLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numObstaclesLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numObstaclesLabel.Location = new System.Drawing.Point(54, 115);
            this.numObstaclesLabel.Name = "numObstaclesLabel";
            this.numObstaclesLabel.Size = new System.Drawing.Size(306, 20);
            this.numObstaclesLabel.TabIndex = 16;
            this.numObstaclesLabel.Text = "Enter number  of obstacles:";
            // 
            // numPredatorsLabel
            // 
            this.numPredatorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numPredatorsLabel.AutoSize = true;
            this.numPredatorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.numPredatorsLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numPredatorsLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numPredatorsLabel.Location = new System.Drawing.Point(52, 72);
            this.numPredatorsLabel.Name = "numPredatorsLabel";
            this.numPredatorsLabel.Size = new System.Drawing.Size(306, 20);
            this.numPredatorsLabel.TabIndex = 15;
            this.numPredatorsLabel.Text = "Enter number  of predators:";
            // 
            // numPreysLabel
            // 
            this.numPreysLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numPreysLabel.AutoSize = true;
            this.numPreysLabel.BackColor = System.Drawing.Color.Transparent;
            this.numPreysLabel.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.numPreysLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numPreysLabel.Location = new System.Drawing.Point(52, 31);
            this.numPreysLabel.Name = "numPreysLabel";
            this.numPreysLabel.Size = new System.Drawing.Size(262, 20);
            this.numPreysLabel.TabIndex = 14;
            this.numPreysLabel.Text = "Enter number  of preys:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startButton.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.startButton.ForeColor = System.Drawing.Color.DarkKhaki;
            this.startButton.Location = new System.Drawing.Point(89, 205);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(242, 69);
            this.startButton.TabIndex = 22;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backbutton.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.backbutton.ForeColor = System.Drawing.Color.DarkKhaki;
            this.backbutton.Location = new System.Drawing.Point(407, 211);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(128, 57);
            this.backbutton.TabIndex = 23;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(557, 286);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numIterationsTextBox);
            this.Controls.Add(this.numObstaclesTextBox);
            this.Controls.Add(this.numPredatorsTextBox);
            this.Controls.Add(this.numPreysTextBox);
            this.Controls.Add(this.numIterationsLabel);
            this.Controls.Add(this.numObstaclesLabel);
            this.Controls.Add(this.numPredatorsLabel);
            this.Controls.Add(this.numPreysLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingWindow";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingWindow_FormClosing);
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numIterationsTextBox;
        private System.Windows.Forms.TextBox numObstaclesTextBox;
        private System.Windows.Forms.TextBox numPredatorsTextBox;
        private System.Windows.Forms.TextBox numPreysTextBox;
        private System.Windows.Forms.Label numIterationsLabel;
        private System.Windows.Forms.Label numObstaclesLabel;
        private System.Windows.Forms.Label numPredatorsLabel;
        private System.Windows.Forms.Label numPreysLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button backbutton;
    }
}