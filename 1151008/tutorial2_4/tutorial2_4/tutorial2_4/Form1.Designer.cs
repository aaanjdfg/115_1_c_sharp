namespace tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            FRANCEpictureBox1 = new PictureBox();
            GERMANpictureBox2 = new PictureBox();
            FINLANDpictureBox3 = new PictureBox();
            lCOUNTRY = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)FRANCEpictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GERMANpictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FINLANDpictureBox3).BeginInit();
            SuspendLayout();
            // 
            // FRANCEpictureBox1
            // 
            FRANCEpictureBox1.Image = (Image)resources.GetObject("FRANCEpictureBox1.Image");
            FRANCEpictureBox1.InitialImage = (Image)resources.GetObject("FRANCEpictureBox1.InitialImage");
            FRANCEpictureBox1.Location = new Point(293, 112);
            FRANCEpictureBox1.Name = "FRANCEpictureBox1";
            FRANCEpictureBox1.Size = new Size(220, 126);
            FRANCEpictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            FRANCEpictureBox1.TabIndex = 0;
            FRANCEpictureBox1.TabStop = false;
            FRANCEpictureBox1.Click += FRANCEpictureBox1_Click;
            // 
            // GERMANpictureBox2
            // 
            GERMANpictureBox2.Image = (Image)resources.GetObject("GERMANpictureBox2.Image");
            GERMANpictureBox2.InitialImage = (Image)resources.GetObject("GERMANpictureBox2.InitialImage");
            GERMANpictureBox2.Location = new Point(549, 112);
            GERMANpictureBox2.Name = "GERMANpictureBox2";
            GERMANpictureBox2.Size = new Size(217, 126);
            GERMANpictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            GERMANpictureBox2.TabIndex = 1;
            GERMANpictureBox2.TabStop = false;
            GERMANpictureBox2.Click += GERMANpictureBox2_Click;
            // 
            // FINLANDpictureBox3
            // 
            FINLANDpictureBox3.Image = (Image)resources.GetObject("FINLANDpictureBox3.Image");
            FINLANDpictureBox3.InitialImage = (Image)resources.GetObject("FINLANDpictureBox3.InitialImage");
            FINLANDpictureBox3.Location = new Point(48, 112);
            FINLANDpictureBox3.Name = "FINLANDpictureBox3";
            FINLANDpictureBox3.Size = new Size(216, 126);
            FINLANDpictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            FINLANDpictureBox3.TabIndex = 2;
            FINLANDpictureBox3.TabStop = false;
            FINLANDpictureBox3.Click += FINLANDpictureBox3_Click;
            // 
            // lCOUNTRY
            // 
            lCOUNTRY.BorderStyle = BorderStyle.FixedSingle;
            lCOUNTRY.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lCOUNTRY.Location = new Point(314, 297);
            lCOUNTRY.Name = "lCOUNTRY";
            lCOUNTRY.Size = new Size(184, 75);
            lCOUNTRY.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.CausesValidation = false;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(136, 49);
            label1.Name = "label1";
            label1.Size = new Size(575, 60);
            label1.TabIndex = 4;
            label1.Text = "點選一個國旗我告訴你是什麼國家";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lCOUNTRY);
            Controls.Add(FINLANDpictureBox3);
            Controls.Add(GERMANpictureBox2);
            Controls.Add(FRANCEpictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FRANCEpictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GERMANpictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)FINLANDpictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox FRANCEpictureBox1;
        private PictureBox GERMANpictureBox2;
        private PictureBox FINLANDpictureBox3;
        private Label lCOUNTRY;
        private Label label1;
    }
}
