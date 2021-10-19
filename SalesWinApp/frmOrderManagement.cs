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
        IOrderHistoryRepository orderRepository = new OrderHistoryRepository();
        BindingSource source = new BindingSource();
        IEnumerable<OrderHistoryObject> orders = null;
        public frmOrderManagement()
        {
            InitializeComponent();
        }
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetOrdersHistory());
        }
        private void LoadOrderList(IEnumerable<OrderHistoryObject> list)
        {
            try
            {
                source.DataSource = list;
                txtOrderID.DataBindings.Clear();
                txtProID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantityBuy.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtProID.DataBindings.Add("Text", source, "ProductID");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantityBuy.DataBindings.Add("Text", source, "QuantityBuy");
                txtDiscount.DataBindings.Add("Text", source, "Discount");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
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
                    txtStart.Enabled = false;
                    txtEnd.Enabled = false;
                    btnStatistic.Enabled = false;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order history list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearText()
        {
            txtProID.Clear();
            txtUnitPrice.Clear();
            txtQuantityBuy.Clear();
            txtDiscount.Clear();
            txtOrderDate.Clear();
            txtRequiredDate.Clear();
            txtShippedDate.Clear();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetOrdersHistory());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateOrders frm = new frmCreateOrders();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //frm Order Detail
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtOrderID.Text);
                int productID = int.Parse(txtProID.Text);
                if (MessageBox.Show($"Are you sure to delete Order ID: {orderID} ,Product ID: {productID}", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orderRepository.DeleteOrderHistory(orderID, productID);
                    MessageBox.Show($"Deleting Order ID:  {orderID}, Product ID: {productID} successfully!\n" +
                        $"Load again to see the new list", "Error message",
                    MessageBoxButtons.OK);
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
            LoadOrderList(orderRepository.SortOrdersHistoryAscending());
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.SortOrdersHistoryDescending());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

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
