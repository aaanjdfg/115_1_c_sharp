using System;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FiveCents = 0.05m; // 五分硬幣的金額。
        const decimal TenCents = 0.10m; // 十分硬幣的金額。
        const decimal TwentyFiveCents = 0.25m; // 二十五分硬幣的金額。
        const decimal FiftyCents = 0.50m; // 五十分硬幣的金額。
        private decimal total = 0.0m; // 總金額。
        public Form1()
        {
            // 初始化表單元件。
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
           total += FiveCents; // 將五分硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C"); // 更新總金額標籤的文字，格式化為貨幣形式。
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TenCents; // 將十分硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C"); // 更新總金額標籤的文字，格式化為貨幣形式。
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TwentyFiveCents; // 將二十五分硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C"); // 更新總金額標籤的文字，格式化為貨幣形式。
            // 處理點選二十五分硬幣的事件。
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FiftyCents; // 將五十分硬幣的金額加到總金額中。
            totalLabel.Text = total.ToString("C"); // 更新總金額標籤的文字，格式化為貨幣形式。
            // 處理點選五十分硬幣的事件。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
