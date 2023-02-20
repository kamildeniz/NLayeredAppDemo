namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryId2 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.cbxCategoryId2 = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 135);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(775, 220);
            this.dgwProduct.TabIndex = 0;
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(13, 13);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(774, 54);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProduct);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(13, 73);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(775, 56);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürüne Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(17, 23);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(17, 26);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(30, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(108, 19);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(150, 20);
            this.tbxProduct.TabIndex = 1;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(108, 20);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(150, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId2);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId2);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(13, 376);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(774, 100);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "yeni ürün";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // lblCategoryId2
            // 
            this.lblCategoryId2.AutoSize = true;
            this.lblCategoryId2.Location = new System.Drawing.Point(20, 42);
            this.lblCategoryId2.Name = "lblCategoryId2";
            this.lblCategoryId2.Size = new System.Drawing.Size(63, 13);
            this.lblCategoryId2.TabIndex = 0;
            this.lblCategoryId2.Text = "Kategori No";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 66);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(245, 20);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 2;
            this.lblQuantityPerUnit.Text = "Stok Adedi";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(247, 42);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(57, 13);
            this.lblUnitsInStock.TabIndex = 3;
            this.lblUnitsInStock.Text = "Birm Adedi";
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(108, 17);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(121, 20);
            this.tbxProductName2.TabIndex = 4;
            // 
            // cbxCategoryId2
            // 
            this.cbxCategoryId2.FormattingEnabled = true;
            this.cbxCategoryId2.Location = new System.Drawing.Point(108, 42);
            this.cbxCategoryId2.Name = "cbxCategoryId2";
            this.cbxCategoryId2.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoryId2.TabIndex = 5;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(108, 66);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(329, 17);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(123, 20);
            this.tbxQuantityPerUnit.TabIndex = 7;
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(329, 43);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(123, 20);
            this.tbxUnitsInStock.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblCategoryId2;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryId2;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Button btnAdd;
    }
}

