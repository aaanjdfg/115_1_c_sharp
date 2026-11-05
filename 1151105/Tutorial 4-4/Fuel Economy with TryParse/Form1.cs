using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        private object kmTextBox;
        private object litersTextBox;

        /// <summary>
        /// 建立表單並初始化所有元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下計算按鈕時執行。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;// 儲存公里數。
            double liters;// 儲存公升數。
            double kmpl;// 儲存每加侖英里數。

            if (!double.TryParse(kmTextBox.Text, out km))
            {
                return;
            }
            if (double.TryParse(litersTextBox.Text, out liters))
            {
                kmpl = km / liters;// 計算每加侖英里數。
                mpgLabel.Text = kmpl.ToString("F2");// 將每加侖英里數格式化為小數點後兩位。
            }
            else
            {
                MessageBox.Show("請輸入有效的公升數。");
            }
        }

        /// <summary>
        /// 按下離開按鈕時執行。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }

        private void gallonsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
