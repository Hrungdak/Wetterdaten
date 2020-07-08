using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class GreetingUser : Form
    {
        private Form1 mainForm;
        private string _userName;

        public GreetingUser(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (usernameInputTextbox.Text != string.Empty)
            {
                Settings.Default.userName = usernameInputTextbox.Text;
                Settings.Default.Save();
            }
            mainForm.Visible = true;
            mainForm.Opacity = 100;
            this.Hide();
        }

        private void GreetingUser_Load(object sender, EventArgs e)
        {
            GetUserName();
            if (_userName == null || _userName == string.Empty)
            {
                usernameInputTextbox.Text = _userName;
            }
            else
            {
                usernameInputTextbox.Visible = false;
            }
            greetLabel.Text = "Hello " + _userName;
        }

        private void GetUserName()
        {
            _userName = Settings.Default.userName;
        }
    }
}