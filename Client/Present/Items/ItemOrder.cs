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
        private Order Order;
        private List<OrderItems> orderItems;
        private List<Products> productsInOrder = new List<Products>();
        public event EventHandler OrderDelete;
        protected virtual void OnDeleteClicked(EventArgs e)
        {
            EventHandler eh = OrderDelete;
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
            materialLabelOrderNumber.Text = $"Заказ №: {Order.Id}";
            materialLabelDate.Text = $"Дата: {Order.purchaseDate}";
            foreach (var item in productsInOrder)
            {
                ListViewItem lvItem = new ListViewItem(item.productName);
                lvItem.SubItems.Add(item.productDescription);
                lvItem.SubItems.Add(item.productPrice.ToString());
                lvItem.SubItems.Add(orderItems.Where(oi => oi.productId == item.Id).Count().ToString());
                materialListView1.Items.Add(lvItem);
            }
        }
    }
}
