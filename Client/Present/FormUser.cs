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
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BmxShopClient.Data;
using System.Xml.Linq;

namespace Client.Present
{
    public partial class Shop : MaterialForm
    {
        public List<int> basket = new List<int>();
        AuthInfo _AuthInfo;
        GetData_Impl getData = new GetData_Impl();
        public Shop()
        {
            InitializeComponent();
        }
        public Shop(AuthInfo authInfo)
        {
            _AuthInfo = authInfo;
            InitializeComponent();

            Dictionary<string, Color> _colors = new Dictionary<string, Color>()
            {
                { "dark", Color.FromArgb(51, 54, 41) },
                { "dark-low", Color.FromArgb(75, 79, 62) },
                { "medium", Color.FromArgb(129, 135, 109) },
                { "light", Color.FromArgb(181, 187, 164)},
                { "very-light", Color.FromArgb(226, 230, 215) },
            };

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
               _colors["dark-low"], _colors["dark"], _colors["light"], _colors["medium"], TextShade.WHITE
            );
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            setData();
        }
        void child_DataAvailable(object sender, EventArgs e)
        {
            ITEM child = sender as ITEM;
            if (child != null)
            {
                basket.Add(child.Data);
            }
        }
        private async void setData()
        {
            var data = await getData.getProduct(_AuthInfo.access_token);
            foreach (var item in data)
            {
                
                ITEM it = new ITEM(item.productName,item.productDescription, item.productPrice,item.Id);
                it.DataAvailable += new EventHandler(child_DataAvailable);
                flowLayoutPanel1.Controls.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string items = "";
            foreach (var item in basket)
            {
                items += item.ToString();
            }
            MessageBox.Show(items);
        }
    }
}
