using BmxShopClient.Data;
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

namespace Client.Present
{
    public partial class FormAdmin : Form
    {
        AuthInfo _AuthInfo;
        GetData_Impl getdata = new GetData_Impl();
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(AuthInfo authInfo)
        {
            InitializeComponent();
            _AuthInfo = authInfo;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            labelRole.Text = _AuthInfo.role;
            labelUsername.Text = _AuthInfo.username;
            setData();
        }

        private async void setData()
        {
            var data = await getdata.getData(_AuthInfo.access_token);
            foreach (var item in data)
            {
                ListViewItem weatherItem = new ListViewItem(item.Date.ToString());
                weatherItem.SubItems.Add(item.TemperatureC.ToString());
                listView1.Items.Add(weatherItem);
                
            }
        }
    }
}
