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
    public partial class ManageTable : Form
    {




        tables mytables;
        // event EventHandler clicks;
        AppDbContext db = new AppDbContext();
        Form1 form1 = new Form1();
        public ManageTable(tables mytables)
        {
            InitializeComponent();

            this.mytables = mytables;





        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];



                if (selectedRow.DataBoundItem is Table tables1)
                {
                    int id = tables1.Id;

                    Edit_Table edit_Table = new Edit_Table(mytables, id,this);
                    edit_Table.Show();



                    

                }
            }
          
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // form1.loadform(new Add_Table());


            Add_Table add = new Add_Table(mytables, this);
            add.Show();




        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Table tables1)
                {


                    db.tables.Remove(tables1);
                    db.SaveChanges();
                    this.refreshData();
                    mytables.RefreshData();



                }
            }




        }

        private void ManageTable_Load(object sender, EventArgs e)
        {


            using (var db = new AppDbContext())
            {

                var table1 = db.tables.Find(7);
                var tables = db.tables.AsNoTracking().ToList();
                var table2 = tables.Remove(table1);
                guna2DataGridView1.DataSource = tables;

            }

        }
       
    public void refreshData ()
        {

            using (var db = new AppDbContext())
            {

                var table1 = db.tables.Find(7);
                var tables = db.tables.AsNoTracking().ToList();
                tables.Remove(table1);
                guna2DataGridView1.DataSource = tables;

            }

        }
    
    
    
    
    
    }
}
