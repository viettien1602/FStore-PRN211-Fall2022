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
    public partial class frmCart : Form
    {
        private OrderService orderService = new();
        private OrderDetailService orderDetailService = new();
        private ProductService productService = new();
        public List<OrderDetail> orderDetails;
        public int MemberId { get; set; }
        private BindingSource source;
        public frmCart()
        {
            InitializeComponent();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            dtRequiredDate.Text = DateTime.Now.AddDays(3).ToString();
            LoadCart();
            
        }

        private void LoadCart()
        {
            source = new BindingSource();
            source.DataSource = orderDetails;
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = source;
            if (orderDetails.Count == 0)
            {
                btnRemove.Enabled = false;
                btnConfirm.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnConfirm.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OrderDetail currentOrderDetail = orderDetails.Find(o => o.ProductId == int.Parse(dgvOrderDetails.CurrentRow.Cells[1].Value.ToString()));
            orderDetails.Remove(currentOrderDetail);
            LoadCart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime requiredDate = DateTime.Parse(dtRequiredDate.Text);
            DateTime shippedDate = DateTime.Now.AddDays(2);
            DateTime orderDate = DateTime.Now;
            if (requiredDate <= shippedDate)
            {
                MessageBox.Show("Required Date can must be at least 3 days after today");
            }
            else
            {
                decimal totalPrice = 0;
                orderDetails.ForEach(o =>
                {
                    totalPrice += o.UnitPrice * o.Quantity;
                });
                DialogResult dialog = MessageBox.Show($"Your total price is {totalPrice}, do you want to confirm?", "Cancel", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Order order = orderService.AddOrder(new Order
                    {
                        MemberId = this.MemberId,
                        OrderDate = orderDate,
                        RequiredDate = requiredDate,
                        ShippedDate = shippedDate,
                        Freight = totalPrice
                    });
                    orderDetails.ForEach(o =>
                    {
                        /*o.Order = order;
                        o.Product = productService.GetProducts().FirstOrDefault(p => p.ProductId == o.ProductId);*/
                        Product buyingProduct = productService.GetProducts().FirstOrDefault(p => p.ProductId == o.ProductId);
                        o.OrderId = order.OrderId;
                        o.ProductId = buyingProduct.ProductId;
                        orderDetailService.Add(o);
                        buyingProduct.UnitsInStock -= o.Quantity;
                        productService.Update(buyingProduct);

                    });
                    
                    this.DialogResult = DialogResult.Cancel;
                }
                
            }
            
        }
    }
}
