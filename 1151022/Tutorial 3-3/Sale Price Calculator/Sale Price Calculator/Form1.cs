using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項
            InitializeComponent();

            // 設定表單標題與大小
            this.Text = "特價計算器";
            this.ClientSize = new Size(330, 195);

            // 設定商品原價提示文字與位置
            this.originalPricePromptLabel.Text = "請輸入商品原價：";
            this.originalPricePromptLabel.Location = new Point(20, 19);

            // 設定商品原價輸入框的位置與大小
            this.originalPriceTextBox.Text = "";
            this.originalPriceTextBox.Location = new Point(190, 16);
            this.originalPriceTextBox.Size = new Size(100, 20);

            // 設定折扣百分比提示文字與位置
            this.discPercentagePromptLabel.Text = "請輸入折扣百分比：";
            this.discPercentagePromptLabel.Location = new Point(20, 51);

            // 設定折扣百分比輸入框的位置與大小
            this.discountPercentageTextBox.Text = "";
            this.discountPercentageTextBox.Location = new Point(190, 48);
            this.discountPercentageTextBox.Size = new Size(100, 20);

            // 設定計算結果提示文字與位置
            this.outputDescriptionLabel.Text = "特價：";
            this.outputDescriptionLabel.Location = new Point(125, 91);

            // 設定計算結果標籤的位置與大小
            this.salePriceLabel.Text = "";
            this.salePriceLabel.Location = new Point(190, 86);
            this.salePriceLabel.Size = new Size(100, 23);

            // 設定計算特價按鈕的文字、位置與大小
            this.calculateButton.Text = "計算特價";
            this.calculateButton.Location = new Point(45, 135);
            this.calculateButton.Size = new Size(110, 39);

            // 設定離開按鈕的文字、位置與大小
            this.exitButton.Text = "離開";
            this.exitButton.Location = new Point(170, 135);
            this.exitButton.Size = new Size(75, 39);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 將商品原價文字轉換成數字
            if (!decimal.TryParse(
                this.originalPriceTextBox.Text,
                out originalPrice))
            {
                MessageBox.Show(
                    "請輸入有效的商品原價。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.originalPriceTextBox.Focus();
                return;
            }

            // 將折扣百分比文字轉換成數字
            if (!decimal.TryParse(
                this.discountPercentageTextBox.Text,
                out discountPercentage))
            {
                MessageBox.Show(
                    "請輸入有效的折扣百分比。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.discountPercentageTextBox.Focus();
                return;
            }

            // 檢查商品原價是否小於零
            if (originalPrice < 0)
            {
                MessageBox.Show(
                    "商品原價不可小於零。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.originalPriceTextBox.Focus();
                return;
            }

            // 檢查折扣百分比是否介於 0 到 100 之間
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show(
                    "折扣百分比必須介於 0 到 100 之間。",
                    "輸入錯誤",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.discountPercentageTextBox.Focus();
                return;
            }

            // 計算商品特價
            salePrice = originalPrice
                - originalPrice * discountPercentage / 100;

            // 顯示計算結果，並保留小數點後兩位
            this.salePriceLabel.Text = salePrice.ToString("N2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單
            this.Close();
        }

        private void originalPricePromptLabel_Click(
            object sender,
            EventArgs e)
        {
            // 點選提示文字時不執行任何動作
        }

        private void salePriceLabel_Click(
            object sender,
            EventArgs e)
        {
            // 點選計算結果時不執行任何動作
        }

        private void originalPriceTextBox_TextChanged(
            object sender,
            EventArgs e)
        {
            // 商品原價內容變更時不執行其他動作
        }

        private void discountPercentageTextBox_TextChanged(
            object sender,
            EventArgs e)
        {
            // 移除折扣百分比中的百分比符號
            this.discountPercentageTextBox.Text =
                this.discountPercentageTextBox.Text.Replace("%", "");

            // 將游標移到文字最後方
            this.discountPercentageTextBox.SelectionStart =
                this.discountPercentageTextBox.Text.Length;
        }
    }
}
