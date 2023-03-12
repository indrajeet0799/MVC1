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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labType_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbxMenu.Items.Clear();
            if (cmbbxType.Text == "MH") 
            {
                cmbbxMenu.Items.Add("poha");
                cmbbxMenu.Items.Add("vadapav");
            }
            if (cmbbxType.Text == "GJ")
            {
                cmbbxMenu.Items.Add("khakra");
                cmbbxMenu.Items.Add("misal");
            }
            if (cmbbxType.Text == "SOUTH IMDIAN")
            {
                cmbbxMenu.Items.Add("dosa");
                cmbbxMenu.Items.Add("uttapa");
            }

        }

        private void cmbbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Menu = cmbbxMenu.SelectedItem.ToString();
            if (Menu == "poha")
            {
                txtPrice.Text = "10";
            }
            if ( Menu == "vadapav")
            {
                txtPrice.Text = "20";
            }
            if (Menu == "khakra")
            {
                txtPrice.Text = "30";
            }
            if (Menu == "misal")
            {
                txtPrice.Text = "40";
            }
            if (Menu == "dosa")
            {
                txtPrice.Text = "50";
            }
            if (Menu == "uttapa")
            {
                txtPrice.Text = "60";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string Type = cmbbxType.Text;
            string Menu = cmbbxMenu.Text;
            string Price = txtPrice.Text;

            frm3 objForm = new frm3( Type,Menu,Price);
            objForm.Show();
        }
    }
}
