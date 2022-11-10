using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Client.Present;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Client.Present
{
    public partial class ITEM : UserControl
    {
        public int Data
        {
            get { return Id; }
            set { Id = value; }
        }
        public event EventHandler DataAvailable;
        string PName;
        string Description;
        float Price;
        int Id;
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public ITEM(string name, string desc, float price, int id)
        {
            this.PName = name;
            this.Description = desc;
            this.Price = price;
            this.Id = id;
            InitializeComponent();
        }

        private void ITEM_Load(object sender, EventArgs e)
        {
            materialLabelName.Text = PName;
            materialLabelDesc.Text = Description;
            materialLabelPrice.Text = Price.ToString()+"$";
        }

        private void materialButtonAdd_Click(object sender, EventArgs e)
        {
            OnDataAvailable(null);
        }
    }
}
