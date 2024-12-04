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
    public partial class emp : Form
    {
        // UserControl UserControl;
        public emp()
        {
            InitializeComponent();


        }

        public void RefreshData()
        {
            FillEmployers();
        }
        private void FillEmployers()
        {
            var db = new AppDbContext();
            var employers = db.employers.AsNoTracking().ToList();
            panel1.Controls.Clear();

            int x = 55;
            int y = 60;
            int cnt = 0;
            foreach (var employer in employers)
            {


                var employ = new UserControl2()
                {


                    id = employer.Id,
                    name = employer.Name,
                    age = Convert.ToString(employer.Age),
                    phone = employer.Phone,
                    address = employer.Address,





                };
                panel1.Controls.Add(employ);

                employ.Location = new Point(x, y);
                cnt++;
                x += 250;

                if (cnt == 4)
                {
                    x = 55; y += 250;
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
            FillEmployers();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ManageEmployer manageEmployer = new ManageEmployer(this);


            manageEmployer.Show();
        }
    }

}

