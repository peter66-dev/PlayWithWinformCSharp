
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
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
            this.label15 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.lbQuantityInStock = new System.Windows.Forms.Label();
            this.txtQuantityBuy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProductList.Location = new System.Drawing.Point(12, 242);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.Size = new System.Drawing.Size(580, 307);
            this.dgvProductList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unit Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity Buy";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(449, 42);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 22);
            this.txtMemberID.TabIndex = 2;
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
            this.txtCompanyName.TabIndex = 2;
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
            this.txtEmail.TabIndex = 2;
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
            this.cboCity.TabIndex = 4;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCountry.Enabled = false;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(449, 70);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(120, 23);
            this.cboCountry.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Location = new System.Drawing.Point(735, 73);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 22);
            this.txtDate.TabIndex = 5;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Details";
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(104, 136);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(133, 22);
            this.txtProID.TabIndex = 2;
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
            this.txtCateID.TabIndex = 2;
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
            this.txtProName.TabIndex = 2;
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
            this.txtUnitPrice.TabIndex = 2;
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
            this.txtWeight.TabIndex = 2;
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
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.Location = new System.Drawing.Point(688, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(620, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Calculation Details";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(716, 280);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 22);
            this.textBox10.TabIndex = 2;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(624, 283);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Sub Total";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(716, 321);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 22);
            this.textBox11.TabIndex = 2;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(624, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 3;
            this.label17.Text = "Discount (%)";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(716, 365);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(153, 22);
            this.textBox12.TabIndex = 2;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(624, 368);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Grand Total";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Location = new System.Drawing.Point(716, 407);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(153, 22);
            this.textBox13.TabIndex = 2;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(624, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "Paid Amount";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(716, 453);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(153, 22);
            this.textBox14.TabIndex = 2;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(624, 456);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "Return Amount";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityInStock.Enabled = false;
            this.txtQuantityInStock.Location = new System.Drawing.Point(449, 195);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(120, 22);
            this.txtQuantityInStock.TabIndex = 2;
            this.txtQuantityInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtQuantityBuy.TabIndex = 9;
            this.txtQuantityBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCreateOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.txtQuantityBuy);
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
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbQuantityBuy);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbQuantityInStock);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProName);
            this.Controls.Add(this.lbProID);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.txtCateID);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQuantityInStock);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductList);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(975, 600);
            this.Name = "frmCreateOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateOrders_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Label lbQuantityInStock;
        private System.Windows.Forms.NumericUpDown txtQuantityBuy;
    }
}