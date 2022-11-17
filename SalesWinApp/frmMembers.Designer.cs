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
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbProfileManagement = new System.Windows.Forms.Label();
            this.btnOrdersHistory = new System.Windows.Forms.Button();
            this.btnBuyProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(61, 79);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 0;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(61, 125);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(61, 167);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(113, 20);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Company name";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(61, 206);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(61, 247);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(193, 79);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(209, 27);
            this.txtMemberId.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(193, 167);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(209, 27);
            this.txtCompanyName.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(193, 206);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(209, 27);
            this.txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(193, 247);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(209, 27);
            this.txtCountry.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(240, 294);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(171, 29);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbProfileManagement
            // 
            this.lbProfileManagement.AutoSize = true;
            this.lbProfileManagement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProfileManagement.Location = new System.Drawing.Point(103, 23);
            this.lbProfileManagement.Name = "lbProfileManagement";
            this.lbProfileManagement.Size = new System.Drawing.Size(270, 32);
            this.lbProfileManagement.TabIndex = 12;
            this.lbProfileManagement.Text = "PROFILE MANAGEMENT";
            this.lbProfileManagement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOrdersHistory
            // 
            this.btnOrdersHistory.Location = new System.Drawing.Point(240, 345);
            this.btnOrdersHistory.Name = "btnOrdersHistory";
            this.btnOrdersHistory.Size = new System.Drawing.Size(171, 29);
            this.btnOrdersHistory.TabIndex = 13;
            this.btnOrdersHistory.Text = "Orders history";
            this.btnOrdersHistory.UseVisualStyleBackColor = true;
            this.btnOrdersHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuyProducts
            // 
            this.btnBuyProducts.Location = new System.Drawing.Point(51, 345);
            this.btnBuyProducts.Name = "btnBuyProducts";
            this.btnBuyProducts.Size = new System.Drawing.Size(171, 29);
            this.btnBuyProducts.TabIndex = 14;
            this.btnBuyProducts.Text = "Buy Products";
            this.btnBuyProducts.UseVisualStyleBackColor = true;
            this.btnBuyProducts.Click += new System.EventHandler(this.btnBuyProducts_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 398);
            this.Controls.Add(this.btnBuyProducts);
            this.Controls.Add(this.btnOrdersHistory);
            this.Controls.Add(this.lbProfileManagement);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemberId);
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMembers";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMemberId;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberId;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnUpdate;
        private Button btnLogout;
        private Label lbProfileManagement;
        private Button btnOrdersHistory;
        private Button btnBuyProducts;
    }
}