using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        /// 建立表單並初始化所有視覺元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算三個測驗分數的平均值。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //const double HIGH_SCORE = 95.0; // 定義最高分數常數。
            
            const double passingScore = 60.0; // 定義及格分數常數。

            double test1, test2, test3, average;

            // 讀取三個測驗分數輸入框的值，並將其轉換為 double 型別。
            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算平均分數。
                average = (test1 + test2 + test3) / 3.0;

                // 顯示平均分數，格式化為小數點後兩位。
                averageLabel.Text = average.ToString("F1");

                if (average > passingScore)
                {
                    MessageBox.Show("平均分數達及格門檻！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 顯示訊息框，提示使用者平均分數超過 95 分。
                    //MessageBox.Show("平均分數達高分門檻！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("平均分數未達及格門檻！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // 顯示訊息框，提示使用者平均分數未達及格門檻。
                }
            }
            catch (Exception ex) 
                {
                    // 顯示錯誤訊息。
                    MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        /// <summary>
        /// 清除三個輸入框及平均分數顯示內容。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個測驗分數輸入框。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";

            // 清除平均分數顯示內容。
            averageLabel.Text = "";

            // 將輸入焦點移回第一個測驗分數輸入框。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 關閉目前的表單。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的視窗。
            this.Close();
        }

        private void averageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
