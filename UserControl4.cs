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
    public partial class UserControl4 : UserControl
    {
        orderfrm frmord;
        public UserControl4(orderfrm frmord)
        {
            InitializeComponent();
            this.frmord = frmord; 
        }


        public string OrderId
        {
            get { return orderId.Text; }
            set { orderId.Text = value; }
        }
        public string orderDate
        {
            get { return datetime.Text; }
            set { datetime.Text = value; }
        }
        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void CatName_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Detailsfrm detailsfrm = new Detailsfrm(int.Parse(OrderId));
            detailsfrm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();

            var order = db.orders.Find(int.Parse(OrderId));
            order.DeliverState = true;
           // int tbl = order.TableId;
           order.AccessDate = DateTime.Now;
           db.SaveChanges();
            frmord.RefreshData();

            
        }
    }
}
