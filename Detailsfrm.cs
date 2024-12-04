using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Restaurant_Project
{
    public partial class Detailsfrm : Form
    {
        public int numberofitems=0;
        public double grand_total = -0.01;
        public Detailsfrm(int id)
        {
            InitializeComponent();

            var db = new AppDbContext();
            var order = db.orders.Find(id);

            string emp = db.employers.Find(order.DeliveryEmployer).Name;

            var t = db.tables.Find(order.TableId);
            string tab = Convert.ToString(t.Number) + "  in floor :  " + Convert.ToString(t.Floor);

            ordeDate.Text = order.OrderDate.ToString();
            accDate.Text = order.AccessDate.ToString();
            type.Text = order.Type.ToString();
            delivery.Text = emp;
            tabl.Text = tab;
            FillFoodList(id);
            cont.Text = numberofitems.ToString();
            total.Text = grand_total.ToString();
        }

        private void FillFoodList(int id)
        {
            var db = new AppDbContext();
            var ix = db.orders_foodrinks
                .Where(x => x.OrderId == id)
                .Select(y => y.FoodrinkId).ToArray();
            panel2.Controls.Clear();
            int y = 51;
            List <eachItem> count_each = new List<eachItem> ();
            var distinc = db.orders_foodrinks
               .Where(x => x.OrderId == id)
               .Select(y => y.FoodrinkId)
               .Distinct()
               .ToArray();

            for (int i = 0; i < distinc.Length; i++)
            {
                eachItem each = new eachItem {id=(i+1),foodrink_id= distinc[i],ordered_number= 0,price= db.foodrinks.Find(distinc[i]).Price};
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
                    pricee = (each.price*each.ordered_number).ToString(),

                };
                panel2.Controls.Add(f);
                f.Location = new Point(0, y);
                y += 50;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
