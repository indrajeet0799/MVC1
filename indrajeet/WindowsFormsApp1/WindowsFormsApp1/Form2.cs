using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGrdViewStaffInf : Form
    {
        public frmGrdViewStaffInf()
        {
            InitializeComponent();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            frmstaffinf obj = new frmstaffinf();
            obj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
