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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            clsShop obj = new clsShop();
            DataTable dt = new DataTable();
            dt = obj.getSizeType();
            cmbTypeSize.DisplayMember = "TypeName";
            cmbTypeSize.ValueMember = "TypeId";
            cmbTypeSize.DataSource = dt;
        }

        private void cmbTypeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(cmbTypeSize.SelectedValue.ToString());

            clsShop obj = new clsShop(Id);
            DataTable dt = new DataTable();
            dt = obj.getSizeProduct();
            cmbProductSize.DisplayMember = "ProductName";
            cmbProductSize.ValueMember = "ProductId";
            cmbProductSize.DataSource = dt;

        }

        private void cmbProductSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSize_Click(object sender, EventArgs e)
        {
            int TId = Convert.ToInt32(cmbTypeSize.SelectedValue.ToString());
            int PId = Convert.ToInt32(cmbProductSize.SelectedValue.ToString());
            decimal mrp= Convert.ToDecimal(txtMRP.Text.ToString());
            decimal Price = Convert.ToDecimal(txtRealPrice.Text.ToString());

            clsShop obj = new clsShop(txtSize.Text, mrp,Price,TId,PId);
            obj.btnSaveSize();
            MessageBox.Show("successfully");
            
            

        }
    }
}
