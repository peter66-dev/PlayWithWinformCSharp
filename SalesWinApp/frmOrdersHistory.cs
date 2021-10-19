using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmOrdersHistory : Form
    {
        public IOrderRepository orderRepository { get; set; }
        public MemberObject MemberInfo { get; set; }
        BindingSource source = new BindingSource();
        public frmOrdersHistory()
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
        }
        private void frmOrdersHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistoryList(orderRepository.GetOrderByMemberID(MemberInfo.MemberID));
        }
        private void LoadOrderHistoryList(IEnumerable<OrderHistoryObject> list)
        {
            try
            {
                source.DataSource = list;
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (list.Count() == 0)
                {
                    MessageBox.Show("Sorry, you did not buy anything from my store!", "Message", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
