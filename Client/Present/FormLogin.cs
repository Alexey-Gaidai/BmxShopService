using Client.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Present
{
    public partial class FormLogin : Form
    {
        Login_impl login = new Login_impl();
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var info = await login.SendRequest(textBoxEmail.Text, textBoxPassword.Text);
                if (info.role == "admin")
                {
                    FormAdmin admin = new FormAdmin(info);
                    admin.Show();
                } else
                {
                    FormUser user = new FormUser(info);
                    user.Show();

                }
                this.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            FormSignIn signIn = new FormSignIn();
            signIn.Show();
        }
    }
}
