using Client.Data.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Client.Data.Service;
using Client.UseCases;
using Client.Present.Items;
using Application = System.Windows.Forms.Application;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace Client.Present
{
    public partial class Shop : MaterialForm
    {
        DataUseCases getData = new Data_Impl();

        private List<Basket> basketToOrder = new List<Basket>();
        public List<Products> products = new List<Products>();
        private List<Supplies> supplies = new List<Supplies>();
        AuthInfo _AuthInfo;
        
        private float sum = 0;

        Dictionary<string, Color> colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(51, 54, 41) },
                { "dark-low", Color.FromArgb(75, 79, 62) },
                { "medium", Color.FromArgb(129, 135, 109) },
                { "light", Color.FromArgb(181, 187, 164)},
                { "very-light", Color.FromArgb(226, 230, 215) },
            };
        public Shop()
        {
            InitializeComponent();
        }
        public Shop(AuthInfo authInfo)
        {
            _AuthInfo = authInfo;
            InitMaterialSkin();
            InitializeComponent();
        }

        private void InitMaterialSkin()
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               colors["dark-low"], colors["dark"], colors["light"], colors["medium"], TextShade.WHITE
            );
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            setOrders();
            setData();
            this.Text = _AuthInfo.username;
            materialTabControl1.SelectedTab = tabPageProducts;
        }
        void child_DataAvailable(object sender, EventArgs e)
        {
            ItemProduct child = sender as ItemProduct;
            if (child != null)
            {
                addtobasket(child);
            }
            materialLabelTotalPrice.Text = sum.ToString()+"$";
        }
        void child_DeleteClicked(object sender, EventArgs e)
        {
            ItemOrder child = sender as ItemOrder;
            if (child != null)
            {
                deleteOrder(child);
            }
        }

        private async void deleteOrder(ItemOrder child)
        {
            await getData.DeleteOrder(child.id);
            setOrders();
        }

        private void addtobasket(ItemProduct child)
        {
            if (basketToOrder.Exists(i => i.productId == child.prodData.Id))
            {
                basketToOrder.Find(i => i.productId == child.prodData.Id).count++;
                materialListView1.FindItemWithText(basketToOrder.Find(i => i.productId == child.prodData.Id).productId.ToString()).SubItems[2].Text = basketToOrder.Find(i => i.productId == child.prodData.Id).count.ToString();
                sum += basketToOrder.Find(i => i.productId == child.prodData.Id).productPrice;
            }
            else
            {
                var basketitem = new Basket
                {
                    productId = child.prodData.Id,
                    productPrice = child.prodData.productPrice,
                    count = 1
                };
                basketToOrder.Add(basketitem);
                sum += basketitem.productPrice;
                ListViewItem item = new ListViewItem(basketitem.productId.ToString());
                item.SubItems.Add(basketitem.productPrice.ToString());
                item.SubItems.Add(basketitem.count.ToString());
                materialListView1.Items.Add(item);
            }
        }

        private async void setData()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                var data = await getData.GetProduct<List<Products>>(_AuthInfo.access_token, materialTextBox21.Text);
                products = data;
                if(data!=null)
                {
                    foreach (var item in data)
                    {
                        ItemProduct it = new ItemProduct(item);
                        it.DataAvailable += new EventHandler(child_DataAvailable);
                        flowLayoutPanel1.Controls.Add(it);
                    }
                }
                else
                {
                    var t = new Thread(() => Application.Run(new FormLogin()));
                    t.Start();
                    this.Close();
                }
            }
            catch
            {
               
            }
        }

        private async void setOrders()
        {
            flowLayoutPanel2.Controls.Clear();
            var data = await getData.GetOrders(_AuthInfo.access_token, _AuthInfo.userId);
            foreach (var item in data)
            {
                var ordItems = await getData.GetOrderItems(_AuthInfo.access_token, item.Id.ToString());
                ItemOrder order = new ItemOrder(item, ordItems, products);
                order.OrderDelete += new EventHandler(child_DeleteClicked);
                flowLayoutPanel2.Controls.Add(order);
            }
        }

        private async void materialButtonChekout_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var checkout = await getData.CreateOrder(Convert.ToInt32(_AuthInfo.userId), date.ToString());
            var items = await getData.AddOrderItems(itemsToArray(checkout));
        }

        private OrderItems[] itemsToArray(string _orderId)
        {
            var items = new OrderItems[basketToOrder.Count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new OrderItems
                {
                    id = 0,
                    productId = basketToOrder[i].productId,
                    Count = basketToOrder[i].count,
                    orderId = Convert.ToInt32(_orderId),
                };
            }
            return items;
        }

        private async void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_AuthInfo.role != "admin" && materialTabControl1.SelectedTab == tabPageAdmin)
            {
                MessageBox.Show("У вас нет доступа!");
                materialTabControl1.SelectedTab = tabPageProducts;
            }
            setSupplies();
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            setOrders();
        }


        private void materialButtonSuppliesApply_Click(object sender, EventArgs e)
        {
            
        }
        private async void setSupplies()
        {
            var data = await getData.GetSupplies<List<Supplies>>(_AuthInfo.access_token);

            for (int i = 0; i < data.Count; i++)
            {
                dataGridViewSupplies.Rows.Add();
                dataGridViewSupplies.Rows[i].Cells["columnId"].Value = data[i].id;
                dataGridViewSupplies.Rows[i].Cells["ColumnProductId"].Value = data[i].productsId;
                dataGridViewSupplies.Rows[i].Cells["columnDate"].Value = data[i].deliveryDate;
                dataGridViewSupplies.Rows[i].Cells["columnCount"].Value = data[i].productCount;
            }
        }

        private async void dataGridViewSupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4 && e.RowIndex > -1 && dataGridViewSupplies.Rows[e.RowIndex].Cells["columnId"].Value != null)
            {
                try 
                {
                    var edited = new Supplies
                    {
                        id = Convert.ToInt32(dataGridViewSupplies.Rows[e.RowIndex].Cells["columnId"].Value),
                        productsId = Convert.ToInt32(dataGridViewSupplies.Rows[e.RowIndex].Cells["ColumnProductId"].Value),
                        deliveryDate = dataGridViewSupplies.Rows[e.RowIndex].Cells["columnDate"].Value.ToString(),
                        productCount = Convert.ToInt32(dataGridViewSupplies.Rows[e.RowIndex].Cells["columnCount"].Value),
                    };
                    var result = await getData.UpdateSupplies(_AuthInfo.access_token, edited);
                    MessageBox.Show(result);
                }
                catch
                {
                    MessageBox.Show("что то пошло не так");
                }
            }
        }
    }
}
