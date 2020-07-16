using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace WindowsForms
{
    public partial class GetUserNameWindow : Form
    {
        private Form1 _mainForm;

        public GetUserNameWindow(Form1 form1)
        {
            InitializeComponent();
            _mainForm = form1;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.userName = userInput.Text;
            Properties.Settings.Default.Save();
            _mainForm.SetUserNameFromInput(userInput.Text);
            _mainForm.Visible = true;
            _mainForm.Opacity = 100;
            this.Hide();
        }
    }
}