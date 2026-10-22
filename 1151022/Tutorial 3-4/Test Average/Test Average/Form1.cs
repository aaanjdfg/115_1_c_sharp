using System;
using System.Windows.Forms;

namespace Test_Average
{
    /// <summary>
    /// 測驗平均分數表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立表單並初始化表單元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算三次測驗成績的平均分數。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 取得第一次測驗成績並轉換為 double 型別。
                double test1 = double.Parse(test1TextBox.Text);

                // 取得第二次測驗成績並轉換為 double 型別。
                double test2 = double.Parse(test2TextBox.Text);

                // 取得第三次測驗成績並轉換為 double 型別。
                double test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗成績的平均分數。
                double average = (test1 + test2 + test3) / 3;

                // 將平均分數格式化為一位小數並顯示在結果標籤中。
                averageLabel.Text = average.ToString("F1");
            }
            catch (FormatException)
            {
                // 輸入內容不是有效的數字時，顯示錯誤訊息。
                MessageBox.Show(
                    "請輸入有效的測驗成績。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                // 輸入數值超出 double 可表示的範圍時，顯示錯誤訊息。
                MessageBox.Show(
                    "輸入的數值超出可接受的範圍。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 清除所有測驗成績與平均分數。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三次測驗的輸入內容。
            test1TextBox.Text = string.Empty;
            test2TextBox.Text = string.Empty;
            test3TextBox.Text = string.Empty;

            // 清除平均分數的顯示內容。
            averageLabel.Text = string.Empty;
        }

        /// <summary>
        /// 關閉目前的表單。
        /// </summary>
        /// <param name="sender">觸發事件的物件。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            Close();
        }
    }
}
