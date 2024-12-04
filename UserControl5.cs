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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }


        public int id { get; set; }

        public string lbl
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string fname
        {
            get { return food.Text; }
            set { food.Text = value; }
        }
        public string fcount
        {
            get { return cnt.Text; }
            set { cnt.Text = value; }
        }
        public string pricee
        {
            get { return price.Text; }
            set { price.Text = value; }
        }





    }
}
