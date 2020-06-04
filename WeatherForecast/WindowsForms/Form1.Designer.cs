namespace WindowsForms
{
    partial class Form1
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
            this.userinputfield = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.outputfield = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.RadioButton();
            this.stuendlichButton = new System.Windows.Forms.RadioButton();
            this.dreiTageButton = new System.Windows.Forms.RadioButton();
            this.vierzehnTageButton = new System.Windows.Forms.RadioButton();
            this.celsiusButton = new System.Windows.Forms.RadioButton();
            this.kelvinButton = new System.Windows.Forms.RadioButton();
            this.temperatureTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.temperatureTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userinputfield
            // 
            this.userinputfield.Location = new System.Drawing.Point(276, 206);
            this.userinputfield.Name = "userinputfield";
            this.userinputfield.Size = new System.Drawing.Size(405, 35);
            this.userinputfield.TabIndex = 0;
            this.userinputfield.Text = "Enter zipcode";
            this.userinputfield.TextChanged += new System.EventHandler(this.userinput_TextChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(12, 12);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(127, 49);
            this.searchbutton.TabIndex = 1;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(476, 662);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(127, 57);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // outputfield
            // 
            this.outputfield.Location = new System.Drawing.Point(276, 289);
            this.outputfield.Multiline = true;
            this.outputfield.Name = "outputfield";
            this.outputfield.ReadOnly = true;
            this.outputfield.Size = new System.Drawing.Size(709, 290);
            this.outputfield.TabIndex = 3;
            this.outputfield.Text = "Result";
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.Checked = true;
            this.easyButton.Location = new System.Drawing.Point(12, 98);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(123, 33);
            this.easyButton.TabIndex = 4;
            this.easyButton.TabStop = true;
            this.easyButton.Text = "Einfach";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // stuendlichButton
            // 
            this.stuendlichButton.AutoSize = true;
            this.stuendlichButton.Location = new System.Drawing.Point(12, 156);
            this.stuendlichButton.Name = "stuendlichButton";
            this.stuendlichButton.Size = new System.Drawing.Size(143, 33);
            this.stuendlichButton.TabIndex = 5;
            this.stuendlichButton.Text = "Stündlich";
            this.stuendlichButton.UseVisualStyleBackColor = true;
            // 
            // dreiTageButton
            // 
            this.dreiTageButton.AutoSize = true;
            this.dreiTageButton.Location = new System.Drawing.Point(12, 217);
            this.dreiTageButton.Name = "dreiTageButton";
            this.dreiTageButton.Size = new System.Drawing.Size(120, 33);
            this.dreiTageButton.TabIndex = 6;
            this.dreiTageButton.Text = "3 Tage";
            this.dreiTageButton.UseVisualStyleBackColor = true;
            // 
            // vierzehnTageButton
            // 
            this.vierzehnTageButton.AutoSize = true;
            this.vierzehnTageButton.Location = new System.Drawing.Point(12, 273);
            this.vierzehnTageButton.Name = "vierzehnTageButton";
            this.vierzehnTageButton.Size = new System.Drawing.Size(133, 33);
            this.vierzehnTageButton.TabIndex = 7;
            this.vierzehnTageButton.Text = "14 Tage";
            this.vierzehnTageButton.UseVisualStyleBackColor = true;
            // 
            // celsiusButton
            // 
            this.celsiusButton.AutoSize = true;
            this.celsiusButton.Checked = true;
            this.celsiusButton.Location = new System.Drawing.Point(33, 45);
            this.celsiusButton.Name = "celsiusButton";
            this.celsiusButton.Size = new System.Drawing.Size(124, 33);
            this.celsiusButton.TabIndex = 8;
            this.celsiusButton.TabStop = true;
            this.celsiusButton.Text = "Celsius";
            this.celsiusButton.UseVisualStyleBackColor = true;
            // 
            // kelvinButton
            // 
            this.kelvinButton.AutoSize = true;
            this.kelvinButton.Location = new System.Drawing.Point(33, 102);
            this.kelvinButton.Name = "kelvinButton";
            this.kelvinButton.Size = new System.Drawing.Size(110, 33);
            this.kelvinButton.TabIndex = 9;
            this.kelvinButton.Text = "Kelvin";
            this.kelvinButton.UseVisualStyleBackColor = true;
            // 
            // temperatureTypeGroupBox
            // 
            this.temperatureTypeGroupBox.Controls.Add(this.celsiusButton);
            this.temperatureTypeGroupBox.Controls.Add(this.kelvinButton);
            this.temperatureTypeGroupBox.Location = new System.Drawing.Point(788, 54);
            this.temperatureTypeGroupBox.Name = "temperatureTypeGroupBox";
            this.temperatureTypeGroupBox.Size = new System.Drawing.Size(250, 196);
            this.temperatureTypeGroupBox.TabIndex = 10;
            this.temperatureTypeGroupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 731);
            this.Controls.Add(this.temperatureTypeGroupBox);
            this.Controls.Add(this.vierzehnTageButton);
            this.Controls.Add(this.dreiTageButton);
            this.Controls.Add(this.stuendlichButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.outputfield);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.userinputfield);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.temperatureTypeGroupBox.ResumeLayout(false);
            this.temperatureTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userinputfield;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox outputfield;
        private System.Windows.Forms.RadioButton easyButton;
        private System.Windows.Forms.RadioButton stuendlichButton;
        private System.Windows.Forms.RadioButton dreiTageButton;
        private System.Windows.Forms.RadioButton vierzehnTageButton;
        private System.Windows.Forms.RadioButton celsiusButton;
        private System.Windows.Forms.RadioButton kelvinButton;
        private System.Windows.Forms.GroupBox temperatureTypeGroupBox;
    }
}

