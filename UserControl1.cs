using Guna.UI2.WinForms;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public int id { get; set; }

        public string Tnum
        {
            get { return Tlabel3.Text; }
            set { Tlabel3.Text = value; }
        }
        public string floor
        {
            get { return Flabel4.Text; }
            set { Flabel4.Text = value; }
        }
        public string state
        {
            get { return Slabel6.Text; }
            set { Slabel6.Text = value; }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (state == "Busy")
            {
                guna2Button1.FillColor = Color.Red;

            }
            else
            {
                guna2Button1.FillColor = Color.Green;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            

            var db = new AppDbContext();
            var table = db.tables.Find(id);
            if (table != null)
            {
                if (table.State)
                {
                    table.State = false;


                }
                else
                {
                    table.State = true;

                }
                db.SaveChanges();

                table = db.tables.Find(id);
                if (table != null)
                {

                    if (table.State)
                    {
                        state = "Available";
                        guna2Button1.FillColor = Color.Green;


                    }
                    else
                    {
                        state = "Busy";
                        guna2Button1.FillColor = Color.Red;

                    }

                }



            }




        }

        private void guna2Button1_DoubleClick(object sender, EventArgs e)
        {


            


        }

        private void guna2Button1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
