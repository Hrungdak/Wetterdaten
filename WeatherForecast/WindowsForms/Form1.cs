using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functionalities;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            WeatherData weatherData = new WeatherData();
            outputfield.Text = weatherData.GetWeatherForecastForZip(int.Parse(userinputfield.Text));
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}