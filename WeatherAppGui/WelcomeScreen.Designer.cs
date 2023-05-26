namespace WeatherAppGui
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.FindCity = new System.Windows.Forms.Button();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindCity
            // 
            this.FindCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindCity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FindCity.Location = new System.Drawing.Point(300, 206);
            this.FindCity.Name = "FindCity";
            this.FindCity.Size = new System.Drawing.Size(200, 50);
            this.FindCity.TabIndex = 0;
            this.FindCity.Text = "Znajdź miasto";
            this.FindCity.UseVisualStyleBackColor = true;
            this.FindCity.Click += new System.EventHandler(this.FindCity_Click);
            // 
            // CityInput
            // 
            this.CityInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CityInput.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityInput.Location = new System.Drawing.Point(150, 150);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(500, 39);
            this.CityInput.TabIndex = 1;
            this.CityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityInput_KeyDown);
            // 
            // Error
            // 
            this.Error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.Color.Transparent;
            this.Error.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Error.ForeColor = System.Drawing.Color.Red;
            this.Error.Location = new System.Drawing.Point(316, 124);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(169, 19);
            this.Error.TabIndex = 2;
            this.Error.Text = "Wpisz nazwę miasta";
            this.Error.Visible = false;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.FindCity);
            this.Name = "WelcomeScreen";
            this.Text = "Pogoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindCity;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Label Error;
    }
}