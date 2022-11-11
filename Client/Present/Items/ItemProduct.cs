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
    public partial class ItemProduct : UserControl
    {
        public Products prodData
        {
            get { return prodToAdd; }
            set { prodToAdd = value; }
        }
        public event EventHandler DataAvailable;
        Products prodToAdd;
        string PName;
        string Description;
        float Price;
        int Id;
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public ItemProduct(Products product)
        {
            this.PName = product.productName;
            this.Description = product.productDescription;
            this.Price = product.productPrice;
            this.Id = product.Id;
            prodToAdd = product;
            InitializeComponent();
        }

        private void ItemProduct_Load(object sender, EventArgs e)
        {
            materialLabelName.Text = PName;
            materialLabelPrice.Text = Price.ToString() + "$";
        }

        private void materialButtonAddToCard_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
        }
    }
}
