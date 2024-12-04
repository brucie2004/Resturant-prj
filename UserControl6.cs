using Restaurant_Project.Models;

namespace Restaurant_Project
{
    public partial class UserControl6 : UserControl
    {
        Form1 Form1;
        orderfrm frmord;
        add_order add;
        int newOrderId;


        public UserControl6(orderfrm frmord,add_order add,int newOrderId)
        {
            InitializeComponent();
            this.frmord=frmord;
            this.add=add;
            this.newOrderId=newOrderId;

        }

        public int id { get; set; }

        public string catname
        {
            get { return CatName.Text; }
            set { CatName.Text = value; }
        }
        public string fname
        {
            get { return FName.Text; }
            set { FName.Text = value; }
        }
        public string count
        {
            get { return Quantity.Text; }
            set { Quantity.Text = value; }
        }
        public string fprice
        {
            get { return Fprice.Text; }
            set { Fprice.Text = value; }
        }





        private void catname_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void minbutton_Click(object sender, EventArgs e)
        {
            if (Quantity.Text == "0")
            {
                MessageBox.Show("can't remove an order if it does not exist");
            }
            else
            {
                int newQuantity = int.Parse(Quantity.Text) - 1;
                Quantity.Text = newQuantity.ToString();

                //Minus_Quantitiy minus_Quantitiy = new Minus_Quantitiy(food, id);
                //minus_Quantitiy.Show();

                int numberofitems = 0;
                double grand_total = -0.01;

                var db = new AppDbContext();
                var remov = db.orders_foodrinks.Where(x => x.OrderId == newOrderId).Where(t => t.FoodrinkId == id).ToList().Last();
                db.orders_foodrinks.Remove(remov);
                db.SaveChanges();

                var ix = db.orders_foodrinks
                    .Where(x => x.OrderId == newOrderId)
                    .Select(y => y.FoodrinkId).ToArray();
                add.panel2.Controls.Clear();
                int y = 51;
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
                            grand_total += db.foodrinks.Find(ix[j]).Price;
                            each.ordered_number++;
                        }
                    }
                    count_each.Add(each);
                }

                foreach (var each in count_each)
                {
                    var f = new UserControl5()
                    {
                        id = each.id,
                        lbl = each.id.ToString(),
                        fname = db.foodrinks.Find(each.foodrink_id).Name,
                        fcount = each.ordered_number.ToString(),
                        pricee = (each.price * each.ordered_number).ToString(),

                    };
                    add.panel2.Controls.Add(f);
                    f.Location = new Point(0, y);
                    y += 50;
                }

                add.cont.Text = numberofitems.ToString();
                add.total.Text = grand_total.ToString();
            }

        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            int newQuantity = int.Parse(Quantity.Text) + 1;

            if (newQuantity<db.foodrinks.Find(id).Quantity)
            {
            Quantity.Text=newQuantity.ToString();


            }
            AddFoodList(id);
            //add.cont.Text=add.CountFoodListItems.Text;
            //add.total.Text=add.grandTotal.Text;





            //Add_Quantitiy add_Quantitiy = new Add_Quantitiy(food, id);
            //add_Quantitiy.Show();



        }
        private void AddFoodList(int Foodid)
        {

            //int yyy = Convert.ToInt32(add.yy.Text);
            //int countt = Convert.ToInt32(add.CountFoodListItems.Text);
            //double d = Convert.ToDouble(add.grandTotal.Text);

            //var db = new AppDbContext();
            //var order_food = new Orders_Foodrinks()
            //{
            //    OrderId = newOrderId,
            //    FoodrinkId = Foodid


            //};

            //db.orders_foodrinks.Add(order_food);
            //db.SaveChanges();

            ////var orders_foods=db.orders_foodrinks.Where(x=>x.OrderId==newOrderId).ToList();

            //d += db.foodrinks.Find(Foodid).Price;
            //var f = new UserControl5()
            //{
            //    id = Convert.ToInt32(add.CountFoodListItems.Text)+1,
            //    lbl = (Convert.ToInt32(add.CountFoodListItems.Text) + 1).ToString(),
            //    fname = db.foodrinks.Find(Foodid).Name,
            //    fcount = "1"


            //};
            //countt++;
            //f.Location =new Point (0,yyy );
            //yyy += 50;
            //add.panel2.Controls.Add(f);
            //add.yy.Text=yyy.ToString();
            //add.CountFoodListItems.Text=countt.ToString();
            //add.grandTotal.Text=d.ToString();


            ////add.panel2.Controls.Clear();
            ////int y = 51;
            ////int countItems = 1;
            ////int count = 0;
            ////int realCount = 0;
            ////foreach (var order in orders_foods)
            ////{

            ////    var f = new UserControl5()
            ////    {
            ////        id = order.Id,
            ////        lbl = countItems.ToString(),
            ////        fname = db.foodrinks.Find(order.FoodrinkId).Name,
            ////        fcount = ""


            ////    };

            ////    add.panel2.Controls.Add(f);

            ////    f.Location = new Point(0, y);
            ////    y += 50;

            ////    countItems++;
            ////}


            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int numberofitems = 0;
            double grand_total = -0.01;

            var db = new AppDbContext();
            var order_food = new Orders_Foodrinks()
            {
                OrderId = newOrderId,
                FoodrinkId = Foodid


            };
            db.orders_foodrinks.Add(order_food);
            db.SaveChanges();

            var ix = db.orders_foodrinks
                .Where(x => x.OrderId == newOrderId)
                .Select(y => y.FoodrinkId).ToArray();
            add.panel2.Controls.Clear();
            int y = 51;
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
                        grand_total += db.foodrinks.Find(ix[j]).Price;
                        each.ordered_number++;
                    }
                }
                count_each.Add(each);
            }

            foreach (var each in count_each)
            {
                var f = new UserControl5()
                {
                    id = each.id,
                    lbl = each.id.ToString(),
                    fname = db.foodrinks.Find(each.foodrink_id).Name,
                    fcount = each.ordered_number.ToString(),
                    pricee = (each.price * each.ordered_number).ToString(),

                };
                add.panel2.Controls.Add(f);
                f.Location = new Point(0, y);
                y += 50;
            }

            add.cont.Text=numberofitems.ToString();
            add.total.Text=grand_total.ToString();

        }
    }
}
