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
using Guna.UI2.WinForms;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restaurant_Project
{

    public partial class Add_Food : Form
    {
        Form1 form1 = new Form1();
        food myfood;
        ManageFood manage;
        public Add_Food(food myfood, ManageFood manage)
        {
            InitializeComponent();

            this.myfood = myfood;
            this.manage = manage;
            refeshData();
            




        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form1.validateIsNull(guna2TextBox1.Text) && form1.validateIsNull(guna2TextBox2.Text) && form1.validateIsNull(guna2TextBox3.Text))
                if (form1.validateIsNumber(guna2TextBox2.Text) && form1.validateIsNumber(guna2TextBox3.Text))
                {
                    var db = new AppDbContext();

                    //Category cat = db.categories.Find(Convert.ToInt32(guna2ComboBox1.SelectedValue.ToString()));
                    var fd = new Foodrink()
                    {
                        Name = guna2TextBox1.Text,
                        Price = Convert.ToInt32(guna2TextBox2.Text),
                        Quantity = Convert.ToInt32(guna2TextBox3.Text),
                       // category = cat,
                        CategoryId=Convert.ToInt32(guna2ComboBox1.SelectedValue),
                    };
                    



                    //check data annotation
                    var context = new ValidationContext(fd);
                    var errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(fd, context, errors, true))
                    {
                        foreach (var validationResult in errors)
                        {
                            MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //     Console.WriteLine(validationResult);
                        }
                    }
                    else
                    {
                        var foods = db.foodrinks.ToList();
                        foreach (var food1 in foods)
                        {
                            if (food1.Name == fd.Name)
                            {
                                MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }

                        db.foodrinks.Add(fd);
                        db.SaveChanges();
                        myfood.RefreshData();
                        manage.refreshData();
                        this.Close();
                    }







                }








        }

        private void Guna2ControlBox1_Click(object? sender, EventArgs e)
        {

            //manageTable.Show();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            ManageCat manageCat = new ManageCat(myfood,manage,this);
            manageCat.Show();
        }
        public void refeshData ()
        {
            var db = new AppDbContext();
            var category = db.categories.ToList();
            guna2ComboBox1.DataSource = category;

            guna2ComboBox1.ValueMember = "Id";
            guna2ComboBox1.DisplayMember = "Name";
        }
    }
}
