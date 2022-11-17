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
    public partial class frmOrdersOfDate : Form
    {
        private OrderService _orderService = new OrderService();

        private BindingSource _source;
        public DateTime OrderDate;
        public frmOrdersOfDate()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrdersOfDate_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Value = OrderDate;
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetOrders().Where(x => x.OrderDate.Date == dateTimePicker1.Value.Date).ToList();
            _source = new BindingSource();
            _source.DataSource = orders;
            dataGridView1.DataSource = _source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetails frmOrderDetails = new frmOrderDetails
            {
                OrderId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())
            };
            if (frmOrderDetails.ShowDialog() == DialogResult.Cancel)
            {
                frmOrderDetails.Hide();
            }
        }
    }
}
