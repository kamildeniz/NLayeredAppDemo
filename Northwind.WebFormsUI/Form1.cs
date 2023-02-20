using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        IProductService _productService;
        ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId2.DataSource = _categoryService.GetAll();
            cbxCategoryId2.DisplayMember = "CategoryName";
            cbxCategoryId2.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch { }
        }

        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProduct.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProduct.Text);

            }
            else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxProductName2.Text,
                CategoryId=Convert.ToInt32(cbxCategoryId2.SelectedValue),
                QuantityPerUnit=tbxQuantityPerUnit.Text,
                UnitPrice =Convert.ToInt32(tbxUnitPrice.Text),
                UnitsInStock=Convert.ToInt16(tbxUnitsInStock.Text)
            });
            MessageBox.Show("Kaydedildi!");
            LoadProducts();
        }
    }
}
