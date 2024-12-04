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
    public partial class orderfrm : Form
    {
        // UserControl UserControl;


        public orderfrm()
        {
            InitializeComponent();
            // panel1.Controls.Clear();

        }


        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            FillOrder();
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {



            //ManageTable manageTable = new ManageTable(this);


            //manageTable.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tables_Load(object sender, EventArgs e)
        {
            FillOrder();
        }

        private void FillOrder()
        {
            var db = new AppDbContext();
            var orders = db.orders.AsNoTracking().ToList();
            int x = 60;
            int y = 60;
            int cnt = 0;
            panel1.Controls.Clear();





            foreach (var order in orders)
            {


                if (!order.DeliverState)
                {

                    //MessageBox.Show(order.OrderDate.ToShortTimeString);
                    string s = order.OrderDate.ToShortTimeString();

                    var tbl = new UserControl4(this)
                    {
                        OrderId = Convert.ToString(order.Id),
                        orderDate = s


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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var newOrder = new Order()
            {
                OrderDate=DateTime.Now,
                Type="inner order",
                DeliverState=false,
                DeliveryEmployer=1,
                Price=0,
                NumberOfItems=0,
                TableId=1
            };
            db.orders.Add(newOrder);
            db.SaveChanges();

            var orderId = db.orders.ToList().Last().Id;
            //int orderId=ords.Last().Id;

            add_order add=new add_order(this,orderId);
            add.Show();
            

        }
    }

}

