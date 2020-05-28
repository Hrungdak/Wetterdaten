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
            this.SuspendLayout();
            // 
            // userinputfield
            // 
            this.userinputfield.Location = new System.Drawing.Point(237, 151);
            this.userinputfield.Name = "userinputfield";
            this.userinputfield.Size = new System.Drawing.Size(392, 35);
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
            this.exitbutton.Location = new System.Drawing.Point(12, 549);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(127, 57);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // outputfield
            // 
            this.outputfield.Location = new System.Drawing.Point(237, 280);
            this.outputfield.Multiline = true;
            this.outputfield.Name = "outputfield";
            this.outputfield.ReadOnly = true;
            this.outputfield.Size = new System.Drawing.Size(405, 129);
            this.outputfield.TabIndex = 3;
            this.outputfield.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 731);
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
    }
}

