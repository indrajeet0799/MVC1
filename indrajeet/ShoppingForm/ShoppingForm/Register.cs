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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string Type = (cmbTypeRegister.SelectedItem.ToString());
            string Gender = "";
            if(rdoMale.Checked)
            {
                Gender = rdoMale.Text;
            }
            else
            {
                Gender = rdoFemale.Text;
            }
            int ContactNo = (int)Convert.ToInt64(txtContactNo.Text.ToString());

            clsShop obj = new clsShop (Type,txtNameRegister.Text,txtEmailRegister.Text,txtState.Text,txtPassword.Text,Gender,ContactNo);
            obj.btnRegister();
            MessageBox.Show("successfull");
            
          
        }
    }
}
