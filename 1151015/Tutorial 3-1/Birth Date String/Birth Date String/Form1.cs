using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    /// <summary>
    /// 主表單：處理使用者輸入（星期、月份、日、年）並顯示組合後的日期字串。
    /// 事件處理方法由設計器註冊（按鈕點擊事件）。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件（由設計器自動產生的 InitializeComponent）。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 顯示按鈕事件：讀取輸入欄位內容並在輸出 Label 顯示組合後的日期字串。
        /// </summary>
        /// <param name="sender">事件來源（按鈕物件）</param>
        /// <param name="e">事件參數</param>
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // 讀取使用者輸入（未修改原本邏輯，僅讀取文字）
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            // 將輸入組合成中文格式顯示在 dateOutputLabel（例如：2026年一月 15日，星期一）
            dateOutputLabel.Text = $"您輸入的日期是: {year}年{month} {dayOfMonth}日，星期{dayOfWeek}";
        }

        /// <summary>
        /// 清除按鈕事件：清除所有輸入欄位與輸出顯示。
        /// </summary>
        /// <param name="sender">事件來源（按鈕物件）</param>
        /// <param name="e">事件參數</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空所有 TextBox 與輸出 Label
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();
            dateOutputLabel.Text = string.Empty;
        }

        /// <summary>
        /// 離開按鈕事件：關閉表單（結束應用程式視窗）。
        /// </summary>
        /// <param name="sender">事件來源（按鈕物件）</param>
        /// <param name="e">事件參數</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式
            this.Close();
        }

        private void dayOfMonthPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
