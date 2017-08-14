using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Sahal Mohamed.
 * Student Number: 300895007.
 * Date Last Modified: August/15/2017.
 * Description: This is Assignment 5 of COMP123: BMI Calculator.
 */

namespace BMICalculator
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
