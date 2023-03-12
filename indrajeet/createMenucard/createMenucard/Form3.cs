using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace createMenucard
{
    public partial class frm3 : Form
    {
        public frm3(string Type,string Menu, String Price)
        {
            InitializeComponent();
            this.Text = Type;
            txtMenu3.Text = Menu;
            txtPrice3.Text = Price;
        }

        private void frm3_Load(object sender, EventArgs e)
        {

        }
    }
}
