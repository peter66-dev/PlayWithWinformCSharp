using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmOrderManagement
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbQuantityBuy = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantityBuy = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnAscSort = new System.Windows.Forms.Button();
            this.lbFStore = new System.Windows.Forms.Label();
            this.btnDescSort = new System.Windows.Forms.Button();
            this.txtTotalStatistic = new System.Windows.Forms.TextBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvOrderList.Location = new System.Drawing.Point(15, 372);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.Size = new System.Drawing.Size(1157, 246);
            this.dgvOrderList.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(549, 624);
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
            this.panel1.Controls.Add(this.lbShippedDate);
            this.panel1.Controls.Add(this.lbDiscount);
            this.panel1.Controls.Add(this.lbQuantityBuy);
            this.panel1.Controls.Add(this.txtShippedDate);
            this.panel1.Controls.Add(this.txtRequiredDate);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtQuantityBuy);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.lbRequiredDate);
            this.panel1.Controls.Add(this.lbUnitPrice);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.lbOrderDate);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Controls.Add(this.txtProID);
            this.panel1.Controls.Add(this.lbProductID);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(15, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 208);
            this.panel1.TabIndex = 2;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbShippedDate.Location = new System.Drawing.Point(420, 118);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(99, 19);
            this.lbShippedDate.TabIndex = 0;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDiscount.Location = new System.Drawing.Point(420, 169);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(68, 19);
            this.lbDiscount.TabIndex = 0;
            this.lbDiscount.Text = "Discount";
            // 
            // lbQuantityBuy
            // 
            this.lbQuantityBuy.AutoSize = true;
            this.lbQuantityBuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuantityBuy.Location = new System.Drawing.Point(24, 168);
            this.lbQuantityBuy.Name = "lbQuantityBuy";
            this.lbQuantityBuy.Size = new System.Drawing.Size(98, 19);
            this.lbQuantityBuy.TabIndex = 0;
            this.lbQuantityBuy.Text = "Quantity Buy";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Enabled = false;
            this.txtShippedDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShippedDate.Location = new System.Drawing.Point(550, 118);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(165, 25);
            this.txtShippedDate.TabIndex = 4;
            this.txtShippedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Enabled = false;
            this.txtRequiredDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRequiredDate.Location = new System.Drawing.Point(550, 68);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(165, 25);
            this.txtRequiredDate.TabIndex = 4;
            this.txtRequiredDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscount.Location = new System.Drawing.Point(550, 168);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(105, 25);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantityBuy
            // 
            this.txtQuantityBuy.Enabled = false;
            this.txtQuantityBuy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityBuy.Location = new System.Drawing.Point(126, 167);
            this.txtQuantityBuy.Name = "txtQuantityBuy";
            this.txtQuantityBuy.Size = new System.Drawing.Size(142, 25);
            this.txtQuantityBuy.TabIndex = 3;
            this.txtQuantityBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(126, 117);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(142, 25);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRequiredDate.Location = new System.Drawing.Point(420, 69);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(108, 19);
            this.lbRequiredDate.TabIndex = 0;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(24, 118);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(75, 19);
            this.lbUnitPrice.TabIndex = 0;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderDate.Location = new System.Drawing.Point(550, 19);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(165, 25);
            this.txtOrderDate.TabIndex = 2;
            this.txtOrderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderDate.Location = new System.Drawing.Point(420, 20);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(86, 19);
            this.lbOrderDate.TabIndex = 0;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderID.Location = new System.Drawing.Point(126, 19);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(142, 25);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOrderID.Location = new System.Drawing.Point(24, 20);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(71, 19);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProID.Location = new System.Drawing.Point(126, 68);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(142, 25);
            this.txtProID.TabIndex = 1;
            this.txtProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductID.Location = new System.Drawing.Point(24, 69);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(82, 19);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // btnStatistic
            // 
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatistic.Location = new System.Drawing.Point(435, 326);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(86, 30);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnAscSort
            // 
            this.btnAscSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAscSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAscSort.Location = new System.Drawing.Point(968, 112);
            this.btnAscSort.Name = "btnAscSort";
            this.btnAscSort.Size = new System.Drawing.Size(191, 30);
            this.btnAscSort.TabIndex = 18;
            this.btnAscSort.Text = "Sort Date Ascending";
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
            this.lbFStore.Size = new System.Drawing.Size(309, 40);
            this.lbFStore.TabIndex = 17;
            this.lbFStore.Text = "Order management";
            // 
            // btnDescSort
            // 
            this.btnDescSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescSort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDescSort.Location = new System.Drawing.Point(968, 157);
            this.btnDescSort.Name = "btnDescSort";
            this.btnDescSort.Size = new System.Drawing.Size(191, 30);
            this.btnDescSort.TabIndex = 19;
            this.btnDescSort.Text = "Sort Date Descending";
            this.btnDescSort.UseVisualStyleBackColor = true;
            this.btnDescSort.Click += new System.EventHandler(this.btnDescSort_Click);
            // 
            // txtTotalStatistic
            // 
            this.txtTotalStatistic.Enabled = false;
            this.txtTotalStatistic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalStatistic.Location = new System.Drawing.Point(275, 329);
            this.txtTotalStatistic.Name = "txtTotalStatistic";
            this.txtTotalStatistic.Size = new System.Drawing.Size(145, 25);
            this.txtTotalStatistic.TabIndex = 22;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStart.Location = new System.Drawing.Point(15, 297);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(79, 19);
            this.lbStart.TabIndex = 232;
            this.lbStart.Text = "Start Date";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEnd.Location = new System.Drawing.Point(148, 297);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(72, 19);
            this.lbEnd.TabIndex = 232;
            this.lbEnd.Text = "End Date";
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStart.Location = new System.Drawing.Point(15, 331);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(79, 25);
            this.txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.Location = new System.Drawing.Point(141, 331);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(79, 25);
            this.txtEnd.TabIndex = 3;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "OrderID";
            this.Column8.HeaderText = "Order ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductID";
            this.Column4.HeaderText = "Product ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UnitPrice";
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "QuantityBuy";
            this.Column6.HeaderText = "Quantity Buy";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Discount";
            this.Column7.HeaderText = "Discount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderDate";
            this.Column1.HeaderText = "Order Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "RequiredDate";
            this.Column2.HeaderText = "Required Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ShippedDate";
            this.Column3.HeaderText = "Shipped Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.txtTotalStatistic);
            this.Controls.Add(this.lbFStore);
            this.Controls.Add(this.btnDescSort);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnAscSort);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvOrderList);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmOrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbQuantityBuy;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnAscSort;
        private System.Windows.Forms.Label lbFStore;
        private System.Windows.Forms.Button btnDescSort;
        private TextBox txtTotalStatistic;
        private Label lbStart;
        private Label lbEnd;
        private Label lbDiscount;
        private TextBox txtShippedDate;
        private TextBox txtDiscount;
        private TextBox txtQuantityBuy;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtOrderID;
        private Label lbOrderID;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}