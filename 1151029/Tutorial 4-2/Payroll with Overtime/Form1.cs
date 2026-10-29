using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int baseHours = 40; // Base hours for regular pay
            const decimal overtimeRate = 1.5m; // Overtime pay rate
            decimal hoursWorked; // To hold the number of hours worked
            decimal hourlyPayRate; // To hold the hourly pay rate
            decimal grossPay; // To hold the gross pay

            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= baseHours)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - baseHours;
                    grossPay = (baseHours * hourlyPayRate) + (overtimeHours * hourlyPayRate * overtimeRate);
                }
                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void hoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
