using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Restaurant_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Project
{
    public partial class add_order : Form
    {
        orderfrm frmord;
        int newOrderId;
        
        
        public add_order(orderfrm frmord,int newOrderId)
        {
            InitializeComponent();
            this.frmord = frmord;
            this.newOrderId = newOrderId;
        }
        



        private void guna2Button1_Click(object sender, EventArgs e)
        {


            var db = new AppDbContext();
            //var order = db.orders.Find(newOrderId);




            if (cont.Text =="")
            {
                MessageBox.Show("sorry you didn't order");
            }
            else
            {
                //minus storage of foodrinks that we ordered // 0 of 2
                // 1 of 2 getting the ordered number 
                int numberofitems = 0;
                var ix = db.orders_foodrinks
                .Where(x => x.OrderId == newOrderId)
                .Select(y => y.FoodrinkId).ToArray();
                List<eachItem> count_each = new List<eachItem>();
                var distinc = db.orders_foodrinks
                   .Where(x => x.OrderId == newOrderId)
                   .Select(y => y.FoodrinkId)
                   .Distinct()
                   .ToArray();

                for (int i = 0; i < distinc.Length; i++)
                {
                    eachItem each = new eachItem { id = (i + 1), foodrink_id = distinc[i], ordered_number = 0, price = db.foodrinks.Find(distinc[i]).Price };
                    for (int j = 0; j < ix.Length; j++)
                    {
                        if (ix[j] == distinc[i])
                        {
                            numberofitems++;
                            each.ordered_number++;
                        }
                    }
                    count_each.Add(each);
                }
                //2 of 2 minus from storage
                var foodrinks = db.foodrinks;
                foreach (var each in count_each)
                {
                    var food = foodrinks.Find(each.foodrink_id);
                    food.Quantity -= each.ordered_number;

                }
                db.SaveChanges();



                //add order
                var order = db.orders.Find(newOrderId);

                order.OrderDate = DateTime.Now;
                order.Type = typeComboBox.SelectedText;
                order.DeliverState = false;
                order.DeliveryEmployer = Convert.ToInt32(deliveryCombobox.SelectedValue);
                order.Price = Convert.ToDouble(total.Text);
                order.NumberOfItems = Convert.ToInt32(cont.Text);
                order.TableId = Convert.ToInt32(tableComboBox.SelectedValue);








                db.SaveChanges();

                frmord.RefreshData();
                this.Close();




            }







        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FillFood()
        {
            var db = new AppDbContext();
            var Food = db.foodrinks.AsNoTracking().ToList();
            panel3.Controls.Clear();

            int x = 40;
            int y = 60;
            int cnt = 0;
            foreach (var fd in Food)
            {

                var cat = db.categories.Find(fd.CategoryId);
                var f = new UserControl6(frmord, this,newOrderId)
                {




                    id = fd.Id,
                    fname = fd.Name,
                    catname = cat.Name,
                    count = Convert.ToString(0),
                    fprice = Convert.ToString(fd.Price)






                };
                
                panel3.Controls.Add(f);

                f.Location = new Point(x, y);
                cnt++;
                x += 240;

                if (cnt == 4)
                {
                    x = 40; y += 280;
                    cnt = 0;

                }



            }
        }

        private void add_order_Load(object sender, EventArgs e)
        {
            refreashData();
            floorComboBox.DataSource = floorComboBox.Items;
            accComboBox.DataSource = accComboBox.Items;
            var db = new AppDbContext();
            deliveryCombobox.DataSource = db.employers.AsNoTracking().ToList();
            deliveryCombobox.ValueMember = "Id";
            deliveryCombobox.DisplayMember = "Name";


        }
        public void refreashData()
        {
            
            var db = new AppDbContext();
            FillFood();
            date.Text = DateTime.Now.ToString();
            
            tableComboBox.DataSource = db.tables.Where(x => x.Floor == Convert.ToInt32(floorComboBox.SelectedValue)).ToList();
            tableComboBox.ValueMember = "Id";
            tableComboBox.DisplayMember = "Number";
        }

        private void floorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var db = new AppDbContext();
            date.Text = DateTime.Now.ToString();

            tableComboBox.DataSource = db.tables.Where(x => x.Floor == Convert.ToInt32(floorComboBox.SelectedValue)).ToList();
            tableComboBox.ValueMember = "Id";
            tableComboBox.DisplayMember = "Number";
        }
    }
}
