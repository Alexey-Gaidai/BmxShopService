using Client.Data.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Client.Data.Service;
using Client.UseCases;
using Client.Present.Items;

namespace Client.Present
{
    public partial class Shop : MaterialForm
    {
        DataUseCases getData = new Data_Impl();

        private List<Basket> basketToOrder = new List<Basket>();
        public List<Products> basket = new List<Products>();
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
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               colors["dark-low"], colors["dark"], colors["light"], colors["medium"], TextShade.WHITE
            );
            InitMaterialSkin();
        }

        private void InitMaterialSkin()
        {
            
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            setData();
            this.Text = _AuthInfo.username;
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

        private void addtobasket(ItemProduct child)
        {
            if (basketToOrder.Exists(i => i.productId == child.prodData.Id))
            {
                basketToOrder.Find(i => i.productId == child.prodData.Id).count++;
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
                ListViewItem item = new ListViewItem("1123");
                item.SubItems.Add("212");
                item.SubItems.Add(basketitem.productPrice.ToString());
                materialListView1.Items.Add(item);
            }
        }

        private async void setData()
        {
            var data = await getData.GetProduct(_AuthInfo.access_token);
            foreach (var item in data)
            {
                ItemProduct it = new ItemProduct(item);
                it.DataAvailable += new EventHandler(child_DataAvailable);
                flowLayoutPanel1.Controls.Add(it);
            }
        }

        private async void materialButtonChekout_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            var checkout = await getData.CreateOrder(Convert.ToInt32(_AuthInfo.userId), date.ToString());
            MessageBox.Show(checkout);
        }
    }
}
