using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }


        event EventHandler onSelect;
        public int id { get; set; }

        public string name
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string age
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public string phone
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
        public string address
        {
            get { return label8.Text; }
            set { label8.Text = value; }
        }







        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
