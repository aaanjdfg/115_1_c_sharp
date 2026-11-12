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
            string city;
            if (cityListBox.SelectedIndex != -1)
            {
                city= cityListBox.SelectedItem.ToString();
            
                switch (city)
                {
                    case"丹佛":
                        timeZoneLabel.Text = "山區時間";
                        break;  
                    case"檀香山":
                        timeZoneLabel.Text = "夏威夷時間";
                        break;
                    case"明尼阿波利斯":
                        timeZoneLabel.Text = "中部時間";
                        break;
                    case"紐約":
                        timeZoneLabel.Text = "東部時間";
                        break;
                    case"舊金山":
                        timeZoneLabel.Text = "太平洋時間";
                        break;
                }
            }
            else
            {
                MessageBox.Show("請選擇一個城市。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cityListBox.Items.Add("水牛城");
        }

        private void c_Click(object sender, EventArgs e)
        {
            cityListBox.Items.Clear();
        }
    }
}
