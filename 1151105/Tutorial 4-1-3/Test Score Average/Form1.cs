using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    /// <summary>
    /// 測驗分數平均值計算表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立表單並初始化元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算三個測驗分數的平均值及等級。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定及格分數。
            const double passingScore = 60.0;

            double test1;
            double test2;
            double test3;
            double average;
            string grade;

            try
            {
                // 讀取三個輸入框的分數。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三個分數的平均值。
                average = (test1 + test2 + test3) / 3.0;

                // 顯示平均分數，保留一位小數。
                averageLabel.Text = average.ToString("F1");

                // 根據平均分數判斷成績等級。
                if (average >= 80 && average < 90)
                {
                    grade = "B";
                }
                else if (average >= 90)
                {
                    grade = "A";
                }
                else if (average >= 70 && average < 80)
                {
                    grade = "C";
                }
                else if (average >= 60 && average < 70)
                {
                    grade = "D";
                }
                else
                {
                    grade = "F";



                }
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字分數。", "輸入錯誤");
            }
        }

        /// <summary>
        /// 清除所有輸入內容及平均分數。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個分數輸入框。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";

            // 清除平均分數。
            averageLabel.Text = "";

            // 將游標移回第一個輸入框。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 關閉目前的表單。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗。
            Close();
        }

        /// <summary>
        /// 處理平均分數標籤的點擊事件。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void averageLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
