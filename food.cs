using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class food : Form
    {
        // UserControl UserControl;
        public food()
        {
            InitializeComponent();


        }

        public void RefreshData()
        {
            FillFood();
        }
        private void FillFood()
        {
            var db = new AppDbContext();
            var Food = db.foodrinks.AsNoTracking().ToList();
            panel1.Controls.Clear();

            int x = 40;
            int y = 60;
            int cnt = 0;
            foreach (var fd in Food)
            {

                var cat = db.categories.Find(fd.CategoryId);
                var f = new UserControl3(this)
                {
                    



                    id = fd.Id,
                    fname = fd.Name,
                   catname=cat.Name,
                    count = Convert.ToString(fd.Quantity),
                    fprice = Convert.ToString(fd.Price)
                    





                };
                panel1.Controls.Add(f);

                f.Location = new Point(x, y);
                cnt++;
                x += 240;

                if (cnt == 4)
                {
                    x = 40; y += 280;
                    cnt = 0;

                }



            }
        }

        private void addForm(Form form)
        {
            //    panel1.Controls.Clear();
            //    form.Dock = DockStyle.Fill;
            //    form.TopLevel = false;
            //    panel1.Controls.Add(form);
            //    form.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void emp_Load(object sender, EventArgs e)
        {
            FillFood();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManageFood manageFood = new ManageFood(this);


            manageFood.Show();
        }
    }

}

