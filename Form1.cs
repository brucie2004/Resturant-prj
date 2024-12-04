using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void addForm(Form form)
        {
            panel3.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel3.Controls.Add(form);
            form.Show();
        }
        public bool validateIsNumber(string test)
        {
            int tab;
            if (!int.TryParse(test, out tab))
            {
                MessageBox.Show("please enter number and nothing else", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }




        }
        public bool validateIsNull(string test)
        {
            if (test == "")
            {
                MessageBox.Show("all fields are Required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
                return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tablebtn_Click(object sender, EventArgs e)
        {
            addForm(new tables());
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            addForm(new orderfrm());
        }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
            addForm(new Home());
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            addForm(new emp());
        }

        private void fodrbtn_Click(object sender, EventArgs e)
        {
            addForm(new food());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            addForm(new Home());


        }
    }
}
