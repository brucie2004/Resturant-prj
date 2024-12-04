using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class tables : Form
    {
        // UserControl UserControl;


        public tables()
        {
            InitializeComponent();
        }
        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            FillTables();
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ManageTable manageTable = new ManageTable(this);


            manageTable.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tables_Load(object sender, EventArgs e)
        {
            FillTables();
        }

        private void FillTables()
        {
            var db = new AppDbContext();
            var tables = db.tables.AsNoTracking().ToList();
            int x = 60;
            int y = 60;
            int cnt = 0;
            panel1.Controls.Clear();

           


            foreach (var table in tables)
            {
                if (table.Id!=7)
                {

                    string test;
                    if (table.State)
                    {
                        test = "Available";
                    }
                    else
                    {
                        test = "Busy";
                    }

                    var tbl = new UserControl1()
                    {
                        id = table.Id,
                        Tnum = Convert.ToString(table.Number),
                        floor = Convert.ToString(table.Floor),
                        state = test


                    };
                    panel1.Controls.Add(tbl);
                    tbl.Location = new Point(x, y);
                    cnt++;
                    x += 250;

                    if (cnt == 4)
                    {
                        x = 60; y += 250;
                        cnt = 0;

                    }

                }
                

            }
        }


    }

}

