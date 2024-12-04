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

namespace Restaurant_Project
{

    public partial class Add_Cat : Form
    {
        Form1 form1 = new Form1();
        food myfood;
        ManageFood manage;
        ManageCat manage1;
        Add_Food add;
        public Add_Cat(food myfood, ManageFood manage,ManageCat manage1,Add_Food add)
        {
            InitializeComponent();

            this.myfood = myfood;
            this.manage = manage;
            this.manage1 = manage1;
            this.add = add;

            





        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form1.validateIsNull(guna2TextBox1.Text))
            {

                var db = new AppDbContext();
                var cat = new Category()
                {
                    Name = guna2TextBox1.Text,
                };
                var context = new ValidationContext(cat);
                var errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(cat, context, errors, true))
                {
                    foreach (var validationResult in errors)
                    {
                        MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //     Console.WriteLine(validationResult);
                    }
                }
                else
                {

                    var cats = db.categories.ToList();
                    foreach (var cat1 in cats)
                    {
                        if (cat1.Name == cat.Name)
                        {
                            MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    db.categories.Add(cat);
                    db.SaveChanges();


                    myfood.RefreshData();
                    manage.refreshData();
                    manage1.refreshData();
                    add.refeshData();
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

        }
    }
}
