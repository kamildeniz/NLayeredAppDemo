﻿using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
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
            _productManager = new ProductManager(new EfProductDal());
        }
        IProductService _productManager;
        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProduct.DataSource = _productManager.GetAll();
        }
    }
}
