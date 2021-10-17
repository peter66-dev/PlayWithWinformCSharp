using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAscSort = new System.Windows.Forms.Button();
            this.lbFStore = new System.Windows.Forms.Label();
            this.btnDescSort = new System.Windows.Forms.Button();
            this.txtEmailSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgvMemberList.Location = new System.Drawing.Point(15, 372);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.Size = new System.Drawing.Size(1157, 325);
            this.dgvMemberList.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MemberID";
            this.Column1.HeaderText = "Member ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CompanyName";
            this.Column2.HeaderText = "Company Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Password";
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Role";
            this.Column7.HeaderText = "Role";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "City";
            this.Column5.HeaderText = "City";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Country";
            this.Column6.HeaderText = "Country";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(852, 69);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 30);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(852, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(852, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(852, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(549, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 28);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbRole);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbMemberID);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(15, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 212);
            this.panel1.TabIndex = 2;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(420, 118);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(63, 19);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.Text = "Country";
            // 
            // cboCountry
            // 
            this.cboCountry.Enabled = false;
            this.cboCountry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Việt Nam",
            "Lào",
            "Campuchia",
            "Thái Lan",
            "Myanmar",
            "Malaysia",
            "Singapore",
            "Indonesia",
            "Brunei",
            "Philippines",
            "Đông Timor"});
            this.cboCountry.Location = new System.Drawing.Point(550, 121);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(202, 25);
            this.cboCountry.TabIndex = 6;
            // 
            // cboCity
            // 
            this.cboCity.Enabled = false;
            this.cboCity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Hà Nội",
            "Bang Kốc",
            "Viên Chăn",
            "Phnôm Pênh",
            "Kuala Lumpur",
            "Singapore",
            "Jakarta",
            "Manila",
            "Begawan",
            "Dili"});
            this.cboCity.Location = new System.Drawing.Point(123, 119);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(202, 25);
            this.cboCity.TabIndex = 5;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(21, 118);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(37, 19);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(550, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(202, 25);
            this.txtPassword.TabIndex = 4;
            // 
            // txtRole
            // 
            this.txtRole.Enabled = false;
            this.txtRole.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRole.Location = new System.Drawing.Point(123, 168);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(202, 25);
            this.txtRole.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(123, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRole.Location = new System.Drawing.Point(21, 169);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(41, 19);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(420, 69);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(72, 19);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(21, 68);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 19);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.Location = new System.Drawing.Point(550, 19);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(202, 25);
            this.txtCompanyName.TabIndex = 2;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCompanyName.Location = new System.Drawing.Point(420, 20);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 19);
            this.lbCompanyName.TabIndex = 0;
            this.lbCompanyName.Text = "Company Name";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(123, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(202, 25);
            this.txtID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMemberID.Location = new System.Drawing.Point(21, 19);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(89, 19);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDSearch.Location = new System.Drawing.Point(15, 331);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.PlaceholderText = "Input ID";
            this.txtIDSearch.Size = new System.Drawing.Size(90, 25);
            this.txtIDSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(254, 326);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAscSort
            // 
            this.btnAscSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAscSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAscSort.Location = new System.Drawing.Point(968, 112);
            this.btnAscSort.Name = "btnAscSort";
            this.btnAscSort.Size = new System.Drawing.Size(191, 30);
            this.btnAscSort.TabIndex = 18;
            this.btnAscSort.Text = "Sort Name Ascending";
            this.btnAscSort.UseVisualStyleBackColor = true;
            this.btnAscSort.Click += new System.EventHandler(this.btnAscSort_Click);
            // 
            // lbFStore
            // 
            this.lbFStore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFStore.AutoSize = true;
            this.lbFStore.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFStore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbFStore.Location = new System.Drawing.Point(467, 9);
            this.lbFStore.Name = "lbFStore";
            this.lbFStore.Size = new System.Drawing.Size(343, 40);
            this.lbFStore.TabIndex = 17;
            this.lbFStore.Text = "Member management";
            // 
            // btnDescSort
            // 
            this.btnDescSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDescSort.Location = new System.Drawing.Point(968, 157);
            this.btnDescSort.Name = "btnDescSort";
            this.btnDescSort.Size = new System.Drawing.Size(191, 30);
            this.btnDescSort.TabIndex = 19;
            this.btnDescSort.Text = "Sort Name Descending";
            this.btnDescSort.UseVisualStyleBackColor = true;
            this.btnDescSort.Click += new System.EventHandler(this.btnDescSort_Click);
            // 
            // txtEmailSearch
            // 
            this.txtEmailSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmailSearch.Location = new System.Drawing.Point(111, 331);
            this.txtEmailSearch.Name = "txtEmailSearch";
            this.txtEmailSearch.PlaceholderText = "Input Email";
            this.txtEmailSearch.Size = new System.Drawing.Size(137, 25);
            this.txtEmailSearch.TabIndex = 13;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 740);
            this.Controls.Add(this.lbFStore);
            this.Controls.Add(this.btnDescSort);
            this.Controls.Add(this.btnAscSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmailSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvMemberList);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMembers_FormClosing);
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAscSort;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Label lbFStore;
        private System.Windows.Forms.Button btnDescSort;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtEmailSearch;
    }
}