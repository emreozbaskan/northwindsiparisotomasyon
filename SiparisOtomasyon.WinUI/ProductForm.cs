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
    using DAL.Context;
    using Helper;
    using BL.Abstract;
    using BL.Concrete;


    public partial class ProductForm : Form
    {
        ICategoryBusiness categoryBusiness;
        ISupplierBusiness supplierBusiness;
        IProductBusiness productBusiness;

        public ProductForm()
        {
            InitializeComponent();

            categoryBusiness = new CategoryBusiness();
            supplierBusiness = new SupplierBusiness();
            productBusiness = new ProductBusiness();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillData();
        }

        private void FillData()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id > 0)
            {
                var product = productBusiness.GetById(id);
                if (product != null)
                {
                    this.selectedProduct = product;
                    txtProductName.Text = product.ProductName;
                    txtQuantityPerUnit.Text = product.QuantityPerUnit;
                    cmbCategory.SetSelectedValue(product.CategoryID);
                    cmbSupplier.SetSelectedValue(product.SupplierID);
                    chkIsDiscountinued.Checked = product.Discontinued;
                    nuReorderLevel.Value = Convert.ToDecimal(product.ReorderLevel);
                    nuUnitPrice.Value = Convert.ToDecimal(product.UnitPrice);
                    nuUnitsOnOrder.Value = Convert.ToDecimal(product.UnitsOnOrder);
                    nuUnitInStock.Value = Convert.ToDecimal(product.UnitsInStock);
                }
            }
        }

        private void FillControl()
        {
            FillCategory();
            FillSupplier();
        }

        private void FillSupplier()
        {
            var dataSource = supplierBusiness.Get();
            cmbSupplier.SetDataSourceFirstItems<int, Supplier>(dataSource, "CompanyName", "SupplierID", "Seçiniz");
        }

        private void FillCategory()
        {
            var categories = categoryBusiness.Get();
            cmbCategory.SetDataSourceFirstItems<int, Category>(categories, "CategoryName", "CategoryID", "Seçiniz");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        Product selectedProduct;
        private void FormClear()
        {
            this.Tag = null;
            this.selectedProduct = null;
            UICoreUtility.FormClear(this);
        }

        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
