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
            this.heuteEinfachButton = new System.Windows.Forms.RadioButton();
            this.heuteStuendlichButton = new System.Windows.Forms.RadioButton();
            this.dreiTageButton = new System.Windows.Forms.RadioButton();
            this.vierzehnTageButton = new System.Windows.Forms.RadioButton();
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
            this.outputfield.Size = new System.Drawing.Size(405, 129);
            this.outputfield.TabIndex = 3;
            this.outputfield.Text = "Result";
            // 
            // heuteEinfachButton
            // 
            this.heuteEinfachButton.AutoSize = true;
            this.heuteEinfachButton.Checked = true;
            this.heuteEinfachButton.Location = new System.Drawing.Point(12, 98);
            this.heuteEinfachButton.Name = "heuteEinfachButton";
            this.heuteEinfachButton.Size = new System.Drawing.Size(193, 33);
            this.heuteEinfachButton.TabIndex = 4;
            this.heuteEinfachButton.TabStop = true;
            this.heuteEinfachButton.Text = "Heute Einfach";
            this.heuteEinfachButton.UseVisualStyleBackColor = true;
            // 
            // heuteStuendlichButton
            // 
            this.heuteStuendlichButton.AutoSize = true;
            this.heuteStuendlichButton.Location = new System.Drawing.Point(12, 156);
            this.heuteStuendlichButton.Name = "heuteStuendlichButton";
            this.heuteStuendlichButton.Size = new System.Drawing.Size(213, 33);
            this.heuteStuendlichButton.TabIndex = 5;
            this.heuteStuendlichButton.TabStop = true;
            this.heuteStuendlichButton.Text = "Heute Stündlich";
            this.heuteStuendlichButton.UseVisualStyleBackColor = true;
            // 
            // dreiTageButton
            // 
            this.dreiTageButton.AutoSize = true;
            this.dreiTageButton.Location = new System.Drawing.Point(12, 217);
            this.dreiTageButton.Name = "dreiTageButton";
            this.dreiTageButton.Size = new System.Drawing.Size(120, 33);
            this.dreiTageButton.TabIndex = 6;
            this.dreiTageButton.TabStop = true;
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
            this.vierzehnTageButton.TabStop = true;
            this.vierzehnTageButton.Text = "14 Tage";
            this.vierzehnTageButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 731);
            this.Controls.Add(this.vierzehnTageButton);
            this.Controls.Add(this.dreiTageButton);
            this.Controls.Add(this.heuteStuendlichButton);
            this.Controls.Add(this.heuteEinfachButton);
            this.Controls.Add(this.outputfield);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.userinputfield);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userinputfield;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox outputfield;
        private System.Windows.Forms.RadioButton heuteEinfachButton;
        private System.Windows.Forms.RadioButton heuteStuendlichButton;
        private System.Windows.Forms.RadioButton dreiTageButton;
        private System.Windows.Forms.RadioButton vierzehnTageButton;
    }
}

