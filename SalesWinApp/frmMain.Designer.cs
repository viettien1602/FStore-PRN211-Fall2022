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
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManageProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManage,
            this.menuProfile,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(533, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageMember,
            this.menuManageProduct,
            this.menuManageOrder,
            this.menuReport});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(77, 24);
            this.menuManage.Text = "Manage";
            // 
            // menuManageMember
            // 
            this.menuManageMember.Name = "menuManageMember";
            this.menuManageMember.Size = new System.Drawing.Size(224, 26);
            this.menuManageMember.Text = "Manage Member";
            this.menuManageMember.Click += new System.EventHandler(this.menuManageMember_Click);
            // 
            // menuManageProduct
            // 
            this.menuManageProduct.Name = "menuManageProduct";
            this.menuManageProduct.Size = new System.Drawing.Size(224, 26);
            this.menuManageProduct.Text = "Manage Product";
            this.menuManageProduct.Click += new System.EventHandler(this.menuManageProduct_Click);
            // 
            // menuManageOrder
            // 
            this.menuManageOrder.Name = "menuManageOrder";
            this.menuManageOrder.Size = new System.Drawing.Size(224, 26);
            this.menuManageOrder.Text = "Manage Order";
            this.menuManageOrder.Click += new System.EventHandler(this.menuManageOrder_Click);
            // 
            // menuReport
            // 
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(224, 26);
            this.menuReport.Text = "Report Order";
            this.menuReport.Click += new System.EventHandler(this.menuReport_Click);
            // 
            // menuProfile
            // 
            this.menuProfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManageProfile});
            this.menuProfile.Name = "menuProfile";
            this.menuProfile.Size = new System.Drawing.Size(66, 24);
            this.menuProfile.Text = "Profile";
            // 
            // menuManageProfile
            // 
            this.menuManageProfile.Name = "menuManageProfile";
            this.menuManageProfile.Size = new System.Drawing.Size(193, 26);
            this.menuManageProfile.Text = "Manage Profile";
            this.menuManageProfile.Click += new System.EventHandler(this.menuManageProfile_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(47, 24);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 403);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem menuReport;
        private ToolStripMenuItem menuProfile;
        private ToolStripMenuItem menuManageProfile;
        private ToolStripMenuItem menuExit;
    }
}