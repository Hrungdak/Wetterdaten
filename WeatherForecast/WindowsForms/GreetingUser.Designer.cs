namespace WindowsForms
{
    partial class GreetingUser
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
            this.usernameInputTextbox = new System.Windows.Forms.TextBox();
            this.greetLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameInputTextbox
            // 
            this.usernameInputTextbox.Location = new System.Drawing.Point(261, 204);
            this.usernameInputTextbox.Name = "usernameInputTextbox";
            this.usernameInputTextbox.Size = new System.Drawing.Size(277, 35);
            this.usernameInputTextbox.TabIndex = 0;
            this.usernameInputTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Location = new System.Drawing.Point(362, 113);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(70, 29);
            this.greetLabel.TabIndex = 1;
            this.greetLabel.Text = "Hello";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(338, 326);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(132, 54);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // GreetingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.greetLabel);
            this.Controls.Add(this.usernameInputTextbox);
            this.Name = "GreetingUser";
            this.Text = "GreetingUser";
            this.Load += new System.EventHandler(this.GreetingUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInputTextbox;
        private System.Windows.Forms.Label greetLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}