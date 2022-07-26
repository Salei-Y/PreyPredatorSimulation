namespace PreyPredatorWinForms
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.gameTitle = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("OCR A Extended", 36F);
            this.gameTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gameTitle.Location = new System.Drawing.Point(223, 36);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(370, 50);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "PreyPredator";
            this.gameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.exitButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.exitButton.Location = new System.Drawing.Point(296, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(242, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Transparent;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.settingButton.ForeColor = System.Drawing.Color.OldLace;
            this.settingButton.Location = new System.Drawing.Point(296, 313);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(242, 40);
            this.settingButton.TabIndex = 3;
            this.settingButton.Text = " Start ";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameTitle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartWindow";
            this.Text = "Prey Predator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button settingButton;
    }
}