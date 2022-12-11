using Client.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Present.Items
{
    public partial class ItemOrder : UserControl
    {
        public int id;
        public Order ord { get { return Order; } }
        private Order Order;
        private List<OrderItems> orderItems;
        private List<Products> productsInOrder = new List<Products>();
        public event EventHandler OrderDelete;
        public event EventHandler Payment;
        protected virtual void OnDeleteClicked(EventArgs e)
        {
            EventHandler eh = OrderDelete;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        protected virtual void OnPayClicked(EventArgs e)
        {
            EventHandler eh = Payment;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public ItemOrder()
        {
            InitializeComponent();
        }
        public ItemOrder(Order order, List<OrderItems> items, List<Products> products)
        {
            this.id = order.Id;
            this.Order = order;
            this.orderItems = items;
            foreach (var item in items)
            {
                productsInOrder.AddRange(products.Where(p => p.Id == item.productId));
            }
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnDeleteClicked(null);
        }

        private void ItemOrder_Load(object sender, EventArgs e)
        {
            double sum = 0;
            materialLabelOrderNumber.Text = $"Заказ №: {Order.Id}";
            materialLabelDate.Text = $"Дата: {Order.purchaseDate}";
            foreach (var item in productsInOrder)
            {
                sum += item.productPrice;
                ListViewItem lvItem = new ListViewItem(item.productName);
                lvItem.SubItems.Add(item.productDescription);
                lvItem.SubItems.Add(item.productPrice.ToString());
                lvItem.SubItems.Add(orderItems.Where(oi => oi.productId == item.Id).Count().ToString());
                materialListView1.Items.Add(lvItem);
            }
            materialLabelTotal.Text = $"Total: {sum}$";
            if (Order.status == 0)
            {
                materialLabelOrderStatus.Text = $"Status: Awaiting payment";
            }
            else
            {
                materialLabelOrderStatus.Text = $"Status: Paid";
                materialButtonPay.Enabled = false;
                materialButtonPay.Hide();
            }
        }

        private void materialButtonPay_Click(object sender, EventArgs e)
        {
            OnPayClicked(null);
        }
    }
}
