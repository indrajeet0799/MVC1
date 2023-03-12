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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            clsShop obj = new clsShop();
            DataTable dt = new DataTable();
            dt = obj.GetProduct();
            cmbTypeProduct.DisplayMember = "TypeName";
            cmbTypeProduct.ValueMember = "TypeId";
            cmbTypeProduct.DataSource = dt;
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbTypeProduct.SelectedValue.ToString());
            clsShop obj = new clsShop(txtProduct.Text, Convert.ToInt32(cmbTypeProduct.SelectedValue.ToString()));
            obj.btnSaveProduct();
            MessageBox.Show("success");
        }

        private void cmbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
