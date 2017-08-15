using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        //PRIVATE INSTANCE VARIABLE

        private double _weight;

        private double _height;

        private double _result;


        //PUBLIC PROPERTIES

        public double Weight
        {

            get
            {
                return this._weight;
            }

            set
            {
                this._weight = value;
            }

        }

        public new double Height
        {

            get
            {
                return this._height;
            }

            set
            {
                this._height = value;
            }

        }

        public double Result
        {

            get
            {
                return this._result;
            }

            set
            {
                this._result = value;
            }

        }


        //CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the BMICalculator class
        /// </summary>

        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is the Event handler for "CalculateBMIButton" that performs the calculations for both imperical measurements
        /// and metric measurements.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            Weight = double.Parse(MyWeightTextBox.Text);
            Height = double.Parse(MyHeightTextBox.Text);

            if (MetricRadioButton.Checked == true)
            {
                Result = Weight / (Height * Height);
            }
            if(ImperialRadioButton.Checked == true)
            {
                Result = (Weight * 703) / (Height * Height);
            }
            
            MultilineTextBox.Multiline = true;
            MultilineTextBox.Clear();
            MultilineTextBox.Text += "BMI SCALE   || RESULT" + Environment.NewLine;
            MultilineTextBox.Text += "Underweight  || less than 18.5" + Environment.NewLine;
            MultilineTextBox.Text += "Normal           || between 18.5 and 24.9" + Environment.NewLine;
            MultilineTextBox.Text += "Overweight    || between 25 and 29.9" + Environment.NewLine;
            MultilineTextBox.Text += "Obese            || 30 or greater" + Environment.NewLine;

            ResultTextBox.Text = string.Format("{0}", Result);
           
        }


        /// <summary>
        /// This is the 'KeyPress' Event Handler for "MyWeightTextBox".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MyWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This is the 'KeyPress' Event Handler for "MyHeightTextBox".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MyHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
       
    }
}
