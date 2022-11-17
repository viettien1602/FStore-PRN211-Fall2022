using BusinessObject.Services;
using DataAccess.Models;
using DataAccess.Repository;
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
    public partial class frmBuyProducts : Form
    {
        private ProductService productService = new();
        private BindingSource source;
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        public int MemberId;
        public frmBuyProducts()
        {
            InitializeComponent();
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }


        private void frmBuyProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            dgvProducts.CellClick += DgvProducts_CellClick;
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProduct.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtUnit.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void ClearText()
        {
            txtProduct.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtUnit.Text = string.Empty;
        }

        private void LoadProducts(string search = null)
        {
            var products = productService.GetProducts();
            try
            {
                if (search != null)
                {
                    products = products.FindAll(product => product.ProductName.ToUpper().Contains(search.ToUpper().Trim()));
                }
                source = new BindingSource();
                source.DataSource = products;


                dgvProducts.DataSource = null;
                dgvProducts.DataSource = products;

                txtProduct.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                txtUnit.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtProduct.Enabled = false;
                txtUnit.Enabled = false;

                if (products.Count() == 0)
                {
                    ClearText();
                    btnBuy.Enabled = false;
                    btnCheckout.Enabled = false;
                }
                else
                {
                    btnBuy.Enabled = true;
                    btnCheckout.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private Product GetCurrentProduct()
        {
            if (dgvProducts.CurrentRow != null)
            {
                return productService.GetProducts().FirstOrDefault(product => product.ProductId == int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString()));
            }
            else return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.orderDetails.Count() != 0)
            {
                DialogResult dialog = MessageBox.Show("Your cart is not empty, are you sure to quit now?", "Cancel", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var currentProduct = GetCurrentProduct();
            var isExistOrderDetail = orderDetails.FirstOrDefault(x => x.ProductId == currentProduct.ProductId);
            if (txtAmount.Text == "")
            {
                MessageBox.Show("You should enter the amount");
            }
            else if (int.Parse(txtAmount.Text) > currentProduct.UnitsInStock
                || (isExistOrderDetail != null && int.Parse(txtAmount.Text) > currentProduct.UnitsInStock - isExistOrderDetail.Quantity))
            {
                MessageBox.Show("Not enough supplying amount");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure to buy " + txtAmount.Text + " " + currentProduct.ProductName + "(s)?", "Cancel", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (isExistOrderDetail == null)
                    {
                        orderDetails.Add(new OrderDetail
                        {
                            ProductId = currentProduct.ProductId,
                            UnitPrice = currentProduct.UnitPrice,
                            Quantity = int.Parse(txtAmount.Text),
                            Discount = 0
                        });
                    }
                    else
                    {
                        isExistOrderDetail.Quantity += int.Parse(txtAmount.Text);
                    }
                    
                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCart frmCart = new frmCart
            {
                orderDetails = this.orderDetails,
                MemberId = this.MemberId
            };
            DialogResult dialog = frmCart.ShowDialog();
            if (dialog == DialogResult.Cancel)
            {
                frmCart.Hide();
            }
            else if (dialog == DialogResult.OK)
            {
                frmCart.Hide();
                this.orderDetails = new List<OrderDetail>();
                ClearText();
            }
            productService = new();
            LoadProducts();
        }
    }
}
