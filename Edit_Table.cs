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

namespace Restaurant_Project
{
    
    public partial class Edit_Table : Form
    {
        
        
        Form1 form1 = new Form1();
        tables mytable;
        public int idd { get; set; }
        ManageTable manage;
        public Edit_Table(tables mytable,int id,ManageTable manage)
        {
            InitializeComponent();

            this.mytable = mytable;
            this.manage = manage;


            var db = new AppDbContext();
            var table = db.tables.Find(id);
            idd = id;

            guna2TextBox1.Text=table.Number.ToString();
            guna2TextBox2.Text=table.Floor.ToString();

            



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var db = new AppDbContext();
            var table = db.tables.Find(idd);


            //edit
            if (form1.validateIsNumber(guna2TextBox1.Text) && form1.validateIsNumber(guna2TextBox2.Text))
                if (form1.validateIsNull(guna2TextBox1.Text) && form1.validateIsNull(guna2TextBox2.Text))
                {

                    table.Number = Convert.ToInt32(guna2TextBox1.Text);
                    table.State = true;
                    table.Floor = Convert.ToInt32(guna2TextBox2.Text);

                    //check data annotation
                    var context = new ValidationContext(table);
                    var errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(table, context, errors, true))
                    {
                        foreach (var validationResult in errors)
                        {
                            MessageBox.Show(Convert.ToString(validationResult), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //     Console.WriteLine(validationResult);
                        }
                    }
                    else
                    {




                        var tables = db.tables.ToList();
                        var items = tables.ToList();
                        items.Remove(table);

                        foreach (var table1 in items)
                        {
                            if (table1.Number == table.Number && table1.Floor == table.Floor)
                            {
                                MessageBox.Show("You can not enter the same table number in the same floor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }
                        //db.tables.Add(table);
                        db.SaveChanges();
                        mytable.RefreshData();
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
