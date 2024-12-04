namespace Restaurant_Project
{
    public partial class UserControl3 : UserControl
    {
        Form1 Form1;
        food food;
        public UserControl3(food myfood)
        {
            InitializeComponent();
            food = myfood;
        }

        public int id { get; set; }

        public string catname
        {
            get { return CatName.Text; }
            set { CatName.Text = value; }
        }
        public string fname
        {
            get { return FName.Text; }
            set { FName.Text = value; }
        }
        public string count
        {
            get { return Count.Text; }
            set { Count.Text = value; }
        }
        public string fprice
        {
            get { return Fprice.Text; }
            set { Fprice.Text = value; }
        }





        private void catname_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void minbutton_Click(object sender, EventArgs e)
        {
            Minus_Quantitiy minus_Quantitiy = new Minus_Quantitiy(food, id);
            minus_Quantitiy.Show();

        }

        private void plusbutton_Click(object sender, EventArgs e)
        {

            Add_Quantitiy add_Quantitiy = new Add_Quantitiy(food, id);
            add_Quantitiy.Show();



        }
    }
}
