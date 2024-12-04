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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Restaurant_Project
{

    public partial class Edit_Employer : Form
    {


        Form1 form1 = new Form1();
        emp myemp;
        public int idd { get; set; }
        ManageEmployer manage;
        public Edit_Employer(emp myemp, int id, ManageEmployer manage)
        {
            InitializeComponent();

            this.myemp = myemp;
            this.manage = manage;


            var db = new AppDbContext();
            var employer = db.employers.Find(id);
            idd = id;

            guna2TextBox1.Text = employer.Name.ToString();
            guna2TextBox2.Text = employer.Phone.ToString();
            guna2TextBox3.Text = employer.Address.ToString();
            guna2TextBox4.Text = employer.Age.ToString();





            //int temp1 = Convert.ToInt32(guna2TextBox1.Text);
            //int temp2 = Convert.ToInt32(guna2TextBox2.Text);




            //db.tables.Add(table);
            //db.SaveChanges();




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var db = new AppDbContext();
            var employer = db.employers.Find(idd);


            //edit
            if(form1.validateIsNumber(guna2TextBox4.Text))
            {
                employer.Name = guna2TextBox1.Text;
                employer.Phone = guna2TextBox2.Text;
                employer.Address = guna2TextBox3.Text;
                employer.Age = Convert.ToInt32(guna2TextBox4.Text);


                //table.Number = Convert.ToInt32(guna2TextBox1.Text);
                //table.State = true;
                //table.Floor = Convert.ToInt32(guna2TextBox2.Text);

                //check data annotation
                var context = new ValidationContext(employer);
                var errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(employer, context, errors, true))
                {
                    foreach (var validationResult in errors)
                    {
                        MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //     Console.WriteLine(validationResult);
                    }
                }
                else
                {

                    var emps = db.employers.ToList();
                    var items = emps.ToList();
                    items.Remove(employer);

                    foreach (var item in items)
                    {
                        if (item.Name == employer.Name)
                        {
                            MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    //db.tables.Add(table);
                    db.SaveChanges();
                    myemp.RefreshData();
                    manage.refreshData();
                    this.Close();
                }
            }
            
        }

        private void Guna2ControlBox1_Click(object? sender, EventArgs e)
        {

            //manageTable.Show();

        }

      
    }
}
