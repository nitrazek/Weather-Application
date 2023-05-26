namespace WeatherAppGui
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Weather = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Temperature = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.UpdateTime = new System.Windows.Forms.Label();
            this.Visibility = new System.Windows.Forms.Label();
            this.WindSpeed = new System.Windows.Forms.Label();
            this.Sky = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Weather
            // 
            this.Weather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Weather.AutoSize = true;
            this.Weather.BackColor = System.Drawing.Color.Transparent;
            this.Weather.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather.ForeColor = System.Drawing.Color.White;
            this.Weather.Location = new System.Drawing.Point(270, 16);
            this.Weather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(154, 55);
            this.Weather.TabIndex = 0;
            this.Weather.Text = "Pogoda";
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(593, 353);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 27);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Wyjście";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Return.Location = new System.Drawing.Point(4, 353);
            this.Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(80, 27);
            this.Return.TabIndex = 8;
            this.Return.Text = "Powrót";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.Location = new System.Drawing.Point(88, 353);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(80, 27);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "Odśwież";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Temperature
            // 
            this.Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Temperature.AutoSize = true;
            this.Temperature.BackColor = System.Drawing.Color.Transparent;
            this.Temperature.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temperature.ForeColor = System.Drawing.SystemColors.Window;
            this.Temperature.Location = new System.Drawing.Point(90, 122);
            this.Temperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(100, 16);
            this.Temperature.TabIndex = 10;
            this.Temperature.Text = "Temperatura:";
            // 
            // Pressure
            // 
            this.Pressure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pressure.ForeColor = System.Drawing.SystemColors.Window;
            this.Pressure.Location = new System.Drawing.Point(90, 154);
            this.Pressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(78, 16);
            this.Pressure.TabIndex = 11;
            this.Pressure.Text = "Ciśnienie:";
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CityLabel.Location = new System.Drawing.Point(305, 77);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(73, 27);
            this.CityLabel.TabIndex = 12;
            this.CityLabel.Text = "Miasto";
            // 
            // UpdateTime
            // 
            this.UpdateTime.AutoSize = true;
            this.UpdateTime.BackColor = System.Drawing.Color.Transparent;
            this.UpdateTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpdateTime.ForeColor = System.Drawing.SystemColors.Window;
            this.UpdateTime.Location = new System.Drawing.Point(8, 8);
            this.UpdateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(123, 15);
            this.UpdateTime.TabIndex = 13;
            this.UpdateTime.Text = "Ostatnia aktualizacja:";
            // 
            // Visibility
            // 
            this.Visibility.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Visibility.AutoSize = true;
            this.Visibility.BackColor = System.Drawing.Color.Transparent;
            this.Visibility.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Visibility.ForeColor = System.Drawing.SystemColors.Window;
            this.Visibility.Location = new System.Drawing.Point(90, 187);
            this.Visibility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Visibility.Name = "Visibility";
            this.Visibility.Size = new System.Drawing.Size(100, 16);
            this.Visibility.TabIndex = 14;
            this.Visibility.Text = "Widoczność: ";
            // 
            // WindSpeed
            // 
            this.WindSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindSpeed.AutoSize = true;
            this.WindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.WindSpeed.Location = new System.Drawing.Point(420, 122);
            this.WindSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.Size = new System.Drawing.Size(125, 16);
            this.WindSpeed.TabIndex = 15;
            this.WindSpeed.Text = "Prędkość wiatru:";
            // 
            // Sky
            // 
            this.Sky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sky.AutoSize = true;
            this.Sky.BackColor = System.Drawing.Color.Transparent;
            this.Sky.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sky.ForeColor = System.Drawing.SystemColors.Window;
            this.Sky.Location = new System.Drawing.Point(420, 154);
            this.Sky.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sky.Name = "Sky";
            this.Sky.Size = new System.Drawing.Size(53, 16);
            this.Sky.TabIndex = 17;
            this.Sky.Text = "Niebo:";
            // 
            // Progress
            // 
            this.Progress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Progress.ForeColor = System.Drawing.Color.LimeGreen;
            this.Progress.Location = new System.Drawing.Point(270, 252);
            this.Progress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Progress.Maximum = 50;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(150, 19);
            this.Progress.TabIndex = 18;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(677, 384);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Sky);
            this.Controls.Add(this.WindSpeed);
            this.Controls.Add(this.Visibility);
            this.Controls.Add(this.UpdateTime);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Weather);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreen";
            this.Text = "Pogoda";
            this.Shown += new System.EventHandler(this.Start);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Weather;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label UpdateTime;
        private System.Windows.Forms.Label Visibility;
        private System.Windows.Forms.Label WindSpeed;
        private System.Windows.Forms.Label Sky;
        private System.Windows.Forms.ProgressBar Progress;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

