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

namespace BmxShopClient.Present
{
    public partial class AdminForm : Form
    {
        AuthInfo info = new AuthInfo();
        public AdminForm(AuthInfo authInfo)
        {
            this.info = authInfo;
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = info.username;
            labelRole.Text = info.role;
        }
    }
}
