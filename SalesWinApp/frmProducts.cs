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
    public partial class frmProducts : Form
    {
        public ProductService productService = new();
        public bool UpdateOrAdd { get; set; } //false => addnew
        public Product Product { get; set; }
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            strings.Add("1 - Fruit");
            strings.Add("2 - Food");
            strings.Add("3 - Vegetable");
            cbCategoryId.Items.AddRange(strings.ToArray());
            cbCategoryId.SelectedIndex = 0;
            if (UpdateOrAdd)
            {
                switch (Product.CategoryId)
                {
                    case 1:
                        cbCategoryId.Text = "1 - Fruit";
                        break;
                    case 2:
                        cbCategoryId.Text = "2 - Food";
                        break;
                    case 3:
                        cbCategoryId.Text = "3 - Vegetable";
                        break;
                }
                txtProductName.Text = Product.ProductName;
                txtWeight.Text = Product.Weight;
                txtUnitPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateOrAdd)
            {
                switch (cbCategoryId.Text)
                {
                    case "1 - Fruit":
                        Product.CategoryId = 1;
                        break;
                    case "2 - Food":
                        Product.CategoryId = 2;
                        break;
                    case "3 - Vegetable":
                        Product.CategoryId = 3;
                        break;
                }
                Product.ProductName = txtProductName.Text;
                Product.Weight = txtWeight.Text;
                Product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                Product.UnitsInStock = int.Parse(txtUnitsInStock.Text);
                productService.Update(Product);
            }
            else
            {
                Product product = new Product();
                switch (cbCategoryId.Text)
                {
                    case "1 - Fruit":
                        product.CategoryId = 1;
                        break;
                    case "2 - Food":
                        product.CategoryId = 2;
                        break;
                    case "3 - Vegetable":
                        product.CategoryId = 3;
                        break;
                }
                product.ProductName = txtProductName.Text;
                product.Weight = txtWeight.Text;
                product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                product.UnitsInStock = int.Parse(txtUnitsInStock.Text);
                productService.Create(product);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
