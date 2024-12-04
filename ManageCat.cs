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
    public partial class ManageCat : Form
    {




        food myfood;
        // event EventHandler clicks;
        AppDbContext db = new AppDbContext();
        Form1 form1 = new Form1();
        public int selected { get; set; }
        public string temp { get; set; }
        ManageFood manage;
        Add_Food addd;
        public ManageCat( food myfood,ManageFood manage,Add_Food addd)
        {
            InitializeComponent();

            this.myfood = myfood;
            this.manage = manage;
            this.addd = addd;

        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];



                if (selectedRow.DataBoundItem is Category cat)
                {
                    int id = cat.Id;

                    Edit_Cat edit_cat = new Edit_Cat(myfood, id,manage,this,addd);
                    edit_cat.Show();



                  
                }
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // form1.loadform(new Add_Table());


            Add_Cat add = new Add_Cat(myfood, manage,this,addd);
            add.Show();




        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Category cat)
                {


                    db.categories.Remove(cat);
                    db.SaveChanges();
                    this.refreshData();
                    manage.refreshData();
                    myfood.RefreshData();
                    addd.refeshData();



                }
            }




        }

        private void ManageTable_Load(object sender, EventArgs e)
        {



            refreshData();

        }
        
    public void refreshData ()
        {
            
            using (var db = new AppDbContext())
            {


                var categories = db.categories.AsNoTracking().ToList();
                guna2DataGridView1.DataSource = categories;

            }

        }
    
    
    
    
    
    }
}
