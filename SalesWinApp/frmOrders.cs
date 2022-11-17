using BusinessObject.Services;
using DataAccess.Models;
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
    public partial class frmOrders : Form
    {
        private OrderService orderService = new();
        public int MemberId { get; set; } = 0;
        private BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
            dgvOrders.CellDoubleClick += DgvOrders_CellDoubleClick;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LoadOrders()
        {
            IEnumerable<Order> orders;
            if (MemberId == 0)
            {
                orders = orderService.GetOrders();
            }
            else
            {
                orders = orderService.GetOrders().Where(order => order.MemberId == MemberId);
            }
            source = new BindingSource();
            source.DataSource = orders;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = source;
        }

        private void DgvOrders_CellDoubleClick(object sender, EventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                OrderId = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString())
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.Cancel)
            {
                frmOrderDetails.Hide();
            }
        }
    }
}
