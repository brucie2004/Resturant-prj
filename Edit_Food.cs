using Restaurant_Project.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using Guna.UI2.WinForms;

namespace Restaurant_Project
{

    public partial class Edit_Food : Form
    {


        Form1 form1 = new Form1();
        food myfood;
        public int idd { get; set; }
        ManageFood manage;
        public Edit_Food(food myfood, int id, ManageFood manage)
        {
            InitializeComponent();

            this.myfood = myfood;
            this.manage = manage;


            




            var db = new AppDbContext();
            var foods = db.foodrinks.Find(id);
            idd = id;
            refeshData();


            guna2TextBox1.Text = foods.Name.ToString();
            guna2TextBox2.Text = foods.Price.ToString();
            guna2TextBox3.Text = foods.Quantity.ToString();
            guna2ComboBox1.SelectedValue=foods.CategoryId;

          


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            

        }

        private void Guna2ControlBox1_Click(object? sender, EventArgs e)
        {

            //manageTable.Show();

        }

       

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {


            var db = new AppDbContext();
            var foods = db.foodrinks.Find(idd);


            //edit
            if (form1.validateIsNull(guna2TextBox1.Text) && form1.validateIsNull(guna2TextBox2.Text) && form1.validateIsNull(guna2TextBox3.Text))
                if (form1.validateIsNumber(guna2TextBox2.Text)&&form1.validateIsNumber(guna2TextBox3.Text))
            {
                foods.Name = guna2TextBox1.Text;
                foods.Price = Convert.ToInt32(guna2TextBox2.Text);
                foods.Quantity = Convert.ToInt32(guna2TextBox3.Text);
                foods.CategoryId = Convert.ToInt32(guna2ComboBox1.SelectedValue);

               
                //check data annotation
                var context = new ValidationContext(foods);
                var errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(foods, context, errors, true))
                {
                    foreach (var validationResult in errors)
                    {
                        MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //     Console.WriteLine(validationResult);
                    }
                }
                else
                {
                        var foodss = db.foodrinks.ToList();
                        var foodsss = foodss.ToList();
                        foodsss.Remove(foods);
                        
                        foreach (var food1 in foodsss)
                        {
                            if (food1.Name == foods.Name)
                            {
                                MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }



                        //db.tables.Add(table);
                        db.SaveChanges();
                    myfood.RefreshData();
                    manage.refreshData();
                    this.Close();
                }
            }




        }
        public void refeshData()
        {
            var db = new AppDbContext();
            var category = db.categories.ToList();
            guna2ComboBox1.DataSource = category;

            guna2ComboBox1.ValueMember = "Id";
            guna2ComboBox1.DisplayMember = "Name";
        }
    }
}
