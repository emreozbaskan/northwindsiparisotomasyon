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
    using BL.Abstract;
    using BL.Concrete;
    using Helper;

    public partial class CustomerForm : Form
    {
        ICustomerBusiness customerBusiness;
        public CustomerForm()
        {
            InitializeComponent();

            customerBusiness = new CustomerBusiness();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        Customer selectedCustomer = null;
        private void FillData()
        {
            string id = this.Tag?.ToString();
            if (!string.IsNullOrWhiteSpace(id))
            {
                this.selectedCustomer = customerBusiness.GetById(id);
                if (this.selectedCustomer != null)
                {
                    txtCompanyName.Text = this.selectedCustomer.CompanyName;
                    txtContactName.Text = this.selectedCustomer.ContactName;
                    txtContactTitle.Text = this.selectedCustomer.ContactTitle;
                    txtPostaCode.Text = this.selectedCustomer.PostalCode;
                    txtPhone.Text = this.selectedCustomer.Phone;
                    txtFax.Text = this.selectedCustomer.Fax;
                    txtCountry.Text = this.selectedCustomer.Country;
                    txtCity.Text = this.selectedCustomer.City;
                    txtRegion.Text = this.selectedCustomer.Region;
                    txtAddress.Text = this.selectedCustomer.Address;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            this.Tag = null;
            this.selectedCustomer = null;
            UICoreUtility.FormClear(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            try
            {
                if (this.selectedCustomer == null)
                {
                    this.selectedCustomer = new Customer();
                    this.selectedCustomer.CustomerID = GenerateCustomerCode(5);
                }

                this.selectedCustomer.CompanyName = txtCompanyName.Text;
                this.selectedCustomer.ContactTitle = txtContactTitle.Text;
                this.selectedCustomer.ContactName = txtContactName.Text;
                this.selectedCustomer.PostalCode = txtPostaCode.Text;
                this.selectedCustomer.Phone = txtPhone.Text;
                this.selectedCustomer.Fax = txtFax.Text;
                this.selectedCustomer.Country = txtCountry.Text;
                this.selectedCustomer.City = txtCity.Text;
                this.selectedCustomer.Region = txtRegion.Text;
                this.selectedCustomer.Address = txtAddress.Text;

                string id = this.Tag?.ToString();
                if (!string.IsNullOrWhiteSpace(id))
                {
                    customerBusiness.Update(this.selectedCustomer);
                }
                else
                {
                    customerBusiness.Add(this.selectedCustomer);
                    this.Tag = this.selectedCustomer.CustomerID;
                }

                UICoreUtility.SuccessMessage("İşlem başarılı bir şekilde yapıldı");

            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        static Random rnd = new Random();
        private string GenerateCustomerCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(t0 => t0[rnd.Next(t0.Length)]).ToArray());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            try
            {
                if (UICoreUtility.DialogMessage("Bu kaydı silmek istiyor musunuz?") == DialogResult.OK)
                {
                    if (customerBusiness.Delete(this.selectedCustomer.CustomerID))
                    {
                        UICoreUtility.SuccessMessage("Silme işlemi başarılı");
                        this.Close();
                    }
                    else
                    {
                        UICoreUtility.ErrorMessage("Silme işlemi sırasında hata meydana geldi");
                    }
                }
            }
            catch (Exception ex)
            {
                UICoreUtility.ErrorMessage(ex.Message);
            }
        }

        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
