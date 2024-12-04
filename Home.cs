namespace Restaurant_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!label1.Visible)
            {
                label1.Visible = true;
                return;
            }
            if (!label2.Visible)
            {
                label2.Visible = true;
                return;
            }
            if (!label3.Visible)
            {
                label3.Visible = true;
                return;
            }
            if (!label4.Visible)
            {
                label4.Visible = true;
                return;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
