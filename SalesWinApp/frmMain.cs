using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderManagement frm = new frmOrderManagement();
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
