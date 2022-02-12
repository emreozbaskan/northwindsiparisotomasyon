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
    using DAL.Context;
    using BL.Concrete;
    using Helper;
    using DAL.VM;

    public partial class OrderForm : Form
    {
        ICustomerBusiness customerBusiness;
        IEmployeeBusiness employeeBusiness;
        IShipperBusiness shipperBusiness;
        IProductBusiness productBusiness;
        IOrderBusiness orderBusiness;
        IOrderDetailBusiness orderDetailBusiness;

        public OrderForm()
        {
            InitializeComponent();
            customerBusiness = new CustomerBusiness();
            employeeBusiness = new EmployeeBusiness();
            shipperBusiness = new ShipperBusiness();
            productBusiness = new ProductBusiness();
            orderBusiness = new OrderBusiness();
            orderDetailBusiness = new OrderDetailBusiness();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillOrderDetailGridMapping();
            FillDataOrder();
        }

        private void FillOrderDetailGridMapping()
        {
            gridOrderDetail.AutoGenerateColumns = false;
            gridOrderDetail.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ProductName", "ProductName", "Ürün Adı"));
            gridOrderDetail.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("UnitPrice", "UnitPrice", "Birim Fiyatı"));
            gridOrderDetail.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Quantity", "Quantity", "Adet"));
            gridOrderDetail.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Discount", "Discount", "İndirim"));
            gridOrderDetail.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("Total", "Total", "Satır Toplam"));
            gridOrderDetail.Columns["Total"].DefaultCellStyle.Format = "N2"; //Currency ayarlaması
        }
        Order selectedOrder = null;
        private void FillDataOrder()
        {
            int id = Convert.ToInt32(this.Tag);
            if (id > 0)
            {
                var order = orderBusiness.GetById(id);
                if (order != null)
                {
                    selectedOrder = order;

                    cmbCustomer.SetSelectedValue(order.CustomerID);
                    cmbEmployee.SetSelectedValue(order.EmployeeID);
                    cmbShipVia.SetSelectedValue(order.ShipVia);
                    dtOrderDate.Value = Convert.ToDateTime(order.OrderDate);
                    dtRequiredDate.Value = Convert.ToDateTime(order.RequiredDate);
                    dtShippedDate.Value = Convert.ToDateTime(order.ShippedDate);
                    nuFreight.Value = Convert.ToDecimal(order.Freight);
                    txtShipName.Text = order.ShipName;
                    txtShipCity.Text = order.ShipCity;
                    txtShipCountry.Text = order.ShipCountry;
                    txtShipAddress.Text = order.ShipAddress;
                    txtShipPostalCode.Text = order.ShipPostalCode;
                    txtShipRegion.Text = order.ShipRegion;

                    FillDataOrderDetail(id);
                }

            }
        }
        //Siparis Detayını doldurmak için kullanılacak
        private void FillDataOrderDetail(int id)
        {
            if (id > 0)
            {
                var orderDetails = orderDetailBusiness.GetOrderDetailVM(id);
                gridOrderDetail.DataSource = null;
                gridOrderDetail.DataSource = orderDetails;
            }
        }
        private void FillControl()
        {
            FillCustomer();
            FillPersonal();
            FillShipper();
            FillProduct();
        }
        private void FillCustomer()
        {
            cmbCustomer.DataSource = customerBusiness.Get();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
        }
        public void FillPersonal()
        {
            var employess = employeeBusiness.Get();
            cmbEmployee.SetDataSourceFirstItems<int, Employee>(employess, "FirstName", "EmployeeID", "Seçiniz");
        }
        public void FillShipper()
        {
            var shippers = shipperBusiness.Get();
            cmbShipVia.SetDataSourceFirstItems<int, Shipper>(shippers, "CompanyName", "ShipperID", "Seçiniz");
        }
        public void FillProduct()
        {
            var products = productBusiness.Get();
            cmbProduct.SetDataSourceFirstItems<int, Product>(products, "ProductName", "ProductID", "Seçiniz");
        }

        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            try
            {
                if (this.selectedOrder == null)
                {
                    selectedOrder = new Order();
                }

                selectedOrder.CustomerID = cmbCustomer.SelectedValue?.ToString();
                selectedOrder.EmployeeID = cmbEmployee.GetValue<int, Employee>();
                selectedOrder.ShipVia = cmbShipVia.GetValue<int, Shipper>();
                selectedOrder.OrderDate = dtOrderDate.Value;
                selectedOrder.RequiredDate = dtRequiredDate.Value;
                selectedOrder.ShippedDate = dtShippedDate.Value;
                selectedOrder.Freight = nuFreight.Value;
                selectedOrder.ShipName = txtShipName.Text;
                selectedOrder.ShipAddress = txtShipAddress.Text;
                selectedOrder.ShipCity = txtShipCity.Text;
                selectedOrder.ShipCountry = txtShipCountry.Text;
                selectedOrder.ShipPostalCode = txtShipPostalCode.Text;
                selectedOrder.ShipRegion = txtShipRegion.Text;

                if (Convert.ToInt32(this.Tag) > 0)
                {
                    orderBusiness.Update(this.selectedOrder);
                }
                else
                {
                    orderBusiness.Add(this.selectedOrder);
                    this.Tag = selectedOrder.OrderID;
                }

                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti");
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            UICoreUtility.FormClear(this);
            this.selectedOrder = null;
            this.selectedOrderDetail = null;
            this.Tag = 0;
            gridOrderDetail.DataSource = null;
        }


        //Order Detail Add
        Order_Detail selectedOrderDetail;
        private void btnOrderDetailAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAdded = false;

                if (this.selectedOrder == null)
                {
                    UICoreUtility.ErrorMessage("Lütfen önce sipariş kayıt yapın sonrasında detay satırları girişini yapınız");
                    return;
                }

                if (cmbProduct.SelectedValue == null)
                {
                    UICoreUtility.ErrorMessage("Lütfen bir ürün seçimi yapınız");
                    cmbProduct.Focus();
                    return;
                }

                if (nuUnitPrice.Value == 0)
                {
                    UICoreUtility.ErrorMessage("Lütfen birim fiyat girişi yapınız");
                    nuUnitPrice.Focus();
                    return;
                }

                if (nuQuantity.Value == 0)
                {
                    UICoreUtility.ErrorMessage("Lütfen Miktar girişi yapınız");
                    nuQuantity.Focus();
                    return;
                }

                if (selectedOrderDetail == null)
                {
                    selectedOrderDetail = new Order_Detail();
                    isAdded = true;
                }


                selectedOrderDetail.OrderID = selectedOrder.OrderID;
                if (isAdded)
                    selectedOrderDetail.ProductID = cmbProduct.GetValue<int, Product>().Value;
                selectedOrderDetail.UnitPrice = nuUnitPrice.Value;
                selectedOrderDetail.Quantity = Convert.ToInt16(nuQuantity.Value);
                selectedOrderDetail.Discount = Convert.ToSingle(nuDiscount.Value);

                if (isAdded)
                {
                    orderDetailBusiness.Add(selectedOrderDetail);
                }
                else
                {
                    orderDetailBusiness.Update(selectedOrderDetail);
                }

                FormOrderDetailClear();
                FillDataOrderDetail(selectedOrder.OrderID);
                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti");
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        private void gridOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderDetailItem = (gridOrderDetail.DataSource as List<OrderDetailVM>)[e.RowIndex];
            if (orderDetailItem != null)
            {
                //selectedOrderDetail = orderDetailItem;
                cmbProduct.SelectedValue = orderDetailItem.ProductID;
                nuUnitPrice.Value = orderDetailItem.UnitPrice;
                nuQuantity.Value = orderDetailItem.Quantity;
                nuDiscount.Value = Convert.ToDecimal(orderDetailItem.Discount);
                selectedOrderDetail = new Order_Detail()
                {
                    OrderID = orderDetailItem.OrderID,
                    Discount = orderDetailItem.Discount,
                    ProductID = orderDetailItem.ProductID,
                    Quantity = orderDetailItem.Quantity,
                    UnitPrice = orderDetailItem.UnitPrice
                };
            }
        }

        private void FormOrderDetailClear()
        {
            selectedOrderDetail = null;
            UICoreUtility.FormClear(panel5);
        }

        private void btnOrderDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridOrderDetail.SelectedRows.Count > 0)
                {
                    var dialogResult = UICoreUtility.DialogMessage("Seçilen kayıtları silmek istiyor musunuz?");
                    if (dialogResult == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in gridOrderDetail.SelectedRows)
                        {
                            var item = (row.DataBoundItem as OrderDetailVM);
                            orderDetailBusiness.Delete(item.OrderID, item.ProductID);
                        }
                        UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde gerçekleşti");
                        FillDataOrderDetail(this.selectedOrder.OrderID);
                    }
                }
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            try
            {
                int id = Convert.ToInt32(this.Tag);
                if (id > 0)
                {
                    var dialog = UICoreUtility.DialogMessage("Kaydı silmek istediğinizden emin misiniz?.");
                    if (dialog == DialogResult.OK)
                    {
                        orderDetailBusiness.Delete(id);
                        orderBusiness.Delete(id);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }


        private void TotalUpdate()
        {

            var orderDetails = (gridOrderDetail.DataSource as List<OrderDetailVM>);
            if (orderDetails != null)
                lblToplam.Text = $"Toplam Tutar = {orderDetails.Sum(t0 => t0.Total).ToString("N2")}";
        }

        private void gridOrderDetail_DataSourceChanged(object sender, EventArgs e)
        {
            TotalUpdate();
        }
    }
}
