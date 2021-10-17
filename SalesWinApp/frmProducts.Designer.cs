using System;
using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmProducts
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
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStocks = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbCateID = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.lbProName = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lbProID = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAscSort = new System.Windows.Forms.Button();
            this.lbFStore = new System.Windows.Forms.Label();
            this.btnDescSort = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.CategoryID,
            this.ProductName,
            this.Weight,
            this.UnitPrice,
            this.UnitsInStock});
            this.dgvProductList.Location = new System.Drawing.Point(15, 372);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowTemplate.Height = 25;
            this.dgvProductList.Size = new System.Drawing.Size(1157, 325);
            this.dgvProductList.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;

            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;

            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;

            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;

            // 
            // UnitsInStock
            // 
            this.UnitsInStock.DataPropertyName = "UnitsInStock";
            this.UnitsInStock.HeaderText = "Units In Stock";
            this.UnitsInStock.Name = "UnitsInStock";
            this.UnitsInStock.ReadOnly = true;

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
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.lbStocks);
            this.panel1.Controls.Add(this.lbUnitPrice);
            this.panel1.Controls.Add(this.txtStocks);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtCateID);
            this.panel1.Controls.Add(this.lbWeight);
            this.panel1.Controls.Add(this.lbCateID);
            this.panel1.Controls.Add(this.txtProName);
            this.panel1.Controls.Add(this.lbProName);
            this.panel1.Controls.Add(this.txtProID);
            this.panel1.Controls.Add(this.lbProID);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(15, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 180);
            this.panel1.TabIndex = 2;
            // 
            // lbStocks
            // 
            this.lbStocks.AutoSize = true;
            this.lbStocks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStocks.Location = new System.Drawing.Point(420, 118);
            this.lbStocks.Name = "lbStocks";
            this.lbStocks.Size = new System.Drawing.Size(104, 19);
            this.lbStocks.TabIndex = 0;
            this.lbStocks.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.Location = new System.Drawing.Point(21, 118);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(75, 19);
            this.lbUnitPrice.TabIndex = 0;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // txtStocks
            // 
            this.txtStocks.Enabled = false;
            this.txtStocks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStocks.Location = new System.Drawing.Point(550, 118);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.ReadOnly = true;
            this.txtStocks.Size = new System.Drawing.Size(202, 25);
            this.txtStocks.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.Location = new System.Drawing.Point(550, 68);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(202, 25);
            this.txtWeight.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(123, 117);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(202, 25);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // txtCateID
            // 
            this.txtCateID.Enabled = false;
            this.txtCateID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCateID.Location = new System.Drawing.Point(123, 67);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.Size = new System.Drawing.Size(202, 25);
            this.txtCateID.TabIndex = 3;
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.Location = new System.Drawing.Point(420, 69);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 19);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "Weight";
            // 
            // lbCateID
            // 
            this.lbCateID.AutoSize = true;
            this.lbCateID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCateID.Location = new System.Drawing.Point(21, 68);
            this.lbCateID.Name = "lbCateID";
            this.lbCateID.Size = new System.Drawing.Size(93, 19);
            this.lbCateID.TabIndex = 0;
            this.lbCateID.Text = "Category ID";
            // 
            // txtProName
            // 
            this.txtProName.Enabled = false;
            this.txtProName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProName.Location = new System.Drawing.Point(550, 19);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(202, 25);
            this.txtProName.TabIndex = 2;
            // 
            // lbProName
            // 
            this.lbProName.AutoSize = true;
            this.lbProName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProName.Location = new System.Drawing.Point(420, 20);
            this.lbProName.Name = "lbProName";
            this.lbProName.Size = new System.Drawing.Size(104, 19);
            this.lbProName.TabIndex = 0;
            this.lbProName.Text = "Product Name";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProID.Location = new System.Drawing.Point(123, 18);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(202, 25);
            this.txtProID.TabIndex = 1;
            // 
            // lbProID
            // 
            this.lbProID.AutoSize = true;
            this.lbProID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProID.Location = new System.Drawing.Point(21, 19);
            this.lbProID.Name = "lbProID";
            this.lbProID.Size = new System.Drawing.Size(82, 19);
            this.lbProID.TabIndex = 0;
            this.lbProID.Text = "Product ID";
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
            this.lbFStore.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbFStore.Location = new System.Drawing.Point(467, 9);
            this.lbFStore.Name = "lbFStore";
            this.lbFStore.Size = new System.Drawing.Size(337, 40);
            this.lbFStore.TabIndex = 17;
            this.lbFStore.Text = "Product management";
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
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameSearch.Location = new System.Drawing.Point(111, 331);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.PlaceholderText = "Input product name";
            this.txtNameSearch.Size = new System.Drawing.Size(137, 25);
            this.txtNameSearch.TabIndex = 13;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 740);
            this.Controls.Add(this.lbFStore);
            this.Controls.Add(this.btnDescSort);
            this.Controls.Add(this.btnAscSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvProductList);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProducts_FormClosing);
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStocks;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbCateID;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lbProName;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lbProID;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAscSort;
        private System.Windows.Forms.Label lbFStore;
        private System.Windows.Forms.Button btnDescSort;
        private System.Windows.Forms.TextBox txtNameSearch;
        private TextBox txtStocks;
        private TextBox txtUnitPrice;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn UnitsInStock;
    }
}