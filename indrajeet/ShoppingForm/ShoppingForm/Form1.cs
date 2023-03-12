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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType obj = new frmType();
            obj.Show();
            obj.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct obj = new frmProduct();
            obj.Show();
            obj.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize obj = new frmSize();
            obj.Show();
            obj.MdiParent = this;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister obj = new frmRegister();
            obj.Show();
            obj.MdiParent = this;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
