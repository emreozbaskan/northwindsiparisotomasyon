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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void newCustomerMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMidiForm(new CustomerForm());
        }

        private void customerListMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMidiForm(new CustomerListForm());
        }

        public void ShowMidiForm(Form form)
        {
            checkOpenForms();

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void checkOpenForms()
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].MdiParent != null)
                {
                    Application.OpenForms[i].Close();
                    i--;
                }
            }
        }

        private void newProductMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMidiForm(new ProductForm());
        }

        private void productListMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowMidiForm(new ProductListForm());
        }
    }
}
