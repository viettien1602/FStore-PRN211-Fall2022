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
    public partial class frmProductManagement : Form
    {
        private ProductService productService = new();
        private BindingSource source;

        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string search = null)
        {
            var products = productService.GetProducts();
            if (search != null)
            {
                products = products.FindAll(p => p.ProductName.ToUpper().Contains(search.ToUpper().Trim()));
            }

            source = new BindingSource();
            source.DataSource = products;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = source;
            dgvProducts.Columns[6].Visible = false;

            if (products.Count() == 0)
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private Product GetCurrentProduct()
        {
            return productService.GetProducts()
                    .FirstOrDefault(a => a.ProductId == int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts
            {
                UpdateOrAdd = false
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                frm.Hide();
                productService = new();
                LoadProducts();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts
            {
                UpdateOrAdd = true,
                Product = GetCurrentProduct()
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                productService = new();
                frm.Hide();
                LoadProducts();
                source.Position = source.Count - 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do your want to delete this product?", "Cancel", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Product product = GetCurrentProduct();
                product.UnitsInStock = 0;
                productService.Update(product);
                productService = new();
                LoadProducts();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
