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
    public partial class frmProducts : Form
    {
        ProductRepository proRepository = new ProductRepository();
        BindingSource source = new BindingSource();
        IEnumerable<ProductObject> products = null;
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAscSort.Enabled = false;
            btnDescSort.Enabled = false;
        }

        private void LoadProductList(IEnumerable<ProductObject> list)
        {
            try
            {
                source.DataSource = list;
                txtProID.DataBindings.Clear();
                txtCateID.DataBindings.Clear();
                txtProName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtStocks.DataBindings.Clear();

                txtProID.DataBindings.Add("Text", source, "ProductID");
                txtCateID.DataBindings.Add("Text", source, "CategoryID");
                txtProName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtStocks.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnAscSort.Enabled = false;
                    btnDescSort.Enabled = false;
                    MessageBox.Show("Sorry, we can't show result you want!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product list", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearText()
        {
            txtProID.Clear();
            txtCateID.Clear();
            txtProName.Clear();
            txtWeight.Clear();
            txtUnitPrice.Clear();
            txtStocks.Clear();
        }

        

        private ProductObject GetProductObject()
        {
            ProductObject pro = null;
            try
            {
                pro = new ProductObject
                {
                    ProductID = int.Parse(txtProID.Text),
                    CategoryID = int.Parse(txtProID.Text),
                    ProductName = txtProName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtProID.Text),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product Object", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return pro;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtIDSearch.Clear();
            txtNameSearch.Clear();
            products = proRepository.GetProducts();
            LoadProductList(products);
            dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm  = new frmProductDetails()
            {
                Text = "Add a new Product",
                InsertOrUpdate = false,
                ProductRepository = proRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                products = proRepository.GetProducts();
                LoadProductList(products);
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var frm = new frmProductDetails()
            {
                Text = "Update a Product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = proRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                products = proRepository.GetProducts();
                LoadProductList(products);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var pro = GetProductObject();
            if (MessageBox.Show($"Are you sure to delete product name: {pro.ProductName}?", "Confirm message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    source.Position = 0;
                    proRepository.DeleteProduct(pro.ProductID);
                    products = proRepository.GetProducts();
                    LoadProductList(products);
                    dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (proRepository.GetProducts().Count() == 1)
                    {
                        btnDelete.Enabled = false;
                        MessageBox.Show("We have only 1 product existing in list, now.\nPlease don't remove it!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAscSort_Click(object sender, EventArgs e)
        {
            txtIDSearch.Clear();
            txtNameSearch.Clear();
            List<ProductObject> tmp = proRepository.GetProducts().OrderBy(pro => pro.ProductName).ToList<ProductObject>();
            LoadProductList(tmp);
            dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnDescSort_Click(object sender, EventArgs e)
        {
            txtIDSearch.Clear();
            txtNameSearch.Clear();
            List<ProductObject> tmp = proRepository.GetProducts().OrderBy(pro => pro.ProductName).ToList<ProductObject>();
            tmp.Reverse();
            LoadProductList(tmp);
            dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDSearch.TextLength == 0 || txtNameSearch.TextLength == 0)
                {
                    MessageBox.Show("Sorry, you must full fill both ID and Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ProductObject pro = proRepository.GetProductByIDAndName(int.Parse(txtIDSearch.Text), txtNameSearch.Text.Trim());
                    if (pro.UnitsInStock == 0)
                    {
                        MessageBox.Show("Sorry, can't find this Product in system!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //List<ProductObject> list = new List<ProductObject>();
                        //list.Add(pro);
                        //LoadProductList(list);
                        LoadProductList(new List<ProductObject>() { pro });
                        dgvProductList.Columns["ProductID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["CategoryID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["ProductName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dgvProductList.Columns["Weight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvProductList.Columns["UnitsInStock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgvProductList.Columns["ProductID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["CategoryID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["ProductName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["Weight"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvProductList.Columns["UnitsInStock"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception ex)//Nơi bắt lỗi chung!
            {
                MessageBox.Show("Sorry, Product ID must be number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
