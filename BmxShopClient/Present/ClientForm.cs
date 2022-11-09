using BmxShopClient.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmxShopClient
{
    public partial class ClientForm : Form
    {
        private string token = "";
        private string username;
        private string role;
        public ClientForm(AuthInfo authInfo)
        {
            this.role = authInfo.role;
            this.username = authInfo.username;
            token = authInfo.access_token;
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            label2.Text = role;
            label1.Text = role;
            labelUsername.Text = token;
        }
    }
}
