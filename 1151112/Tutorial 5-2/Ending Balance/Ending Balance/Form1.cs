using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureFormLayout();
        }

        private void ConfigureFormLayout()
        {
            Font formFont = new Font(
                "Microsoft JhengHei UI",
                18F,
                FontStyle.Regular,
                GraphicsUnit.Point);

            this.Font = formFont;
            this.Text = "期末餘額計算";
            this.ClientSize = new Size(620, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Font;

            foreach (Control control in Controls)
            {
                control.Font = formFont;
            }

            startingBalancePromptLabel.Text = "起始餘額：";
            startingBalancePromptLabel.AutoSize = true;
            startingBalancePromptLabel.Location = new Point(30, 30);

            startingBalTextBox.Text = string.Empty;
            startingBalTextBox.Location = new Point(250, 22);
            startingBalTextBox.Size = new Size(330, 45);

            monthsPromptLabel.Text = "月份數量：";
            monthsPromptLabel.AutoSize = true;
            monthsPromptLabel.Location = new Point(30, 95);

            monthsTextBox.Text = string.Empty;
            monthsTextBox.Location = new Point(250, 87);
            monthsTextBox.Size = new Size(330, 45);

            detailListBox.Location = new Point(30, 155);
            detailListBox.Size = new Size(550, 170);
            detailListBox.ItemHeight = 36;
            detailListBox.HorizontalScrollbar = true;

            outputDescriptionLabel.Text = "期末餘額：";
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(30, 350);

            endingBalanceLabel.Text = string.Empty;
            endingBalanceLabel.Location = new Point(250, 342);
            endingBalanceLabel.Size = new Size(330, 48);
            endingBalanceLabel.TextAlign = ContentAlignment.MiddleCenter;

            calculateButton.Text = "計算";
            calculateButton.Location = new Point(30, 410);
            calculateButton.Size = new Size(170, 48);

            clearButton.Text = "清除";
            clearButton.Location = new Point(220, 410);
            clearButton.Size = new Size(170, 48);

            exitButton.Text = "離開";
            exitButton.Location = new Point(410, 410);
            exitButton.Size = new Size(170, 48);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal RATE = 0.005m;
            decimal balance;
            int months;

            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    int count = 1;
                    while (count <= months)
                    {
                        balance = balance * (1 + RATE);
                        detailListBox.Items.Add($"第{count}個月的本利和: {balance:C2}");
                        count = count + 1;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額。");
            }
        }
        
         

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void startingBalancePromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
