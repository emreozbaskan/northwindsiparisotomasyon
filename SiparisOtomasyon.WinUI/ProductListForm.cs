using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyon.WinUI
{
    using BL.Abstract;
    using BL.Concrete;
    using Helper;
    using DAL.VM;
    public partial class ProductListForm : Form
    {
        IProductBusiness productBusiness;

        public ProductListForm()
        {
            InitializeComponent();

            productBusiness = new ProductBusiness();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            FillMapping();
            FillGrid();

        }

        private void FillMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ProductName", "ProductName", "Ürün Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CategoryName", "CategoryName", "Kategori Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("SupplierName", "SupplierName", "Tedarikci Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("UnitPrice", "UnitPrice", "Birim Fiyat"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("UnitsInStock", "UnitsInStock", "Mevcut Stok"));
        }

        private void FillGrid()
        {
            grid.DataSource = null;
            var result = productBusiness.GetProductsVM();
            grid.DataSource = result;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = (grid.DataSource as List<ProductVM>)[e.RowIndex];
            if (product != null)
            {
                var form = new ProductForm();
                form.MdiParent = this.MdiParent;
                form.Dock = DockStyle.Fill;
                form.Tag = product.ProductId;
                form.FormClosing += Form_FormClosing;
                form.Show();
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillGrid();
        }
    }
}
