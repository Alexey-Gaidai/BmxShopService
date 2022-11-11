using Client.Data.Models;
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
using Client.Data.Service;
using Client.UseCases;

namespace Client.Present
{
    public partial class FormSignIn : Form
    {
        UserUseCases SignIn = new UserCases_Impl();
        public FormSignIn()
        {
            InitializeComponent();
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            var result = await SignIn.SignIn(textBoxName.Text, textBoxLastname.Text, textBoxEmail.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxPassword.Text);
            if (MessageBox.Show(result) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
