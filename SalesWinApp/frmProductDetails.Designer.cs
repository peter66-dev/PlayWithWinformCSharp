namespace SalesWinApp
{
    partial class frmProductDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProID = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lbCateID = new System.Windows.Forms.Label();
            this.lbProName = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.lbWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbKg = new System.Windows.Forms.Label();
            this.cboCateID = new System.Windows.Forms.ComboBox();
            this.txtStocks = new System.Windows.Forms.NumericUpDown();
            this.lbUnitsInStock = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProID
            // 
            this.lbProID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProID.AutoSize = true;
            this.lbProID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProID.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbProID.Location = new System.Drawing.Point(143, 181);
            this.lbProID.Name = "lbProID";
            this.lbProID.Size = new System.Drawing.Size(101, 22);
            this.lbProID.TabIndex = 1;
            this.lbProID.Text = "Product ID";
            // 
            // txtProID
            // 
            this.txtProID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProID.Location = new System.Drawing.Point(337, 179);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(208, 29);
            this.txtProID.TabIndex = 1;
            // 
            // lbCateID
            // 
            this.lbCateID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCateID.AutoSize = true;
            this.lbCateID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCateID.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbCateID.Location = new System.Drawing.Point(143, 226);
            this.lbCateID.Name = "lbCateID";
            this.lbCateID.Size = new System.Drawing.Size(112, 22);
            this.lbCateID.TabIndex = 3;
            this.lbCateID.Text = "Category ID";
            // 
            // lbProName
            // 
            this.lbProName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProName.AutoSize = true;
            this.lbProName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbProName.Location = new System.Drawing.Point(143, 271);
            this.lbProName.Name = "lbProName";
            this.lbProName.Size = new System.Drawing.Size(128, 22);
            this.lbProName.TabIndex = 3;
            this.lbProName.Text = "Product Name";
            // 
            // txtProName
            // 
            this.txtProName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProName.Location = new System.Drawing.Point(337, 269);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(208, 29);
            this.txtProName.TabIndex = 3;
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWeight.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbWeight.Location = new System.Drawing.Point(143, 314);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(68, 22);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.Location = new System.Drawing.Point(338, 312);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(207, 29);
            this.txtWeight.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(218, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(1);
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(338, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(1);
            this.btnReset.Size = new System.Drawing.Size(85, 37);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitPrice.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbUnitPrice.Location = new System.Drawing.Point(143, 365);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(92, 22);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Location = new System.Drawing.Point(218, 93);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(255, 42);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Product details";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbKg);
            this.panel1.Controls.Add(this.cboCateID);
            this.panel1.Controls.Add(this.txtStocks);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lbUnitsInStock);
            this.panel1.Controls.Add(this.lbProID);
            this.panel1.Controls.Add(this.txtProID);
            this.panel1.Controls.Add(this.lbCateID);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.lbProName);
            this.panel1.Controls.Add(this.txtProName);
            this.panel1.Controls.Add(this.lbWeight);
            this.panel1.Controls.Add(this.lbUnitPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 661);
            this.panel1.TabIndex = 20;
            // 
            // lbKg
            // 
            this.lbKg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbKg.AutoSize = true;
            this.lbKg.Location = new System.Drawing.Point(551, 319);
            this.lbKg.Name = "lbKg";
            this.lbKg.Size = new System.Drawing.Size(30, 15);
            this.lbKg.TabIndex = 10;
            this.lbKg.Text = "(Kg)";
            // 
            // cboCateID
            // 
            this.cboCateID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCateID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCateID.FormattingEnabled = true;
            this.cboCateID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboCateID.Location = new System.Drawing.Point(337, 227);
            this.cboCateID.Name = "cboCateID";
            this.cboCateID.Size = new System.Drawing.Size(208, 29);
            this.cboCateID.TabIndex = 2;
            // 
            // txtStocks
            // 
            this.txtStocks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStocks.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStocks.Location = new System.Drawing.Point(337, 407);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(208, 29);
            this.txtStocks.TabIndex = 6;
            // 
            // lbUnitsInStock
            // 
            this.lbUnitsInStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitsInStock.AutoSize = true;
            this.lbUnitsInStock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnitsInStock.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbUnitsInStock.Location = new System.Drawing.Point(143, 410);
            this.lbUnitsInStock.Name = "lbUnitsInStock";
            this.lbUnitsInStock.Size = new System.Drawing.Size(126, 22);
            this.lbUnitsInStock.TabIndex = 1;
            this.lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(337, 363);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(207, 29);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // frmProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "frmProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product details";
            this.Load += new System.EventHandler(this.frmProductDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbProID;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lbCateID;
        private System.Windows.Forms.Label lbProName;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.NumericUpDown txtStocks;
        private System.Windows.Forms.ComboBox cboCateID;
        private System.Windows.Forms.Label lbKg;
        private System.Windows.Forms.TextBox txtUnitPrice;
    }
}
