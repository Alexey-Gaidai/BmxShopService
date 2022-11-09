using BmxShopClient.Data;
using BmxShopClient.Present;
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
    public partial class LoginForm : Form
    {
        Login_impl login = new Login_impl();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var authInfo = await login.SendRequest(textBoxEmail.Text, textBoxPassword.Text);
                Console.WriteLine(authInfo.role);
                AdminForm admin = new AdminForm(authInfo);
                admin.Show();
                this.Hide();
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
