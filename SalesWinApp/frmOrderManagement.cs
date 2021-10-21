using System;
using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmOrderManagement : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source = new BindingSource();
        public frmOrderManagement()
        {
            InitializeComponent();
        }
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetOrderHistoryList());
        }
        private void LoadOrderList(IEnumerable<OrderHistoryObject> list)
        {
            try
            {
                if (list.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAscSort.Enabled = false;
                    btnDescSort.Enabled = false;
                    MessageBox.Show("Sorry, system don't have any bill!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (list.Count() == 1)
                {
                    btnDelete.Enabled = false;
                    btnAscSort.Enabled = false;
                    btnDescSort.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnAscSort.Enabled = true;
                    btnDescSort.Enabled = true;
                    txtStart.Enabled = true;
                    txtEnd.Enabled = true;
                    btnStatistic.Enabled = true;
                }
                source.DataSource = list;
                txtOrderID.DataBindings.Clear();
                txtMemID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtMemID.DataBindings.Add("Text", source, "MemberID");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");
                txtTotal.DataBindings.Add("Text", source, "Total");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

                dgvOrderList.Columns["OrderID"].DisplayIndex = 0;
                dgvOrderList.Columns["MemberID"].DisplayIndex = 1;
                dgvOrderList.Columns["OrderDate"].DisplayIndex = 2;
                dgvOrderList.Columns["RequiredDate"].DisplayIndex = 3;
                dgvOrderList.Columns["ShippedDate"].DisplayIndex = 4;
                dgvOrderList.Columns["Freight"].DisplayIndex = 5;
                dgvOrderList.Columns["Total"].DisplayIndex = 6;

                dgvOrderList.Columns["OrderID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //   content
                dgvOrderList.Columns["MemberID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["OrderDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrderList.Columns["RequiredDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrderList.Columns["ShippedDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrderList.Columns["Freight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrderList.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgvOrderList.Columns["OrderID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //   Header
                dgvOrderList.Columns["MemberID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["OrderDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["RequiredDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["ShippedDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["Freight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvOrderList.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvOrderList.Columns["OrderID"].ReadOnly = true;
                dgvOrderList.Columns["MemberID"].ReadOnly = true;
                dgvOrderList.Columns["OrderDate"].ReadOnly = true;
                dgvOrderList.Columns["RequiredDate"].ReadOnly = true;
                dgvOrderList.Columns["ShippedDate"].ReadOnly = true;
                dgvOrderList.Columns["Freight"].ReadOnly = true;
                dgvOrderList.Columns["Total"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Load order history list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearText()
        {
            txtMemID.Clear();
            txtFreight.Clear();
            txtTotal.Clear();
            txtOrderDate.Clear();
            txtRequiredDate.Clear();
            txtShippedDate.Clear();
        }

        OrderObject GetOrderInfo()
        {
            OrderObject ord = new OrderObject()
            {
                OrderID = int.Parse(txtOrderID.Text),
                MemberID = int.Parse(txtMemID.Text),
                Freight = decimal.Parse(txtFreight.Text),
                OrderDate = DateTime.Parse(txtOrderDate.Text),
                RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                ShippedDate = DateTime.Parse(txtShippedDate.Text)
            };
            return ord;

        }
        bool CheckForm()
        {
            bool check = true;
            if (!(int.TryParse(txtStart.Text, out int start) && start > 0))
            {
                check = false;
                txtStart.Focus();
                MessageBox.Show("Start date must be > 0 !", "Message", MessageBoxButtons.OK);
            }
            else if (!(int.TryParse(txtEnd.Text, out int end) && end > 0))
            {
                check = false;
                txtEnd.Focus();
                MessageBox.Show("End date must be > 0 !", "Message", MessageBoxButtons.OK);
            }
            return check;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetOrderHistoryList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateOrders frm = new frmCreateOrders();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails()
            {
                orderInfo = GetOrderInfo()
            };
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtOrderID.Text);
                int productID = int.Parse(txtMemID.Text);
                if (MessageBox.Show($"Are you sure to delete Order ID: {orderID} ,Product ID: {productID}", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //không được delete vì nếu mở rộng sẽ bị tham chiếu khóa trong bảng! Không nên delete, chỉ nên set status = Deactived
                    /*
                    orderRepository.DeleteOrder(orderID);
                    MessageBox.Show($"Deleting Order ID:  {orderID}, Product ID: {productID} successfully!\n" +
                        $"Load again to see the new list", "Error message",
                    MessageBoxButtons.OK);
                    */
                    MessageBox.Show($"Sorry, Admin can not delete this Order ID: {orderID} ,Product ID: {productID}\n" +
                        $"Because this data can reuse with another purpose!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error at btnDelete_Click: {ex.Message}", "Error message",
                    MessageBoxButtons.OK);
            }
        }

        private void btnAscSort_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.SortByTotalAscending());
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.SortByTotalDescending());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    int start = int.Parse(txtStart.Text);
                    int end = int.Parse(txtEnd.Text);
                    if (start <= end)
                    {
                        txtTotalStatistic.Text = Math.Round(orderRepository.StatisticMoney(start, end), 3).ToString();
                        List<OrderHistoryObject> list = orderRepository.GetOrderHistoryList(start, end);
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Don't have any bill in this time!", "Message", MessageBoxButtons.OK);
                        }
                        else
                        {
                            LoadOrderList(list);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sorry, EndDate must be more than StartDate!", "Message", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, Don't have any bill in this time!", "Message", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
