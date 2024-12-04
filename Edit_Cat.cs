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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restaurant_Project
{

    public partial class Edit_Cat : Form
    {


        Form1 form1 = new Form1();
        food myfood;
        public int idd { get; set; }
        ManageFood manage;
        ManageCat manage1;
        Add_Food add;
        public Edit_Cat(food myfood, int id, ManageFood manage, ManageCat manage1,Add_Food add)
        {
            InitializeComponent();

            this.myfood = myfood;
            this.manage = manage;
            this.manage1 = manage1;
            this.add = add;

            var db = new AppDbContext();
            var cat = db.categories.Find(id);
            idd = id;
            guna2TextBox1.Text = cat.Name;



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


           





        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {


            var db = new AppDbContext();
            var cat = db.categories.Find(idd);


            //edit
            if (form1.validateIsNull(guna2TextBox1.Text))
            {

                cat.Name = guna2TextBox1.Text;

                //check data annotation
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
                    var items = cats.ToList();
                    items.Remove(cat);


                    foreach (var cat1 in items)
                    {
                        if (cat1.Name == cat.Name)
                        {
                            MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    //db.tables.Add(table);
                    db.SaveChanges();
                    myfood.RefreshData();
                    manage.refreshData();
                    manage1.refreshData();
                    add.refeshData();
                    this.Close();
                }


            }





        }
    }
}
