namespace Birth_Date_String
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，則表示釋放受控資源。</param>
        protected override void Dispose(bool disposing)
        {
            // 如果正在釋放受控資源，則一併釋放 components
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code                                                            

        /// <summary>
        /// 初始化元件 - 設定所有控制項的屬性與事件處理器。
        /// 注意：此方法通常由設計器自動產生/維護，手動修改請小心。
        /// </summary>
        private void InitializeComponent()
        {
            // TextBox：輸入星期（文字）
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            // TextBox：輸入月份名稱（文字）
            this.monthTextBox = new System.Windows.Forms.TextBox();
            // TextBox：輸入月份中的日期（數字）
            this.dayOfMonthTextBox = new System.Windows.Forms.TextBox();
            // TextBox：輸入年份（數字）
            this.yearTextBox = new System.Windows.Forms.TextBox();
            // Label：提示使用者輸入星期
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            // Label：提示使用者輸入月份名稱
            this.monthPromptLabel = new System.Windows.Forms.Label();
            // Label：提示使用者輸入日（數字）
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            // Label：提示使用者輸入年份
            this.yearPromptLabel = new System.Windows.Forms.Label();
            // Label：顯示組合後的日期字串（輸出）
            this.dateOutputLabel = new System.Windows.Forms.Label();
            // Button：顯示組合後的日期
            this.showDateButton = new System.Windows.Forms.Button();
            // Button：清除所有輸入與輸出
            this.clearButton = new System.Windows.Forms.Button();
            // Button：關閉表單（離開程式）
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 表單字型（套用至子控制項）
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dayOfWeekTextBox
            // 
            // 用於輸入星期（例如：星期一）
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(140, 12);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(120, 35);
            this.dayOfWeekTextBox.TabIndex = 0;
            // 
            // monthTextBox
            // 
            // 用於輸入月份名稱（例如：一月）
            this.monthTextBox.Location = new System.Drawing.Point(140, 52);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(120, 35);
            this.monthTextBox.TabIndex = 1;
            // 
            // dayOfMonthTextBox
            // 
            // 用於輸入日期（日，例如：15）
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(140, 92);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(120, 35);
            this.dayOfMonthTextBox.TabIndex = 2;
            // 
            // yearTextBox
            // 
            // 用於輸入年份（例如：2026）
            this.yearTextBox.Location = new System.Drawing.Point(140, 132);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(120, 35);
            this.yearTextBox.TabIndex = 3;
            // 
            // dayOfWeekPromptLabel
            // 
            // 提示文字：輸入星期
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(10, 16);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(120, 29);
            this.dayOfWeekPromptLabel.TabIndex = 4;
            this.dayOfWeekPromptLabel.Text = "輸入星期幾";
            // 
            // monthPromptLabel
            // 
            // 提示文字：輸入月份名稱
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(10, 56);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(148, 29);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "輸入月份名稱";
            // 
            // dayOfMonthPromptLabel
            // 
            // 提示文字：輸入日期（日）
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(10, 96);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(164, 29);
            this.dayOfMonthPromptLabel.TabIndex = 6;
            this.dayOfMonthPromptLabel.Text = "輸入日期（日）";
            // 
            // yearPromptLabel
            // 
            // 提示文字：輸入年份
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(10, 136);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(88, 29);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "輸入年份";
            // 
            // dateOutputLabel
            // 
            // 顯示結果的區域（邊框以便看出範圍）
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(10, 172);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(250, 34);
            this.dateOutputLabel.TabIndex = 8;
            this.dateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showDateButton
            // 
            // 點擊後將組合並顯示日期文字
            this.showDateButton.Location = new System.Drawing.Point(10, 210);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(80, 36);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            // 點擊後清除所有輸入與輸出顯示
            this.clearButton.Location = new System.Drawing.Point(98, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 36);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            // 點擊後關閉表單（結束程式）
            this.exitButton.Location = new System.Drawing.Point(186, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 36);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 設定表單客戶區大小與加入控制項
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 258);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Name = "Form1";
            this.Text = "出生日期字串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 控制項宣告（由設計器維護）
        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.TextBox dayOfMonthTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}