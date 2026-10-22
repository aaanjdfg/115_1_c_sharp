namespace Fuel_Economy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = false;
            this.milesPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.milesPromptLabel.Location = new System.Drawing.Point(20, 25);
            this.milesPromptLabel.Size = new System.Drawing.Size(330, 30);
            this.milesPromptLabel.Text = "輸入行駛公里數：";
            this.milesPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = false;
            this.gallonsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gallonsPromptLabel.Location = new System.Drawing.Point(20, 70);
            this.gallonsPromptLabel.Size = new System.Drawing.Size(330, 30);
            this.gallonsPromptLabel.Text = "輸入使用的汽油公升數：";
            this.gallonsPromptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.milesTextBox.Location = new System.Drawing.Point(370, 25);
            this.milesTextBox.Size = new System.Drawing.Size(150, 30);
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gallonsTextBox.Location = new System.Drawing.Point(370, 70);
            this.gallonsTextBox.Size = new System.Drawing.Size(150, 30);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = false;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 115);
            this.outputDescriptionLabel.Size = new System.Drawing.Size(330, 30);
            this.outputDescriptionLabel.Text = "每公升行駛公里數：";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mpgLabel
            // 
            this.mpgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mpgLabel.Location = new System.Drawing.Point(370, 115);
            this.mpgLabel.Size = new System.Drawing.Size(150, 30);
            this.mpgLabel.TabIndex = 5;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateButton.Location = new System.Drawing.Point(140, 180);
            this.calculateButton.Size = new System.Drawing.Size(120, 40);
            this.calculateButton.Text = "計算 km/L";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(300, 180);
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(560, 260);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form1";
            this.Text = "油耗計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
                            
        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

