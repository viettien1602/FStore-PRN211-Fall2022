namespace SalesWinApp
{
    partial class frmReport
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
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnReportByDate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(12, 12);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowTemplate.Height = 25;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(615, 297);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Location = new System.Drawing.Point(95, 324);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 23);
            this.dtpStartTime.TabIndex = 3;
            this.dtpStartTime.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Location = new System.Drawing.Point(400, 324);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 23);
            this.dtpEndTime.TabIndex = 4;
            this.dtpEndTime.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(50, 369);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnReportByDate
            // 
            this.btnReportByDate.Location = new System.Drawing.Point(226, 369);
            this.btnReportByDate.Name = "btnReportByDate";
            this.btnReportByDate.Size = new System.Drawing.Size(168, 23);
            this.btnReportByDate.TabIndex = 6;
            this.btnReportByDate.Text = "Report By Date";
            this.btnReportByDate.UseVisualStyleBackColor = true;
            this.btnReportByDate.Click += new System.EventHandler(this.btnReportByDate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(471, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 404);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReportByDate);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReports);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvReports;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Button btnViewAll;
        private Button btnReportByDate;
        private Button btnClose;
    }
}