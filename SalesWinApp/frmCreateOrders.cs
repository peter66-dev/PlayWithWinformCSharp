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
    public partial class frmCreateOrders : Form
    {
        MemberRepository memRepository = new MemberRepository();
        ProductRepository proRepository = new ProductRepository();
        BindingSource source = new BindingSource();
        IEnumerable<MemberObject> members = null;
        IEnumerable<ProductObject> products = null;
        public frmCreateOrders()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length != 0)
            {
                MemberObject mem = memRepository.GetMemberByEmail(txtEmail.Text.Trim());
                if (mem.MemberID != 0)
                {
                    txtMemberID.Text = mem.MemberID.ToString();
                    txtCompanyName.Text = mem.CompanyName;
                    cboCity.Text = mem.City;
                    cboCountry.Text = mem.Country;
                }
                else
                {
                    ClearCustomerInfo();
                }
            }
            else
            {
                ClearCustomerInfo();
            }
        }

        private void ClearCustomerInfo()
        {
            txtMemberID.Clear();
            txtCompanyName.Clear();
            cboCity.Text = "";
            cboCountry.Text = "";
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        // Vì nhân viên của cửa hàng đó sẽ thường tra sản phẩm theo ID, hy vọng cô hiểu ý em tại sao ko search theo Product Name
        {
            if (txtProID.Text.Trim().Length != 0)
            {
                if (Int32.TryParse(txtProID.Text, out int id) && id > 0)
                {
                    ProductObject pro = proRepository.GetProductByID(int.Parse(txtProID.Text));
                    if (pro.ProductName.Length > 0)
                    {
                        txtProName.Text = pro.ProductName;
                        txtCateID.Text = pro.CategoryID.ToString();
                        txtWeight.Text = pro.Weight;
                        txtUnitPrice.Text = pro.UnitPrice.ToString();
                        txtQuantityInStock.Text = pro.UnitsInStock.ToString();
                    }
                    else
                    {
                        ClearProductText();
                    }
                }
                else
                {
                    ClearProductText();
                    MessageBox.Show("Sorry, Product ID must be a positive integer please !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                ClearProductText();
            }
        }

        private void ClearProductText()
        {
            txtProName.Clear();
            txtCateID.Clear();
            txtUnitPrice.Clear();
            txtWeight.Clear();
            txtQuantityInStock.Clear();
        }

        private bool CheckForm()
        {
            bool check = true;
            if (txtCompanyName.Text.Trim().Length == 0)
            {
                txtEmail.Focus();
                check = false;
                MessageBox.Show("Email is not correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (txtProName.Text.Trim().Length == 0)
            {
                txtProName.Focus();
                check = false;
                MessageBox.Show("Product ID is not correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return check;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                txtEmail.Enabled = false; // Khóa email lại và chốt 1 customer này mua thôi

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmCreateOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
