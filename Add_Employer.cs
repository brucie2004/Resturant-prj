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
    
    public partial class Add_Employer : Form
    {Form1 form1 = new Form1();
        emp myemp;
        ManageEmployer manage;
        public Add_Employer(emp myemp,ManageEmployer manage)
        {
            InitializeComponent();

            this.myemp = myemp;
            this.manage=manage;
            //int temp1 = Convert.ToInt32(guna2TextBox1.Text);
            //int temp2 = Convert.ToInt32(guna2TextBox2.Text);

            


            //db.tables.Add(table);
            //db.SaveChanges();




        }


        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            


            if (form1.validateIsNumber(guna2TextBox4.Text))
            {
                var db = new AppDbContext();
                var employer = new Employer()
                {
                    Name=guna2TextBox1.Text,
                    Phone=guna2TextBox2.Text,
                    Address=guna2TextBox3.Text,
                    Age=Convert.ToInt32(guna2TextBox4.Text)


                    //Number = Convert.ToInt32(guna2TextBox1.Text),
                    //State = true,
                    //Floor = Convert.ToInt32(guna2TextBox2.Text),
                };


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
                    foreach (var employer1 in emps)
                    {
                        if (employer1.Name == employer.Name)
                        {
                            MessageBox.Show("You can not enter the same name twice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                    db.employers.Add(employer);
                    db.SaveChanges();

                   
                    myemp.RefreshData();
                    manage.refreshData();
                    this.Close();
                   

                }

                }
            //else
            //{
            //    MessageBox.Show("all fields are Required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //return;
            //}
            
           




            myemp.RefreshData();
        }

        private void Guna2ControlBox1_Click(object? sender, EventArgs e)
        {
            
            //manageTable.Show();
            
        }
    }
}
