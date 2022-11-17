using BusinessObject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmReport : Form
    {
        private OrderService _orderService = new OrderService();

        private BindingSource _source;

        public frmReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            var reports = _orderService.ReportOrders();
            _source = new BindingSource();
            _source.DataSource = reports;
            dgvReports.DataSource = _source;
        }

        private void LoadReportByDate(DateTime startTime, DateTime endTime)
        {
            var reports = _orderService.ReportOrdersByDate(startTime, endTime);
            _source = new BindingSource();
            _source.DataSource = reports;
            dgvReports.DataSource = _source;
        }

        private void btnReportByDate_Click(object sender, EventArgs e)
        {
            var startTime = dtpStartTime.Value;
            var endTime = dtpEndTime.Value;
            if (startTime <= endTime)
                LoadReportByDate(startTime, endTime);
            else MessageBox.Show("Start Date and End Date are invalid");
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrdersOfDate frm = new frmOrdersOfDate()
            {
                OrderDate = (DateTime)dgvReports.SelectedRows[0].Cells[0].Value
            };
            frm.Show();
        }
        
    }
}
