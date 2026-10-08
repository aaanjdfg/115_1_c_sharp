using System.Diagnostics.Metrics;

namespace tutorial2_4
{
    public partial class Form1 : Form
    {
        private object countryLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void FINLANDpictureBox3_Click(object sender, EventArgs e)
        {
            lCOUNTRY.Text = "瑞士";
        }

        private void FRANCEpictureBox1_Click(object sender, EventArgs e)
        {
            lCOUNTRY.Text = "義大利";

        }

        private void GERMANpictureBox2_Click(object sender, EventArgs e)
        {
            lCOUNTRY.Text = "德國";
        }
    }
}
