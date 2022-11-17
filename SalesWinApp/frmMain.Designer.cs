namespace SalesWinApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageMember = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManage,
            this.menuProfile,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageMember,
            this.menuManageProduct,
            this.menuManageOrder,
            this.menuViewOrderHistory});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(62, 20);
            this.menuManage.Text = "Manage";
            // 
            // menuManageMember
            // 
            this.menuManageMember.Name = "menuManageMember";
            this.menuManageMember.Size = new System.Drawing.Size(171, 22);
            this.menuManageMember.Text = "Manage Member";
            this.menuManageMember.Click += new System.EventHandler(this.menuManageMember_Click);
            // 
            // menuManageProduct
            // 
            this.menuManageProduct.Name = "menuManageProduct";
            this.menuManageProduct.Size = new System.Drawing.Size(171, 22);
            this.menuManageProduct.Text = "Manage Product";
            // 
            // menuManageOrder
            // 
            this.menuManageOrder.Name = "menuManageOrder";
            this.menuManageOrder.Size = new System.Drawing.Size(171, 22);
            this.menuManageOrder.Text = "Manage Order";
            // 
            // menuViewOrderHistory
            // 
            this.menuViewOrderHistory.Name = "menuViewOrderHistory";
            this.menuViewOrderHistory.Size = new System.Drawing.Size(171, 22);
            this.menuViewOrderHistory.Text = "View Order history";
            // 
            // menuProfile
            // 
            this.menuProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageProfile});
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Size = new System.Drawing.Size(53, 20);
            this.menuProfile.Text = "Profile";
            // 
            // menuManageProfile
            // 
            this.menuManageProfile.Name = "menuManageProfile";
            this.menuManageProfile.Size = new System.Drawing.Size(154, 22);
            this.menuManageProfile.Text = "Manage Profile";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(38, 20);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 411);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuManage;
        private ToolStripMenuItem menuManageMember;
        private ToolStripMenuItem menuManageProduct;
        private ToolStripMenuItem menuManageOrder;
        private ToolStripMenuItem menuViewOrderHistory;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuManageProfile;
        private ToolStripMenuItem menuExit;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}