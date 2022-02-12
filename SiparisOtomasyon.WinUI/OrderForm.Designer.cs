
namespace SiparisOtomasyon.WinUI
{
    partial class OrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClouse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridOrderDetail = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nuFreight = new System.Windows.Forms.NumericUpDown();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOrderDetailDelete = new System.Windows.Forms.Button();
            this.btnOrderDetailAdd = new System.Windows.Forms.Button();
            this.nuDiscount = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.nuUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFreight)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Form";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnClouse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 49);
            this.panel3.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(174, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(93, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(12, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 29);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Yeni";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClouse
            // 
            this.btnClouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClouse.Location = new System.Drawing.Point(878, 8);
            this.btnClouse.Name = "btnClouse";
            this.btnClouse.Size = new System.Drawing.Size(75, 29);
            this.btnClouse.TabIndex = 1;
            this.btnClouse.Text = "Kapat";
            this.btnClouse.UseVisualStyleBackColor = true;
            this.btnClouse.Click += new System.EventHandler(this.btnClouse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.gridOrderDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 262);
            this.panel2.TabIndex = 4;
            // 
            // gridOrderDetail
            // 
            this.gridOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.gridOrderDetail.Name = "gridOrderDetail";
            this.gridOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrderDetail.Size = new System.Drawing.Size(965, 262);
            this.gridOrderDetail.TabIndex = 0;
            this.gridOrderDetail.DataSourceChanged += new System.EventHandler(this.gridOrderDetail_DataSourceChanged);
            this.gridOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOrderDetail_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.nuFreight);
            this.panel4.Controls.Add(this.cmbShipVia);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.dtShippedDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dtRequiredDate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtOrderDate);
            this.panel4.Controls.Add(this.cmbEmployee);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cmbCustomer);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(965, 292);
            this.panel4.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtShipPostalCode);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtShipRegion);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtShipCountry);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtShipCity);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtShipAddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(19, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teslim Bilgileri";
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(94, 60);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(80, 25);
            this.txtShipPostalCode.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "Posta Kod";
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.Location = new System.Drawing.Point(228, 60);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(189, 25);
            this.txtShipRegion.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Bölge";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(557, 29);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(145, 25);
            this.txtShipCountry.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ülke";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(557, 60);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(145, 25);
            this.txtShipCity.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Şehir";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(94, 90);
            this.txtShipAddress.Multiline = true;
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(785, 51);
            this.txtShipAddress.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Adres";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(94, 29);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(323, 25);
            this.txtShipName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Alıcı";
            // 
            // nuFreight
            // 
            this.nuFreight.DecimalPlaces = 2;
            this.nuFreight.Location = new System.Drawing.Point(557, 46);
            this.nuFreight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nuFreight.Name = "nuFreight";
            this.nuFreight.Size = new System.Drawing.Size(119, 25);
            this.nuFreight.TabIndex = 11;
            this.nuFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(130, 77);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(323, 25);
            this.cmbShipVia.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kargo Firması";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Taşıma Ücreti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teslim Tarih";
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(787, 46);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(111, 25);
            this.dtShippedDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Termin Tarih";
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(787, 15);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(111, 25);
            this.dtRequiredDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sipariş Tarih";
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(557, 15);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(119, 25);
            this.dtOrderDate.TabIndex = 3;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(130, 46);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(323, 25);
            this.cmbEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Personel";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(130, 15);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(323, 25);
            this.cmbCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnOrderDetailDelete);
            this.panel5.Controls.Add(this.btnOrderDetailAdd);
            this.panel5.Controls.Add(this.nuDiscount);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.nuQuantity);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.nuUnitPrice);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.cmbProduct);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(965, 31);
            this.panel5.TabIndex = 6;
            // 
            // btnOrderDetailDelete
            // 
            this.btnOrderDetailDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetailDelete.Location = new System.Drawing.Point(899, 1);
            this.btnOrderDetailDelete.Name = "btnOrderDetailDelete";
            this.btnOrderDetailDelete.Size = new System.Drawing.Size(54, 28);
            this.btnOrderDetailDelete.TabIndex = 18;
            this.btnOrderDetailDelete.Text = "Sil";
            this.btnOrderDetailDelete.UseVisualStyleBackColor = true;
            this.btnOrderDetailDelete.Click += new System.EventHandler(this.btnOrderDetailDelete_Click);
            // 
            // btnOrderDetailAdd
            // 
            this.btnOrderDetailAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDetailAdd.Location = new System.Drawing.Point(19, 1);
            this.btnOrderDetailAdd.Name = "btnOrderDetailAdd";
            this.btnOrderDetailAdd.Size = new System.Drawing.Size(54, 28);
            this.btnOrderDetailAdd.TabIndex = 17;
            this.btnOrderDetailAdd.Text = "Ekle";
            this.btnOrderDetailAdd.UseVisualStyleBackColor = true;
            this.btnOrderDetailAdd.Click += new System.EventHandler(this.btnOrderDetailAdd_Click);
            // 
            // nuDiscount
            // 
            this.nuDiscount.DecimalPlaces = 2;
            this.nuDiscount.Location = new System.Drawing.Point(804, 3);
            this.nuDiscount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nuDiscount.Name = "nuDiscount";
            this.nuDiscount.Size = new System.Drawing.Size(78, 25);
            this.nuDiscount.TabIndex = 16;
            this.nuDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(746, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "İndirim";
            // 
            // nuQuantity
            // 
            this.nuQuantity.Location = new System.Drawing.Point(662, 3);
            this.nuQuantity.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(78, 25);
            this.nuQuantity.TabIndex = 14;
            this.nuQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(609, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Miktar";
            // 
            // nuUnitPrice
            // 
            this.nuUnitPrice.DecimalPlaces = 2;
            this.nuUnitPrice.Location = new System.Drawing.Point(499, 3);
            this.nuUnitPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nuUnitPrice.Name = "nuUnitPrice";
            this.nuUnitPrice.Size = new System.Drawing.Size(104, 25);
            this.nuUnitPrice.TabIndex = 12;
            this.nuUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Birim Fiyat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(86, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Ürün";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(130, 3);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(285, 25);
            this.cmbProduct.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblToplam);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(965, 32);
            this.panel6.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.ForeColor = System.Drawing.Color.Red;
            this.lblToplam.Location = new System.Drawing.Point(660, 6);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(104, 17);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "Toplam : 0.00 TL";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 660);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrderDetail)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFreight)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUnitPrice)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridOrderDetail;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtShippedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtRequiredDate;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuFreight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nuUnitPrice;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nuDiscount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnOrderDetailDelete;
        private System.Windows.Forms.Button btnOrderDetailAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblToplam;
    }
}