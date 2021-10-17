
namespace SalesWinApp
{
    partial class frmCreateOrders
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
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.lbCustomerInformation = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbProductDetails = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lbProID = new System.Windows.Forms.Label();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.lbCateID = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.lbProName = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbQuantityBuy = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbCalculation = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lbPaidAmount = new System.Windows.Forms.Label();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.lbReturnAmount = new System.Windows.Forms.Label();
            this.lbQuantityInStock = new System.Windows.Forms.Label();
            this.txtQuantityBuy = new System.Windows.Forms.NumericUpDown();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Enabled = false;
            this.dgvProductList.Location = new System.Drawing.Point(12, 242);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.Size = new System.Drawing.Size(580, 307);
            this.dgvProductList.TabIndex = 100;
            // 
            // lbCustomerInformation
            // 
            this.lbCustomerInformation.AutoSize = true;
            this.lbCustomerInformation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerInformation.Location = new System.Drawing.Point(12, 9);
            this.lbCustomerInformation.Name = "lbCustomerInformation";
            this.lbCustomerInformation.Size = new System.Drawing.Size(192, 22);
            this.lbCustomerInformation.TabIndex = 1000;
            this.lbCustomerInformation.Text = "Customer Information";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(449, 42);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 22);
            this.txtMemberID.TabIndex = 100;
            this.txtMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMemberID
            // 
            this.lbMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(329, 45);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(67, 15);
            this.lbMemberID.TabIndex = 3;
            this.lbMemberID.Text = "Member ID";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(735, 42);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(120, 22);
            this.txtCompanyName.TabIndex = 100;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(624, 45);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(91, 15);
            this.lbCompanyName.TabIndex = 3;
            this.lbCompanyName.Text = "Company Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(8, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 15);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(12, 73);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(29, 15);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(329, 73);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(51, 15);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // cboCity
            // 
            this.cboCity.Enabled = false;
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(104, 70);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(133, 23);
            this.cboCity.TabIndex = 100;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCountry.Enabled = false;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(449, 70);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(120, 23);
            this.cboCountry.TabIndex = 100;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Location = new System.Drawing.Point(735, 73);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 2;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(627, 75);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(65, 15);
            this.lbOrderDate.TabIndex = 3;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbProductDetails
            // 
            this.lbProductDetails.AutoSize = true;
            this.lbProductDetails.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductDetails.Location = new System.Drawing.Point(12, 111);
            this.lbProductDetails.Name = "lbProductDetails";
            this.lbProductDetails.Size = new System.Drawing.Size(137, 22);
            this.lbProductDetails.TabIndex = 100;
            this.lbProductDetails.Text = "Product Details";
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(104, 136);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(133, 22);
            this.txtProID.TabIndex = 3;
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProID.TextChanged += new System.EventHandler(this.txtProID_TextChanged);
            // 
            // lbProID
            // 
            this.lbProID.AutoSize = true;
            this.lbProID.Location = new System.Drawing.Point(12, 139);
            this.lbProID.Name = "lbProID";
            this.lbProID.Size = new System.Drawing.Size(65, 15);
            this.lbProID.TabIndex = 3;
            this.lbProID.Text = "Product ID";
            // 
            // txtCateID
            // 
            this.txtCateID.Enabled = false;
            this.txtCateID.Location = new System.Drawing.Point(104, 164);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(133, 22);
            this.txtCateID.TabIndex = 100;
            this.txtCateID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbCateID
            // 
            this.lbCateID.AutoSize = true;
            this.lbCateID.Location = new System.Drawing.Point(12, 167);
            this.lbCateID.Name = "lbCateID";
            this.lbCateID.Size = new System.Drawing.Size(72, 15);
            this.lbCateID.TabIndex = 3;
            this.lbCateID.Text = "Category ID";
            // 
            // txtProName
            // 
            this.txtProName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProName.Enabled = false;
            this.txtProName.Location = new System.Drawing.Point(449, 136);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(120, 22);
            this.txtProName.TabIndex = 100;
            this.txtProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbProName
            // 
            this.lbProName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProName.AutoSize = true;
            this.lbProName.Location = new System.Drawing.Point(329, 139);
            this.lbProName.Name = "lbProName";
            this.lbProName.Size = new System.Drawing.Size(82, 15);
            this.lbProName.TabIndex = 3;
            this.lbProName.Text = "Product Name";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(449, 164);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(120, 22);
            this.txtUnitPrice.TabIndex = 100;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(329, 167);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(59, 15);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Location = new System.Drawing.Point(104, 192);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(133, 22);
            this.txtWeight.TabIndex = 100;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(12, 195);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(46, 15);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Weight";
            // 
            // lbQuantityBuy
            // 
            this.lbQuantityBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantityBuy.AutoSize = true;
            this.lbQuantityBuy.Location = new System.Drawing.Point(624, 169);
            this.lbQuantityBuy.Name = "lbQuantityBuy";
            this.lbQuantityBuy.Size = new System.Drawing.Size(79, 15);
            this.lbQuantityBuy.TabIndex = 3;
            this.lbQuantityBuy.Text = "Quantity Buy";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(872, 154);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(769, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 46);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbCalculation
            // 
            this.lbCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCalculation.AutoSize = true;
            this.lbCalculation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCalculation.Location = new System.Drawing.Point(620, 242);
            this.lbCalculation.Name = "lbCalculation";
            this.lbCalculation.Size = new System.Drawing.Size(166, 22);
            this.lbCalculation.TabIndex = 100;
            this.lbCalculation.Text = "Calculation Details";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(716, 280);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(153, 22);
            this.txtSubTotal.TabIndex = 100;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(624, 283);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(58, 15);
            this.lbSubTotal.TabIndex = 3;
            this.lbSubTotal.Text = "Sub Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.Location = new System.Drawing.Point(716, 321);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(153, 22);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(624, 324);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(56, 15);
            this.lbDiscount.TabIndex = 3;
            this.lbDiscount.Text = "Discount";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(716, 365);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(153, 22);
            this.txtGrandTotal.TabIndex = 100;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.Location = new System.Drawing.Point(624, 368);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(69, 15);
            this.lbGrandTotal.TabIndex = 3;
            this.lbGrandTotal.Text = "Grand Total";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidAmount.Location = new System.Drawing.Point(716, 407);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(153, 22);
            this.txtPaidAmount.TabIndex = 7;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPaidAmount
            // 
            this.lbPaidAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaidAmount.AutoSize = true;
            this.lbPaidAmount.Location = new System.Drawing.Point(624, 410);
            this.lbPaidAmount.Name = "lbPaidAmount";
            this.lbPaidAmount.Size = new System.Drawing.Size(76, 15);
            this.lbPaidAmount.TabIndex = 3;
            this.lbPaidAmount.Text = "Paid Amount";
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReturnAmount.Enabled = false;
            this.txtReturnAmount.Location = new System.Drawing.Point(716, 453);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.Size = new System.Drawing.Size(153, 22);
            this.txtReturnAmount.TabIndex = 100;
            this.txtReturnAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbReturnAmount
            // 
            this.lbReturnAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReturnAmount.AutoSize = true;
            this.lbReturnAmount.Location = new System.Drawing.Point(624, 456);
            this.lbReturnAmount.Name = "lbReturnAmount";
            this.lbReturnAmount.Size = new System.Drawing.Size(89, 15);
            this.lbReturnAmount.TabIndex = 3;
            this.lbReturnAmount.Text = "Return Amount";
            // 
            // lbQuantityInStock
            // 
            this.lbQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantityInStock.AutoSize = true;
            this.lbQuantityInStock.Location = new System.Drawing.Point(329, 198);
            this.lbQuantityInStock.Name = "lbQuantityInStock";
            this.lbQuantityInStock.Size = new System.Drawing.Size(101, 15);
            this.lbQuantityInStock.TabIndex = 3;
            this.lbQuantityInStock.Text = "Quantity In Stock";
            // 
            // txtQuantityBuy
            // 
            this.txtQuantityBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityBuy.Location = new System.Drawing.Point(716, 167);
            this.txtQuantityBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantityBuy.Name = "txtQuantityBuy";
            this.txtQuantityBuy.Size = new System.Drawing.Size(120, 22);
            this.txtQuantityBuy.TabIndex = 4;
            this.txtQuantityBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityInStock.Enabled = false;
            this.txtQuantityInStock.Location = new System.Drawing.Point(449, 192);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(120, 22);
            this.txtQuantityInStock.TabIndex = 100;
            this.txtQuantityInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "VND";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "VND";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "VND";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "VND";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(650, 503);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 46);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmCreateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantityBuy);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbCateID);
            this.Controls.Add(this.lbReturnAmount);
            this.Controls.Add(this.lbPaidAmount);
            this.Controls.Add(this.lbGrandTotal);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.lbQuantityBuy);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbQuantityInStock);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProName);
            this.Controls.Add(this.lbProID);
            this.Controls.Add(this.txtReturnAmount);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCateID);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCalculation);
            this.Controls.Add(this.lbProductDetails);
            this.Controls.Add(this.lbCustomerInformation);
            this.Controls.Add(this.dgvProductList);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmCreateOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateOrders_FormClosing);
            this.Load += new System.EventHandler(this.frmCreateOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label lbCustomerInformation;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbProductDetails;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lbProID;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label lbCateID;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lbProName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbQuantityBuy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbCalculation;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lbGrandTotal;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lbPaidAmount;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.Label lbReturnAmount;
        private System.Windows.Forms.Label lbQuantityInStock;
        private System.Windows.Forms.NumericUpDown txtQuantityBuy;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheck;
    }
}