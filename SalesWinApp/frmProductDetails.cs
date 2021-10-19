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
    public partial class frmProductDetails : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject ProductInfo { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            cboCateID.SelectedIndex = 0;
            txtProID.Visible = InsertOrUpdate; //Nếu update thì đóng, còn insert thì mở
            lbProID.Visible = InsertOrUpdate;
            txtProID.Enabled = !InsertOrUpdate;
            cboCateID.Enabled = true;
            if (InsertOrUpdate)//UPDATE => KHÔNG ĐƯỢC UPDATE ROLE - ROLE CHỈ ĐƯỢC TẠO
            {
                txtProID.Text = ProductInfo.ProductID.ToString();
                cboCateID.SelectedItem = ProductInfo.CategoryID;
                txtProName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtStocks.Text = ProductInfo.UnitsInStock.ToString();
            }
        }
        private bool CheckForm()
        {
            bool check = true;
            if (!(cboCateID.Text.Trim().Equals("1") ||
                cboCateID.Text.Trim().Equals("2") ||
                cboCateID.Text.Trim().Equals("3") ||
                cboCateID.Text.Trim().Equals("4") ||
                cboCateID.Text.Trim().Equals("5") ||
                cboCateID.Text.Trim().Equals("6") ||
                cboCateID.Text.Trim().Equals("7") ||
                cboCateID.Text.Trim().Equals("8")))
            {
                check = false;
                cboCateID.SelectedIndex = 0;
                cboCateID.Focus();
                MessageBox.Show("Sorry, Category ID must be number in [1-8]!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtProName.TextLength == 0)
            {
                check = false;
                txtProName.Focus();
                MessageBox.Show("Sorry, Product Name is not empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!(float.TryParse(txtWeight.Text, out float weight) && weight > 0))
            {
                check = false;
                txtWeight.Focus();
                MessageBox.Show("Sorry, Weight must be float and more than 0!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(double.TryParse(txtUnitPrice.Text, out double unitPrice) && unitPrice > 2000))
            {
                check = false;
                txtUnitPrice.Focus();
                MessageBox.Show("Sorry, this product has so cheap!\nPlease up price!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(int.TryParse(txtStocks.Text, out int quantity) && quantity > 0))
            {
                check = false;
                txtWeight.Focus();
                MessageBox.Show("Sorry, quantity must be more than 0!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return check;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                int categoryID = int.Parse(cboCateID.Text);
                string productName = txtProName.Text.Trim();
                string weight = txtWeight.Text.Trim();
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                int unitsInStock = int.Parse(txtStocks.Text);
                if (InsertOrUpdate) // UPDATE
                {
                    int proID = int.Parse(txtProID.Text);
                    ProductObject pro = new ProductObject(proID, categoryID, productName, weight, unitPrice, unitsInStock);
                    ProductRepository.UpdateProduct(pro);
                    MessageBox.Show("Updating a new product successfully!\nClick Load button to see the new information",
                                                            "Message", MessageBoxButtons.OK);
                    Close();
                }
                else //INSERT
                {
                    ProductRepository.InsertProduct(categoryID, productName, weight, unitPrice, unitsInStock);
                    MessageBox.Show("Adding a new member successfully!\nClick Load button to see the new information",
                                                            "Message", MessageBoxButtons.OK);
                    Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboCateID.SelectedIndex = 0;
            txtProName.Clear();
            txtWeight.Clear();
            txtUnitPrice.Clear();
            txtUnitPrice.Text = "0";
            txtStocks.Value = 0;
        }
    }
}
