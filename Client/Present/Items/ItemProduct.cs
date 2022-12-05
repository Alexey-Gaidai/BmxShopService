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
            prodToAdd = product;
            InitializeComponent();
        }

        private void ItemProduct_Load(object sender, EventArgs e)
        {
            materialLabelName.Text = prodData.productName;
            materialLabelPrice.Text = prodData.productPrice.ToString() + "$";
            pictureBox1.ImageLocation = prodData.imageLink;
            materialButtonAddToCard.BackColor = Color.FromArgb(129, 135, 109);
        }

        private void materialButtonAddToCard_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
            MessageBox.Show("Добавлено в козину!");
        }

        private void materialButtonAddToCard_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
