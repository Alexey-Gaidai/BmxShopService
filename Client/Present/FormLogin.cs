using Client.Data.Service;
using Client.UseCases;
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
       UserUseCases login = new UserCases_Impl();
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var info = await login.LogIn(textBoxEmail.Text, textBoxPassword.Text);
                if (info.role == "admin")
                {
                    FormAdmin admin = new FormAdmin(info);
                    admin.Show();
                } else
                {
                    Shop user = new Shop(info);
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
