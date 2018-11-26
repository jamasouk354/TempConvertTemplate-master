/// Created by Mr. T
/// June 2013
/// To demonstrate creation of custom methods that use parameters and return values

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConvertTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double temp; // holds value inputted by the user
            double answer; // hold the converted temp

            temp = Convert.ToDouble(tempInput.Text);

            /// checks to see that conversion option has been selected and runs 
            /// appropriate custom method based on that option
            if (fahToCelButton.Checked)
            {
                answer = FtoC(temp);
                outputLabel.Text = temp + " F  =  " + answer.ToString("0.##") + " C";
            }
            else if (celToFahButton.Checked)
            {
                answer = CtoF(temp);
                outputLabel.Text = temp + " C  =  " + answer.ToString("0.##") + " F";
            }
        }
        /// <summary>
        /// Converts Fahrenheit to Celsius
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public double FtoC(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;//Method 1
        }
         
        public double CtoF(double celsius)
        {
            double fahrenheit;//Method 2
            fahrenheit = (1.8 * celsius) + 32;
            return fahrenheit;
        }
    }
}
