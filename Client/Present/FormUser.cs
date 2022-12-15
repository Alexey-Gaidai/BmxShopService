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
            InitializeComponent();
            InitMaterialSkin();
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
            setProducts();
            setUserInfo();
            setProductsAdmin();
            this.Text = _AuthInfo.username;
            materialTabControl1.SelectedTab = tabPageProducts;
            if(_AuthInfo.role == "user")
                materialTabControl1.TabPages.Remove(tabPageAdmin);
        }

        private async void setUserInfo()
        {
            string response = "";
            try
            {
                var user = await getData.LoadAccountInfo(_AuthInfo.access_token, Convert.ToInt32(_AuthInfo.userId));
                response = user.Item2;
                tbAccountName.Text = user.Item1.Name;
                tbAccountLastname.Text = user.Item1.LastName;
                tbAccountEmail.Text = user.Item1.Email;
                tbAccountPhone.Text = user.Item1.Phone;
                tbAccountImage.Text = user.Item1.UserImage;
                mtbAccountAddress.Text = user.Item1.Address;
                if (user.Item1.UserImage == "")
                {
                    pbAccount.ImageLocation = "C:\\Users\\TheHa\\source\\repos\\BmxShopService\\Client\\Present\\images\\defaultImage.jpg";
                }
                else
                    pbAccount.ImageLocation = user.Item1.UserImage;
            } catch (Exception ex)
            {
                if(response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
            
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
            string response = "";
            try
            {
                response = await getData.DeleteOrder(_AuthInfo.access_token, child.id);
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
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
            string response = "";
            try
            {
                response = await getData.UpdateOrder(_AuthInfo.access_token, order);
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
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
                    productName = child.prodData.productName,
                    productPrice = child.prodData.productPrice,
                    count = 1
                };
                basketToOrder.Add(basketitem);
                sum += basketitem.productPrice;
                ListViewItem item = new ListViewItem(basketitem.productName.ToString());
                item.SubItems.Add(basketitem.productPrice.ToString());
                item.SubItems.Add(basketitem.count.ToString());
                materialListView1.Items.Add(item);
            }
        }

        private async void setProducts()
        {
            string response = "";
            try
            {
                var data = await getData.GetProduct<List<Products>>(_AuthInfo.access_token, materialTextBoxFindProducts.Text);
                response = data.Item2.ToString();
                flowLayoutPanel1.Controls.Clear();
                products = data.Item1;
                for (int i = 0; i < data.Item1.Count; i++)
                {
                    ItemProduct it = new ItemProduct(data.Item1[i]);
                    it.DataAvailable += new EventHandler(child_DataAvailable);
                    flowLayoutPanel1.Controls.Add(it);
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void reLogin()
        {
            var t = new Thread(() => Application.Run(new FormLogin()));
            t.Start();
            this.Close();
        }

        private async void setOrders()
        {
            string response = "";
            try
            {
                flowLayoutPanel2.Controls.Clear();
                var data = await getData.GetOrders(_AuthInfo.access_token, _AuthInfo.userId);
                foreach (var item in data.Item1)
                {
                    var ordItems = await getData.GetOrderItems(_AuthInfo.access_token, item.Id.ToString());
                    ItemOrder order = new ItemOrder(item, ordItems.Item1, products);
                    order.OrderDelete += new EventHandler(child_DeleteClicked);
                    order.Payment += new EventHandler(child_PayClicked);
                    flowLayoutPanel2.Controls.Add(order);
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void materialButtonChekout_Click(object sender, EventArgs e)
        {
            string response = "";
            try
            {
                if(basketToOrder.Count < 1)
                {
                    MaterialMessageBox.Show("Нельзя сделать пустой заказ!");
                } else
                {
                    var checkout = await getData.CreateOrder(Convert.ToInt32(_AuthInfo.userId), DateTime.Now, true, _AuthInfo.access_token);
                    var items = await getData.AddOrderItems(_AuthInfo.access_token, itemsToArray(checkout.Item1));
                    response = checkout.Item2;
                    MaterialMessageBox.Show("Заказ успешно оформлен, теперь вы можете перейти на страницу ваших заказов для оплаты", "Заказ оформлен!");
                }
                basketToOrder.Clear();
                materialListView1.Clear();
                materialLabelTotalPrice.Text = "";
                setOrders();
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
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
            setProducts();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_AuthInfo.role != "admin" && materialTabControl1.SelectedTab == tabPageAdmin)
            {
                MessageBox.Show("У вас нет доступа!");
                materialTabControl1.SelectedTab = tabPageProducts;
                materialTabControl1.SelectedTab.Update();
            }
            else if (_AuthInfo.role == "admin")
            {
                setSupplies();
            }

        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            setOrders();
        }

        private async void setSupplies()
        {
            string response = "";
            try
            {
                dataGridViewSupplies.Rows.Clear();
                var data = await getData.GetSupplies<List<Supplies>>(_AuthInfo.access_token);
                response = data.Item2;
                for (int i = 0; i < data.Item1.Count; i++)
                {
                    dataGridViewSupplies.Rows.Add();
                    dataGridViewSupplies.Rows[i].Cells["columnId"].Value = data.Item1[i].id;
                    dataGridViewSupplies.Rows[i].Cells["ColumnProductId"].Value = data.Item1[i].productsId;
                    dataGridViewSupplies.Rows[i].Cells["columnDate"].Value = data.Item1[i].deliveryDate;
                    dataGridViewSupplies.Rows[i].Cells["columnCount"].Value = data.Item1[i].productCount;
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void setProductsAdmin()
        {
            string response = "";
            try
            {
                dataGridViewProducts.Rows.Clear();
                var data = await getData.GetProduct<List<Products>>(_AuthInfo.access_token, "");
                response = data.Item2;
                for (int i = 0; i < data.Item1.Count; i++)
                {
                    dataGridViewProducts.Rows.Add();
                    dataGridViewProducts.Rows[i].Cells[0].Value = data.Item1[i].Id;
                    dataGridViewProducts.Rows[i].Cells[1].Value = data.Item1[i].productName;
                    dataGridViewProducts.Rows[i].Cells[2].Value = data.Item1[i].productDescription;
                    dataGridViewProducts.Rows[i].Cells[3].Value = data.Item1[i].productPrice;
                    dataGridViewProducts.Rows[i].Cells[4].Value = data.Item1[i].categoryId;
                    dataGridViewProducts.Rows[i].Cells[5].Value = data.Item1[i].ManufacturerId;
                    dataGridViewProducts.Rows[i].Cells[6].Value = data.Item1[i].imageLink;
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void dataGridViewSupplies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string response = "";
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
                    response = await getData.UpdateSupplies(_AuthInfo.access_token, edited);
                }
                catch (Exception ex)
                {
                    if (response == "Forbidden")
                    {
                        MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                        reLogin();
                    }
                    else
                    {
                        MaterialMessageBox.Show(ex.Message);
                    }
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
            string response = "";
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
                response = await getData.SaveAccountInfo(_AuthInfo.access_token, user);
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
            setUserInfo();
        }

        private async void materialButtonAddSupply_Click(object sender, EventArgs e)
        {
            string response = "";
            try
            {
                if (tbSupplyCount.Text != "" && tbSupplyDate.Text != "" && tbSupplyProductId.Text != "")
                {
                    var newSupply = new Supplies
                    {
                        productsId = Convert.ToInt32(tbSupplyProductId.Text),
                        productCount = Convert.ToInt32(tbSupplyCount.Text),
                        deliveryDate = tbSupplyDate.Text
                    };
                    response = await getData.AddSupply(_AuthInfo.access_token, newSupply);
                    setSupplies();
                }
                else
                {
                    MaterialMessageBox.Show("Заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void materialButtonAddProduct_Click(object sender, EventArgs e)
        {
            string response = "";
            try
            {
                if (tbProductName.Text != "" && tbProductDescription.Text != "" && tbProductPrice.Text != "" && tbProductCategoryId.Text != "" && tbProductManufacturerId.Text != ""&&tbProductImageLink.Text != "")
                {
                    var newProduct = new Products
                    {
                        productName = tbProductName.Text,
                        productDescription = tbProductDescription.Text,
                        productPrice = float.Parse(tbProductPrice.Text),
                        ManufacturerId = Convert.ToInt32(tbProductManufacturerId.Text),
                        categoryId = Convert.ToInt32(tbProductCategoryId.Text),
                        imageLink = tbProductImageLink.Text,
                    };
                    response = await getData.AddProduct(_AuthInfo.access_token, newProduct);
                    tbProductName.Text = "";
                    tbProductDescription.Text = "";
                    tbProductPrice.Text = "";
                    tbProductManufacturerId.Text = "";
                    tbProductCategoryId.Text = "";
                    tbProductImageLink.Text = "";
                    setProducts();
                    setProductsAdmin();
                }
                else
                {
                    MaterialMessageBox.Show("Заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                if (response == "Forbidden")
                {
                    MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                    reLogin();
                }
                else
                {
                    MaterialMessageBox.Show(ex.Message);
                }
            }
        }

        private async void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string response = "";
            if (e.ColumnIndex == 7 && e.RowIndex > -1 && dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value != null)
            {
                try
                {
                    var edited = new Products
                    {
                        Id = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value),
                        productName = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        productDescription = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        productPrice = (float)Math.Round(Convert.ToDouble(dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value),2),
                        categoryId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[4].Value),
                        ManufacturerId = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells[5].Value),
                        imageLink = dataGridViewProducts.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    };
                    response = await getData.UpdateProducts(_AuthInfo.access_token, edited);
                }
                catch (Exception ex)
                {
                    if (response == "Forbidden")
                    {
                        MaterialMessageBox.Show("Время сеанса истекло. Зайдите в аккаунт заново", response);
                        reLogin();
                    }
                    else
                    {
                        MaterialMessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
