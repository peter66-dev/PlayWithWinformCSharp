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
    public partial class frmMemberDetails : Form
    {

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public bool ViewOrderHistory { get; set; } // TRUE > Cho phép hiển thị nút View orders history
        public MemberObject MemberInfo { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            txtID.Enabled = !InsertOrUpdate;
            btnViewHistory.Visible = ViewOrderHistory;
            if (InsertOrUpdate)//UPDATE => KHÔNG ĐƯỢC UPDATE ROLE - ROLE CHỈ ĐƯỢC TẠO
            {
                txtID.Text = MemberInfo.MemberID.ToString();
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtConfirmPassword.Text = MemberInfo.Password;
                cboCity.Text = MemberInfo.City;
                cboCountry.Text = MemberInfo.Country;
            }
            else
            {
                txtID.Visible = false;
                lbID.Visible = false;
            }
        }

        private bool CheckForm()
        {
            bool check = true;
            //if (String.IsNullOrEmpty(txtID.Text.Trim()))
            //{
            //    txtID.Focus();
            //    MessageBox.Show("Sorry, you must full fill in ID field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    check = false;
            //}
            if (String.IsNullOrEmpty(txtCompanyName.Text.Trim()))
            {
                txtCompanyName.Focus();
                MessageBox.Show("Sorry, you must full fill in Name field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                txtEmail.Focus();
                MessageBox.Show("Sorry, you must full fill in Email field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                txtPassword.Focus();
                MessageBox.Show("Sorry, you must full fill in Password field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                txtConfirmPassword.Focus();
                MessageBox.Show("Sorry, you must full fill in Confirm Password field!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                txtPassword.Focus();
                MessageBox.Show("Sorry, Password and Confirm Password don't match together!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (String.IsNullOrEmpty(cboCity.Text.Trim()) || !(
                        cboCity.Text.Equals("Ha Noi", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("TPHCM", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Bang Koc", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Vien Chan", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Phnom Penh", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Kuala Lumpur", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Singapore", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Jakarta", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Manila", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Begawan", StringComparison.OrdinalIgnoreCase)
                        || cboCity.Text.Equals("Dili", StringComparison.OrdinalIgnoreCase)
                        ))
            {
                cboCity.Focus();
                MessageBox.Show("Sorry, City is not valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            else if (String.IsNullOrEmpty(cboCountry.Text.Trim()) || !(
                    cboCountry.Text.Equals("Viet Nam", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Lao", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Campuchia", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Thailand", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Myanmar", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Malaysia", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Singapore", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Indonesia", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Brunei", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("Philippines", StringComparison.OrdinalIgnoreCase)
                    || cboCountry.Text.Equals("DongTimor", StringComparison.OrdinalIgnoreCase)
                    ))
            {
                cboCountry.Focus();
                MessageBox.Show("Sorry, Country is not valid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }
            return check;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckForm())
                {
                    if (InsertOrUpdate)// true > update
                    {
                        var mem = new MemberObject()
                        {
                            MemberID = int.Parse(txtID.Text),
                            CompanyName = txtCompanyName.Text,
                            Email = txtEmail.Text,
                            Password = txtPassword.Text,
                            City = cboCity.Text,
                            Country = cboCountry.Text,
                        };
                        MemberRepository.UpdateMember(mem);
                        MessageBox.Show("Updating a new member successfully!\n" +
                            "Click Load button to see the new information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else // false > insert
                    {
                        var mem = new MemberObject()
                        {
                            CompanyName = txtCompanyName.Text,
                            Email = txtEmail.Text,
                            Password = txtPassword.Text,
                            City = cboCity.Text,
                            Country = cboCountry.Text,
                        };
                        MemberRepository.InsertMember(mem);
                        MessageBox.Show("Adding a new member successfully!\n" +
                            "Click Load button to see the new information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update a member" : "Add a new member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
        }

        private void lbShowPassword_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))// Có kí tự trong ô password
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                    lbShowPassword.Text = "Hide";
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    lbShowPassword.Text = "Show";
                }
            }
        }

        private void lbShowConfirmPassword_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtConfirmPassword.Text))// Có kí tự trong ô confirm password
            {
                if (txtConfirmPassword.PasswordChar == '*')
                {
                    txtConfirmPassword.PasswordChar = '\0';
                    lbShowConfirmPassword.Text = "Hide";
                }
                else
                {
                    txtConfirmPassword.PasswordChar = '*';
                    lbShowConfirmPassword.Text = "Show";
                }
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            MemberObject mem = new MemberObject()
            {
                MemberID = int.Parse(txtID.Text),
                CompanyName = txtCompanyName.Text,
                Email = txtCompanyName.Text,
                Password = txtCompanyName.Text,
                City = txtCompanyName.Text,
                Country = txtCompanyName.Text,
            };
            frmOrdersHistory frm = new frmOrdersHistory()
            {
                MemberInfo = mem
            };
            frm.Show();
        }
    }
}