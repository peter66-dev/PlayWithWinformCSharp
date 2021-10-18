using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using DataAccess;
using DataAccess.Repository;
using BusinessObject;
using System.IO;
using Newtonsoft.Json;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        MemberRepository memRepository = new MemberRepository();
        BindingSource source = new BindingSource();
        List<string> listFilterItems = new List<string>();
        IEnumerable<MemberObject> members = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbShowPsw_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))// Có kí tự trong ô password
            {
                if (txtPassword.PasswordChar == '*')
                {
                    txtPassword.PasswordChar = '\0';
                    lbShowPsw.Text = "Hide";
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                    lbShowPsw.Text = "Show";
                }
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to quit?", "Confirm information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private MemberObject ReadFileJSon()
        {
            MemberObject tmp = new MemberObject();
            try
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string appsettings_path = projectDirectory + "\\" + "appsettings.json";
                using (StreamReader r = new StreamReader(appsettings_path))
                {
                    var json = r.ReadToEnd();
                    tmp = JsonConvert.DeserializeObject<MemberObject>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Get Admin Infor" + ex.Message);
            }
            return tmp;
        }

        private bool CheckForm()
        {
            bool check = true;
            if (txtEmail.TextLength == 0)
            {
                check = false;
                txtEmail.Focus();
                MessageBox.Show("Input Email field!", "Message", MessageBoxButtons.OK);
            }
            else if (txtPassword.TextLength == 0)
            {
                check = false;
                txtPassword.Focus();
                MessageBox.Show("Input Password field!", "Message", MessageBoxButtons.OK);
            }
            return check;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckForm())
                {
                    string emailLogin = txtEmail.Text;
                    string pswLogin = txtPassword.Text;
                    //Login
                    MemberObject admin = ReadFileJSon();
                    if (admin.Email.Equals(emailLogin) && admin.Password.Equals(pswLogin))//vô với role admin
                    {
                        frmMembers frm = new frmMembers();
                        frm.Show();
                    }
                    else
                    {
                        MemberObject memberLogin = new MemberObject();
                        memberLogin = MemberDAO.Instance.GetMemberByEmailPassword(emailLogin, pswLogin);
                        if (memberLogin.MemberID == 0)
                        {
                            MessageBox.Show("Sai email & password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var frmMemberDetails = new frmMemberDetails
                            {
                                Text = "Update a member",
                                InsertOrUpdate = true,
                                ViewOrderHistory = true, // Member được coi lịch sử
                                MemberInfo = memberLogin,
                                MemberRepository = memRepository
                            };
                            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
                            {
                                MessageBox.Show("Updating successfully!", "Message", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at btnLogin_Click: " + ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void lbCreate_Click(object sender, EventArgs e)
        {
            var frmMemberDetails = new frmMemberDetails
            {
                Text = "Update a member",
                InsertOrUpdate = false,
                MemberRepository = memRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Creating a new account successfully!", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
