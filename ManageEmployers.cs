using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class ManageEmployer : Form
    {




        emp myemp;
        // event EventHandler clicks;
        AppDbContext db = new AppDbContext();
        Form1 form1 = new Form1();
        public int selected { get; set; }
        public string temp { get; set; }

        public ManageEmployer(emp myemp)
        {
            InitializeComponent();

            this.myemp = myemp;



           

















        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];



                if (selectedRow.DataBoundItem is Employer employer)
                {
                    int id = employer.Id;

                    Edit_Employer edit_employer = new Edit_Employer(myemp, id,this);
                    edit_employer.Show();



                }
            }
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            Add_Employer add = new Add_Employer(myemp, this);
            add.Show();




        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Employer employer)
                {


                    db.employers.Remove(employer);
                    db.SaveChanges();
                    refreshData();
                    myemp.RefreshData();



                }
            }




        }

        private void ManageTable_Load(object sender, EventArgs e)
        {


            using (var db = new AppDbContext())
            {


                var employers = db.employers.AsNoTracking().ToList();
                guna2DataGridView1.DataSource = employers;

            }

        }
        //private void ManageTable_load(object sender, EventArgs e)
        //{
        //    var db = new AppDbContext();
        //    // var tables = db.tables;
        //    var data = (from d in db.tables select d);


        //    //dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
        //    guna2DataGridView1.DataSource = data.ToList();
        //}
    
    public void refreshData ()
        {
            using (var db = new AppDbContext())
            {


                var employers = db.employers.AsNoTracking().ToList();
                guna2DataGridView1.DataSource = employers;

            }

        }
    
    
    
    
    
    }
}
