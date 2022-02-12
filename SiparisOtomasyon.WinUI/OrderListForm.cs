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
    using DAL.Context;
    using Helper;
    using DAL.VM;

    public partial class OrderListForm : Form
    {
        IOrderBusiness orderBusiness;

        public OrderListForm()
        {
            InitializeComponent();
            orderBusiness = new OrderBusiness();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            FillMapping();
            FillData();
        }

        private void FillMapping()
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CustomerName", "CustomerName", "Müşteri Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("PersonalName", "PersonalName", "Personel Adı"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("OrderDate", "OrderDate", "Sipariş Tarih"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("CargoName", "CargoName", "Kargo Firması"));
            grid.Columns.Add(UICoreUtility.generateDataGridViewTextBoxColumn("ShipName", "ShipName", "Alıcı"));
        }
        private void FillData()
        {
            grid.DataSource = null;
            grid.DataSource = orderBusiness.GetOrderVM();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = (grid.DataSource as List<OrderVM>)[e.RowIndex];

            var form = new OrderForm();
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Tag = order.OrderId;
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillData();
        }
    }
}
