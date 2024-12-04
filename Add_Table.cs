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
    
    public partial class Add_Table : Form
    {Form1 form1 = new Form1();
        tables mytables;
        ManageTable manage;
        public Add_Table(tables mytables,ManageTable manage)
        {
            InitializeComponent();

            this.mytables = mytables;
            this.manage=manage;
           

        } 

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form1.validateIsNumber(guna2TextBox1.Text)&&form1.validateIsNumber(guna2TextBox2.Text))
            if (form1.validateIsNull(guna2TextBox1.Text)&& form1.validateIsNull(guna2TextBox2.Text))
            {
                var db = new AppDbContext();
                var table = new Table()
                {
                    Number = Convert.ToInt32(guna2TextBox1.Text),
                    State = true,
                    Floor = Convert.ToInt32(guna2TextBox2.Text),
                };


                var context = new ValidationContext(table);
                var errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(table, context, errors, true))
                {
                    foreach (var validationResult in errors)
                    {
                            MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       




                    }
                else
                {

                        var tables = db.tables.ToList();
                        foreach (var table1 in tables)
                        {
                            if (table1.Number == table.Number && table1.Floor == table.Floor)
                            {
                                MessageBox.Show("You can not enter the same table number in the same floor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                        db.tables.Add(table);
                    db.SaveChanges();

                   
                    mytables.RefreshData();
                    manage.refreshData();
                        
                    this.Close();
                   

                }

            }
          
            
           




            mytables.RefreshData();
        }

        private void Guna2ControlBox1_Click(object? sender, EventArgs e)
        {
            
            //manageTable.Show();
            
        }
    }
}
