using Client.Data.Models;
using Client.Data;
using Newtonsoft.Json;
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
    public partial class FormSignIn : Form
    {
        SignIn_Impl signin = new SignIn_Impl();
        public FormSignIn()
        {
            InitializeComponent();
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            var result = await signin.SignIn(textBoxName.Text, textBoxLastname.Text, textBoxEmail.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxPassword.Text);
            if (MessageBox.Show(result) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
