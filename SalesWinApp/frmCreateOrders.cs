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
        OrderRepository orderRepository = new OrderRepository();
        OrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        List<ProductObject> cart = new List<ProductObject>();
        public frmCreateOrders()
        {
            InitializeComponent();
        }
        private void frmCreateOrders_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
            btnCheck.Enabled = false;
            btnSave.Enabled = false;
        }

        private void AddToCart(ProductObject pro)
        {
            bool checkExist = false;
            foreach (var p in cart)
            {
                if (p.ProductID == pro.ProductID)
                {
                    p.UnitsInStock += pro.UnitsInStock;
                    checkExist = true;
                }
            }
            if (!checkExist)
            {
                cart.Add(pro);
            }
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

        private bool CheckFormAdd()
        {
            bool check = true;
            if (txtCompanyName.Text.Trim().Length == 0)
            {
                txtEmail.Focus();
                check = false;
                MessageBox.Show("Email is not correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtProName.Text.Trim().Length == 0)
            {
                txtProName.Focus();
                check = false;
                MessageBox.Show("Product ID is not correct!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return check;
        }

        private bool CheckFormCalculation()
        {
            bool check = true;
            try
            {
                if (!(float.TryParse(txtDiscount.Text, out float discount) && (discount >= 0 && discount < 1)))
                {
                    txtDiscount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, discount must be in [0-1) please!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (!(decimal.TryParse(txtFreight.Text, out decimal valuee) && (valuee >= 0 && valuee <= 1000000)))
                {
                    txtFreight.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Freight must be in [0-1000000] VND!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (!(decimal.TryParse(txtPaidAmount.Text, out decimal paid)))
                {
                    txtPaidAmount.Focus();
                    check = false;
                    MessageBox.Show("Sorry, Paid Amount must be in positive number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else
                {
                    double paidAmount = double.Parse(txtPaidAmount.Text);
                    double freight = double.Parse(txtFreight.Text);
                    double grandTotal = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)), 2);
                    if (!(paidAmount - grandTotal - freight >= 0))
                    {
                        check = false;
                        txtPaidAmount.Focus();
                        MessageBox.Show($"Paid Amount: {paidAmount} is not enough for this bill value:\n{grandTotal} + {freight} = {grandTotal + freight}!",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSave.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return check;
        }

        private void LoadProductList()
        {
            try
            {
                dgvProductList.DataSource = null;
                dgvProductList.DataSource = this.cart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error at load Product list!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double SubTotal()
        {
            double result = 0;
            foreach (var pro in cart)
            {
                result += (double)(pro.UnitPrice * pro.UnitsInStock);
            }
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)//add trùng vô
        {
            if (CheckFormAdd())
            {
                txtEmail.Enabled = false; // Khóa email lại và chốt 1 customer này mua thôi
                if (txtQuantityBuy.Value > int.Parse(txtQuantityInStock.Text))
                {
                    MessageBox.Show("Sorry, this product don't have enough for you!", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    ProductObject pro = new ProductObject(int.Parse(txtProID.Text), int.Parse(txtCateID.Text),
                      txtProName.Text, decimal.Parse(txtUnitPrice.Text), Decimal.ToInt32(txtQuantityBuy.Value));
                    AddToCart(pro);
                    LoadProductList();
                    txtSubTotal.Text = SubTotal().ToString();
                    btnCheck.Enabled = true;
                }
            }
        }

        private double GrandTotal(float discount) => SubTotal() * (1 - discount);
        private void btnCheck_Click(object sender, EventArgs e)// check quantity
        {
            if (CheckFormCalculation())
            {
                txtGrandTotal.Text = Math.Round(GrandTotal(float.Parse(txtDiscount.Text)), 2).ToString();
                btnAdd.Enabled = false;
                btnAdd.BackColor = Color.LightGray;
                double returnAmount = double.Parse(txtPaidAmount.Text) - double.Parse(txtGrandTotal.Text) - (double)decimal.Parse(txtFreight.Text);
                txtReturnAmount.Text = Math.Round(returnAmount, 2).ToString();


                //Check quantity in stock!
                List<string> checkQuantityProduct = proRepository.CheckQuantity(cart);
                if (checkQuantityProduct.Count == 0) // Check đủ -> ko add thêm , tiến hành add order | order detail -> btnSave_Click
                {
                    btnSave.Enabled = true;
                    btnSave.BackColor = Color.DeepSkyBlue;
                    MessageBox.Show($"Quantity in stock is enough for this bill\n" +
                        $"Please check bill carefully before save!", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    btnSave.Enabled = false;
                    string msg = "";
                    foreach (string str in checkQuantityProduct)
                    {
                        msg += str + " | ";
                    }
                    MessageBox.Show($"Sorry, we don't have enough quantity for products name: {msg}.\n" +
                        $"Please cancel this bill!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //add new order
            if (CheckFormCalculation())
            {
                int memID = int.Parse(txtMemberID.Text);
                int countingOrders = orderRepository.GetCountingOrders(); // có khóa là int KHÔNG TỰ TĂNG nên phải đếm số lượng rồi +1 làm khóa
                decimal freight = Math.Round(decimal.Parse(txtFreight.Text), 2);
                orderRepository.InsertOrder(++countingOrders, memID, freight); // freight là phí ship!
                bool check = false;
                //add new order details
                foreach (var pro in cart)
                {
                    OrderDetailObject or = new OrderDetailObject()
                    {
                        OrderID = countingOrders,// bug?
                        ProductID = pro.ProductID,
                        UnitPrice = Math.Round(pro.UnitPrice, 2),
                        Quantity = pro.UnitsInStock, // Chỗ này UnitsInStock là số lượng mua của customer
                        Discount = Math.Round(float.Parse(txtDiscount.Text), 5),
                    };
                    orderDetailRepository.InsertOrderDetail(or);

                }

                //Sub quantity in stock 
                List<string> checkQuantityProduct = proRepository.CheckQuantity(cart);
                if (checkQuantityProduct.Count == 0)
                {
                    check = true;
                    proRepository.SubQuantityProduct(cart);
                }
                if (check)
                {
                    MessageBox.Show("Creating order successfully!\n" +
                        "Wait a moment, your product is on its way!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
    }
}
