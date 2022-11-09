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

namespace Client.Present
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            var result = await SignIn();
            if (MessageBox.Show(result) == DialogResult.OK)
            {
                this.Close();
            }
        }
        public async Task<string> SignIn()
        {
            string data;
            var baseAddress = new Uri("https://localhost:7132");
            string url = "/signin";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("login", textBoxEmail.Text),
                new KeyValuePair<string, string>("password", textBoxPassword.Text),
                new KeyValuePair<string, string>("role", "user")
            });
             
            using (var client = new HttpClient { BaseAddress = baseAddress })
            {
                var result = await client.PostAsync(url, content);
                var bytes = await result.Content.ReadAsByteArrayAsync();

                Encoding encoding = Encoding.GetEncoding("utf-8");
                data = encoding.GetString(bytes, 0, bytes.Length);
                result.EnsureSuccessStatusCode();
                if(result.IsSuccessStatusCode)
                {
                    message = result.StatusCode.ToString();
                }
            }
            return message;
        }
    }
}
