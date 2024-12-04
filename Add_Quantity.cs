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
    
    public partial class Add_Quantitiy : Form
    {Form1 form1 = new Form1();
        food myfood;
        public int idd;
        public Add_Quantitiy(food myfood,int id)
        {
            InitializeComponent();

            this.myfood = myfood;
            idd = id;
          


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (form1.validateIsNumber(guna2TextBox1.Text))
            if (form1.validateIsNull(guna2TextBox1.Text))
            {
                var db = new AppDbContext();
                    var fd = db.foodrinks.Find(idd);

                    fd.Quantity += Convert.ToInt32(guna2TextBox1.Text);


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
                    db.foodrinks.Update(fd);
                    db.SaveChanges();

                   
                    myfood.RefreshData();
                        
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
