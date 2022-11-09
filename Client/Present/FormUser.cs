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
    public partial class FormUser : Form
    {
        AuthInfo _AuthInfo;
        public FormUser()
        {
            InitializeComponent();
        }
        public FormUser(AuthInfo authInfo)
        {
            _AuthInfo = authInfo;
            InitializeComponent();
        }
    }
}
