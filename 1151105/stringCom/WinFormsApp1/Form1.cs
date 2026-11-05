using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool CompareStrings(string firstString, string secondString)
        {
            return string.Equals(
                firstString,
                secondString,
                StringComparison.Ordinal);
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            bool isEqual = CompareStrings(
                inputString1TextBox.Text,
                inputString2TextBox.Text);

            string resultMessage = isEqual
                ? "兩個字串相同。"
                : "兩個字串不同。";

            MessageBox.Show(
                resultMessage,
                "比較結果",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
