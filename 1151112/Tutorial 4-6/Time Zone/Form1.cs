using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立表單並初始化所有控制項。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「確定」按鈕時執行。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            // 取得使用者選取的城市。
            string selectedCity = cityListBox.SelectedItem?.ToString();

            // 如果沒有選取城市，則顯示提醒訊息。
            if (string.IsNullOrEmpty(selectedCity))
            {
                MessageBox.Show(
                    "請先選擇一個城市。",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // 顯示所選城市的時區資訊。
            timeZoneLabel.Text = $"{selectedCity}的時區";
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉表單。
        /// </summary>
        /// <param name="sender">觸發事件的控制項。</param>
        /// <param name="e">事件資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            Close();
        }
    }
}
