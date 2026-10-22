// originalPriceTextBox
this.originalPriceTextBox.Location = new System.Drawing.Point(190, 16);
this.originalPriceTextBox.Size = new System.Drawing.Size(100, 20);
this.originalPriceTextBox.Text = "";

// discountPercentageTextBox
this.discountPercentageTextBox.Location = new System.Drawing.Point(190, 48);
this.discountPercentageTextBox.Size = new System.Drawing.Size(100, 20);
this.discountPercentageTextBox.Text = "";

                // originalPricePromptLabel
this.originalPricePromptLabel.AutoSize = true;
this.originalPricePromptLabel.Location = new System.Drawing.Point(20, 19);
this.originalPricePromptLabel.Text = "請輸入商品原價：";

// discPercentagePromptLabel
this.discPercentagePromptLabel.AutoSize = true;
this.discPercentagePromptLabel.Location = new System.Drawing.Point(20, 51);
this.discPercentagePromptLabel.Text = "請輸入折扣百分比：";

// outputDescriptionLabel
this.outputDescriptionLabel.AutoSize = true;
this.outputDescriptionLabel.Location = new System.Drawing.Point(125, 91);
this.outputDescriptionLabel.Text = "特價：";

// salePriceLabel
this.salePriceLabel.Location = new System.Drawing.Point(190, 86);
this.salePriceLabel.Size = new System.Drawing.Size(100, 23);
this.salePriceLabel.Text = "";

// calculateButton
this.calculateButton.Location = new System.Drawing.Point(45, 135);
this.calculateButton.Size = new System.Drawing.Size(110, 39);
this.calculateButton.Text = "計算特價";

// exitButton
this.exitButton.Location = new System.Drawing.Point(170, 135);
this.exitButton.Size = new System.Drawing.Size(75, 39);
this.exitButton.Text = "離開";

// Form1
this.ClientSize = new System.Drawing.Size(330, 195);
this.Text = "特價計算器";