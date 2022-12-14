using Client.Data.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Client.Data.Service;
using Client.UseCases;
using Client.Present.Items;
using Application = System.Windows.Forms.Application;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Linq.Expressions;

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
            setUserInfo();
            this.Text = _AuthInfo.username;
            materialTabControl1.SelectedTab = tabPageProducts;
            if(_AuthInfo.role == "user")
                materialTabControl1.TabPages.Remove(tabPageAdmin);
        }

        private async void setUserInfo()
        {
            var user = await getData.LoadAccountInfo(_AuthInfo.access_token, Convert.ToInt32(_AuthInfo.userId));
            tbAccountName.Text = user.Name;
            tbAccountLastname.Text = user.LastName;
            tbAccountEmail.Text = user.Email;
            tbAccountPhone.Text = user.Phone;
            tbAccountImage.Text = user.UserImage;
            mtbAccountAddress.Text = user.Address;
            if(user.UserImage == "")
            {
                pbAccount.ImageLocation = "C:\\Users\\TheHa\\source\\repos\\BmxShopService\\Client\\Present\\images\\defaultImage.jpg";
            } else
                pbAccount.ImageLocation = user.UserImage;
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
        void child_PayClicked(object sender, EventArgs e)
        {
            ItemOrder child = sender as ItemOrder;
            if (child != null)
            {
                payOrder(child);
            }
        }

        private async void deleteOrder(ItemOrder child)
        {
            await getData.DeleteOrder(_AuthInfo.access_token, child.id);
            setOrders();
        }
        private async void payOrder(ItemOrder child)
        {
            MaterialMessageBox.Show("Оплатить?","Оплата");
            var order = new Order
            {
                Id = child.id,
                UserId = child.ord.UserId,
                purchaseDate = child.ord.purchaseDate,
                status = 1,

            };
            await getData.UpdateOrder(_AuthInfo.access_token, order);
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
            var data = await getData.GetProduct<List<Products>>(_AuthInfo.access_token, materialTextBoxFindProducts.Text);
            try
            {
                flowLayoutPanel1.Controls.Clear();
                products = data;
                for (int i = 0; i < data.Count; i++)
                {
                    ItemProduct it = new ItemProduct(data[i]);
                    it.DataAvailable += new EventHandler(child_DataAvailable);
                    flowLayoutPanel1.Controls.Add(it);
                }
            }
            catch
            {
                var t = new Thread(() => Application.Run(new FormLogin()));
                t.Start();
                this.Close();
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
                order.Payment += new EventHandler(child_PayClicked);
                flowLayoutPanel2.Controls.Add(order);
            }
        }

        private async void materialButtonChekout_Click(object sender, EventArgs e)
        {
            var checkout = await getData.CreateOrder(Convert.ToInt32(_AuthInfo.userId), DateTime.Now, true, _AuthInfo.access_token);
            var items = await getData.AddOrderItems(_AuthInfo.access_token,itemsToArray(checkout));
            setOrders();
        }

        private OrderItems[] itemsToArray(string _orderId)
        {
            var items = new OrderItems[basketToOrder.Count];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new OrderItems
                {
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
                materialTabControl1.SelectedTab.Update();
            }
            setSupplies();
        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            setOrders();
        }

        private async void setSupplies()
        {
            try
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
            catch
            {

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

        private void btAccountEdit_Click(object sender, EventArgs e)
        {
            tbAccountName.ReadOnly = false;
            tbAccountLastname.ReadOnly = false;
            tbAccountEmail.ReadOnly = false;
            tbAccountPhone.ReadOnly = false;
            mtbAccountAddress.ReadOnly = false;
            tbAccountImage.ReadOnly = false;
        }

        private async void btAccountSave_Click(object sender, EventArgs e)
        {
            tbAccountName.ReadOnly = true;
            tbAccountLastname.ReadOnly = true;
            tbAccountEmail.ReadOnly = true;
            tbAccountPhone.ReadOnly = true;
            mtbAccountAddress.ReadOnly = true;
            tbAccountImage.ReadOnly = true;
            var user = new User
            {
                Id = Convert.ToInt32(_AuthInfo.userId),
                Name = tbAccountName.Text,
                LastName = tbAccountLastname.Text,
                Email = tbAccountEmail.Text,
                Phone = tbAccountPhone.Text,
                Address = mtbAccountAddress.Text,
                UserImage = tbAccountImage.Text,
            };
            try
            {
                var response = await getData.SaveAccountInfo(_AuthInfo.access_token, user);
            }
            catch
            {
                MaterialMessageBox.Show("Error!!");
            }
        }
    }
}
