using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建立貸款資格審核表單。
        public Form1()
        {
            InitializeComponent();
        }

        // 處理「檢查資格」按鈕的按下事件。
        private void checkButton_Click(object sender, EventArgs e)
        {
            const decimal MIN_SALARY = 40000m; // 最低年薪
            const int MIN_YEARS = 2;           // 最低工作年資

            decimal salary; // 使用者輸入的年薪
            int yearsOnJob; // 使用者輸入的工作年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                if(salary >= MIN_SALARY)
                {
                    if(yearsOnJob >= 2)
                    {
                        decisionLabel.Text = "您符合貸款資格。";
                    }
                    else
                    {
                        decisionLabel.Text = "您年資不符合貸款資格。";
                    }
                }
                else
                {
                    decisionLabel.Text = "您薪資不符合貸款資格。";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 清除使用者輸入的資料與貸款審核結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除兩個文字輸入框與審核結果標籤的內容。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 清除後將輸入焦點移回年薪輸入框。
            salaryTextBox.Focus();
        }

        // 處理「離開」按鈕的按下事件。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
