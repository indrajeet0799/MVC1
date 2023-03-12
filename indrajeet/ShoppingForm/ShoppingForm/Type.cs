using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingForm
{
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsShop obj = new clsShop(txtType.Text);
            obj.btnSave();
            MessageBox.Show("success");


        }
    }
}
