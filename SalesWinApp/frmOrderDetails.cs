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
    public partial class frmOrderDetails : Form
    {
        private OrderDetailService orderDetailService = new();
        public int OrderId { get; set; }
        private BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            var orderDetails = orderDetailService.GetOrderDetails()
                .Where(orderDetail => orderDetail.OrderId == OrderId);
            source = new BindingSource();
            source.DataSource = orderDetails;
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;
            dgvOrderDetail.Columns[5].Visible = false;
            dgvOrderDetail.Columns[6].Visible = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
