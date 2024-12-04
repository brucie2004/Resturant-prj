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
    public partial class ManageFood : Form
    {




        food myfood;
        // event EventHandler clicks;
        AppDbContext db = new AppDbContext();
        Form1 form1 = new Form1();
        public int selected { get; set; }
        public string temp { get; set; }

        public ManageFood(food myfood)
        {
            InitializeComponent();

            this.myfood = myfood;



        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];



                if (selectedRow.DataBoundItem is Foodrink food)
                {
                    int id = food.Id;

                    Edit_Food edit_food = new Edit_Food(myfood, id,this);
                    edit_food.Show();



                }
            }
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            Add_Food add = new Add_Food(myfood, this);
            add.Show();




        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = guna2DataGridView1.SelectedRows[0];
                if (selectedRow.DataBoundItem is Foodrink food)
                {


                    db.foodrinks.Remove(food);
                    db.SaveChanges();
                    refreshData();
                    myfood.RefreshData();



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


                var foodrinks = db.foodrinks.AsNoTracking().ToList();
                guna2DataGridView1.DataSource = foodrinks;

            }

        }
    
    
    
    
    
    }
}
