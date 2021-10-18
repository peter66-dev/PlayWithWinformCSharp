namespace SalesWinApp
{
    partial class frmMemberDetails
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
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbShowConfirmPassword = new System.Windows.Forms.Label();
            this.lbShowPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbID.Location = new System.Drawing.Point(127, 130);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(105, 22);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Member ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(322, 128);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(144, 29);
            this.txtID.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompanyName.Location = new System.Drawing.Point(322, 173);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(355, 29);
            this.txtCompanyName.TabIndex = 2;
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCompanyName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCompanyName.Location = new System.Drawing.Point(127, 175);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(141, 22);
            this.lbCompanyName.TabIndex = 3;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbEmail.Location = new System.Drawing.Point(127, 220);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 22);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(322, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 29);
            this.txtEmail.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbPassword.Location = new System.Drawing.Point(127, 263);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 22);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(322, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(355, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // lbCity
            // 
            this.lbCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCity.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCity.Location = new System.Drawing.Point(127, 366);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(44, 22);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbCountry.Location = new System.Drawing.Point(127, 412);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(77, 22);
            this.lbCountry.TabIndex = 3;
            this.lbCountry.Text = "Country";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(306, 493);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(1);
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(426, 493);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(1);
            this.btnReset.Size = new System.Drawing.Size(85, 37);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPassword.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbConfirmPassword.Location = new System.Drawing.Point(127, 314);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(163, 22);
            this.lbConfirmPassword.TabIndex = 3;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPassword.Location = new System.Drawing.Point(322, 312);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(355, 29);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // cboCity
            // 
            this.cboCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "TPHCM",
            "Ha Noi",
            "Bang Koc",
            "Vien Chan",
            "Phnom Penh",
            "Kuala Lumpur",
            "Singapore",
            "Jakarta",
            "Manila",
            "Begawan",
            "Dili"});
            this.cboCity.Location = new System.Drawing.Point(322, 364);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(144, 29);
            this.cboCity.TabIndex = 6;
            // 
            // cboCountry
            // 
            this.cboCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCountry.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Lao",
            "Campuchia",
            "Thailand",
            "Myanmar",
            "Malaysia",
            "Singapore",
            "Indonesia",
            "Brunei",
            "Philippines",
            "DongTimor"});
            this.cboCountry.Location = new System.Drawing.Point(322, 410);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(144, 29);
            this.cboCountry.TabIndex = 7;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbTitle.Location = new System.Drawing.Point(294, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(262, 42);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Member details";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbShowConfirmPassword);
            this.panel1.Controls.Add(this.lbShowPassword);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cboCountry);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.cboCity);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lbCompanyName);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbCountry);
            this.panel1.Controls.Add(this.lbConfirmPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 708);
            this.panel1.TabIndex = 20;
            // 
            // lbShowConfirmPassword
            // 
            this.lbShowConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShowConfirmPassword.AutoSize = true;
            this.lbShowConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbShowConfirmPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbShowConfirmPassword.Location = new System.Drawing.Point(698, 319);
            this.lbShowConfirmPassword.Name = "lbShowConfirmPassword";
            this.lbShowConfirmPassword.Size = new System.Drawing.Size(38, 15);
            this.lbShowConfirmPassword.TabIndex = 21;
            this.lbShowConfirmPassword.Text = "Show";
            this.lbShowConfirmPassword.Click += new System.EventHandler(this.lbShowConfirmPassword_Click);
            // 
            // lbShowPassword
            // 
            this.lbShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbShowPassword.AutoSize = true;
            this.lbShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbShowPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbShowPassword.Location = new System.Drawing.Point(698, 268);
            this.lbShowPassword.Name = "lbShowPassword";
            this.lbShowPassword.Size = new System.Drawing.Size(38, 15);
            this.lbShowPassword.TabIndex = 21;
            this.lbShowPassword.Text = "Show";
            this.lbShowPassword.Click += new System.EventHandler(this.lbShowPassword_Click);
            // 
            // frmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 708);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(10000, 3300);
            this.MinimumSize = new System.Drawing.Size(700, 726);
            this.Name = "frmMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member details";
            this.Load += new System.EventHandler(this.frmMemberDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbShowConfirmPassword;
        private System.Windows.Forms.Label lbShowPassword;
    }
}
