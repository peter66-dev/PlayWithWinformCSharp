using BusinessObject;
using DataAccess.Repository;
using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        public OrderObject orderInfo { get; set; }
        public frmOrderDetails()
        {
            InitializeComponent();
        }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            txtOrderID.Text = orderInfo.OrderID.ToString();
            txtMemberID.Text = orderInfo.MemberID.ToString();
            txtOrderDate.Text = orderInfo.OrderDate.ToString();
            txtRequiredDate.Text = orderInfo.RequiredDate.ToString();
            txtShippedDate.Text = orderInfo.ShippedDate.ToString();
            txtFreight.Text = orderInfo.Freight.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtFreight.Text, out decimal freight) && freight > 0)
            {
                orderRepository.UpdateFreightByOrderID(int.Parse(txtOrderID.Text), decimal.Parse(txtFreight.Text));
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFreight.Clear();
        }
    }
}
