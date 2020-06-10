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
            this.hourlyButton = new System.Windows.Forms.RadioButton();
            this.threeDayButton = new System.Windows.Forms.RadioButton();
            this.fourteenDayButton = new System.Windows.Forms.RadioButton();
            this.celsiusButton = new System.Windows.Forms.RadioButton();
            this.kelvinButton = new System.Windows.Forms.RadioButton();
            this.temperatureTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temperatureTypeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.searchbutton.Location = new System.Drawing.Point(724, 198);
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
            this.outputfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputfield.Location = new System.Drawing.Point(276, 288);
            this.outputfield.Multiline = true;
            this.outputfield.Name = "outputfield";
            this.outputfield.ReadOnly = true;
            this.outputfield.Size = new System.Drawing.Size(893, 359);
            this.outputfield.TabIndex = 3;
            this.outputfield.Text = "Result";
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.Checked = true;
            this.easyButton.Location = new System.Drawing.Point(17, 51);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(123, 33);
            this.easyButton.TabIndex = 4;
            this.easyButton.TabStop = true;
            this.easyButton.Text = "Einfach";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // hourlyButton
            // 
            this.hourlyButton.AutoSize = true;
            this.hourlyButton.Location = new System.Drawing.Point(17, 99);
            this.hourlyButton.Name = "hourlyButton";
            this.hourlyButton.Size = new System.Drawing.Size(143, 33);
            this.hourlyButton.TabIndex = 5;
            this.hourlyButton.Text = "Stündlich";
            this.hourlyButton.UseVisualStyleBackColor = true;
            // 
            // threeDayButton
            // 
            this.threeDayButton.AutoSize = true;
            this.threeDayButton.Location = new System.Drawing.Point(17, 148);
            this.threeDayButton.Name = "threeDayButton";
            this.threeDayButton.Size = new System.Drawing.Size(120, 33);
            this.threeDayButton.TabIndex = 6;
            this.threeDayButton.Text = "3 Tage";
            this.threeDayButton.UseVisualStyleBackColor = true;
            // 
            // fourteenDayButton
            // 
            this.fourteenDayButton.AutoSize = true;
            this.fourteenDayButton.Location = new System.Drawing.Point(17, 205);
            this.fourteenDayButton.Name = "fourteenDayButton";
            this.fourteenDayButton.Size = new System.Drawing.Size(133, 33);
            this.fourteenDayButton.TabIndex = 7;
            this.fourteenDayButton.Text = "14 Tage";
            this.fourteenDayButton.UseVisualStyleBackColor = true;
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
            this.temperatureTypeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temperatureTypeGroupBox.Controls.Add(this.celsiusButton);
            this.temperatureTypeGroupBox.Controls.Add(this.kelvinButton);
            this.temperatureTypeGroupBox.Location = new System.Drawing.Point(919, 54);
            this.temperatureTypeGroupBox.Name = "temperatureTypeGroupBox";
            this.temperatureTypeGroupBox.Size = new System.Drawing.Size(250, 196);
            this.temperatureTypeGroupBox.TabIndex = 10;
            this.temperatureTypeGroupBox.TabStop = false;
            this.temperatureTypeGroupBox.Text = "Temperature Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.easyButton);
            this.groupBox1.Controls.Add(this.hourlyButton);
            this.groupBox1.Controls.Add(this.fourteenDayButton);
            this.groupBox1.Controls.Add(this.threeDayButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 295);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forecast Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 861);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.temperatureTypeGroupBox);
            this.Controls.Add(this.outputfield);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.userinputfield);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.temperatureTypeGroupBox.ResumeLayout(false);
            this.temperatureTypeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userinputfield;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox outputfield;
        private System.Windows.Forms.RadioButton easyButton;
        private System.Windows.Forms.RadioButton hourlyButton;
        private System.Windows.Forms.RadioButton threeDayButton;
        private System.Windows.Forms.RadioButton fourteenDayButton;
        private System.Windows.Forms.RadioButton celsiusButton;
        private System.Windows.Forms.RadioButton kelvinButton;
        private System.Windows.Forms.GroupBox temperatureTypeGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

