namespace JewelleryShopManagementApp
{
    partial class Bill
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jewelMgmtDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewelMgmtDBDataSet = new JewelleryShopManagementApp.JewelMgmtDBDataSet();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            this.lblCustLogout = new System.Windows.Forms.Label();
            this.dataGvBill = new System.Windows.Forms.DataGridView();
            this.cmbCustId = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBillDetails = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTitleProd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtProduct1 = new System.Windows.Forms.TextBox();
            this.lblProduct1 = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillgrdDisplay = new System.Windows.Forms.Label();
            this.dataGvProduct = new System.Windows.Forms.DataGridView();
            this.lblProdGrdDisplay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // jewelMgmtDBDataSetBindingSource
            // 
            this.jewelMgmtDBDataSetBindingSource.DataSource = this.jewelMgmtDBDataSet;
            this.jewelMgmtDBDataSetBindingSource.Position = 0;
            // 
            // jewelMgmtDBDataSet
            // 
            this.jewelMgmtDBDataSet.DataSetName = "JewelMgmtDBDataSet";
            this.jewelMgmtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(464, 641);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 39);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.Yellow;
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Location = new System.Drawing.Point(310, 641);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(127, 39);
            this.btnAddBill.TabIndex = 32;
            this.btnAddBill.Text = "Add";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Black;
            this.lblCustomer.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomer.Location = new System.Drawing.Point(21, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(139, 38);
            this.lblCustomer.TabIndex = 13;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.BackColor = System.Drawing.Color.Black;
            this.lblBillId.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBillId.Location = new System.Drawing.Point(64, 165);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(88, 38);
            this.lblBillId.TabIndex = 20;
            this.lblBillId.Text = "Bill Id";
            this.lblBillId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustLogout
            // 
            this.lblCustLogout.AutoSize = true;
            this.lblCustLogout.BackColor = System.Drawing.Color.Black;
            this.lblCustLogout.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustLogout.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustLogout.Location = new System.Drawing.Point(921, 27);
            this.lblCustLogout.Name = "lblCustLogout";
            this.lblCustLogout.Size = new System.Drawing.Size(108, 38);
            this.lblCustLogout.TabIndex = 16;
            this.lblCustLogout.Text = "Logout";
            this.lblCustLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCustLogout.Click += new System.EventHandler(this.lblCustLogout_Click);
            // 
            // dataGvBill
            // 
            this.dataGvBill.AllowUserToOrderColumns = true;
            this.dataGvBill.AutoGenerateColumns = false;
            this.dataGvBill.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvBill.DataSource = this.jewelMgmtDBDataSetBindingSource;
            this.dataGvBill.EnableHeadersVisualStyles = false;
            this.dataGvBill.Location = new System.Drawing.Point(310, 251);
            this.dataGvBill.Name = "dataGvBill";
            this.dataGvBill.RowHeadersWidth = 51;
            this.dataGvBill.RowTemplate.Height = 24;
            this.dataGvBill.Size = new System.Drawing.Size(550, 326);
            this.dataGvBill.TabIndex = 31;
            this.dataGvBill.DoubleClick += new System.EventHandler(this.dataGvBill_DoubleClick);
            // 
            // cmbCustId
            // 
            this.cmbCustId.FormattingEnabled = true;
            this.cmbCustId.Location = new System.Drawing.Point(54, 344);
            this.cmbCustId.Name = "cmbCustId";
            this.cmbCustId.Size = new System.Drawing.Size(221, 24);
            this.cmbCustId.TabIndex = 28;
            this.cmbCustId.SelectionChangeCommitted += new System.EventHandler(this.cmbCustId_SelectionChangeCommitted);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTotalPrice.Location = new System.Drawing.Point(54, 577);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(147, 38);
            this.lblTotalPrice.TabIndex = 26;
            this.lblTotalPrice.Text = "Total Price";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(61, 206);
            this.txtBillId.Multiline = true;
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(228, 25);
            this.txtBillId.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Yellow;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1388, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 39);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Black;
            this.lblCustomerId.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerId.Location = new System.Drawing.Point(54, 303);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(172, 38);
            this.lblCustomerId.TabIndex = 19;
            this.lblCustomerId.Text = "Customer Id";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Black;
            this.lblCustomerName.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerName.Location = new System.Drawing.Point(52, 371);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(223, 38);
            this.lblCustomerName.TabIndex = 18;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Black;
            this.lblProduct.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProduct.Location = new System.Drawing.Point(338, 27);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(116, 38);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // lblBillDetails
            // 
            this.lblBillDetails.AutoSize = true;
            this.lblBillDetails.BackColor = System.Drawing.Color.Black;
            this.lblBillDetails.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDetails.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBillDetails.Location = new System.Drawing.Point(54, 24);
            this.lblBillDetails.Name = "lblBillDetails";
            this.lblBillDetails.Size = new System.Drawing.Size(55, 38);
            this.lblBillDetails.TabIndex = 17;
            this.lblBillDetails.Text = "Bill";
            this.lblBillDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Black;
            this.lblBill.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBill.Location = new System.Drawing.Point(686, 27);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(55, 38);
            this.lblBill.TabIndex = 15;
            this.lblBill.Text = "Bill";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(54, 618);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(228, 22);
            this.txtTotalPrice.TabIndex = 27;
            // 
            // lblTitleProd
            // 
            this.lblTitleProd.AutoSize = true;
            this.lblTitleProd.BackColor = System.Drawing.Color.Black;
            this.lblTitleProd.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitleProd.Location = new System.Drawing.Point(625, 16);
            this.lblTitleProd.Name = "lblTitleProd";
            this.lblTitleProd.Size = new System.Drawing.Size(242, 38);
            this.lblTitleProd.TabIndex = 27;
            this.lblTitleProd.Text = "JEWELLERY SHOP";
            this.lblTitleProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.txtCustName);
            this.panel1.Controls.Add(this.txtProduct1);
            this.panel1.Controls.Add(this.lblProduct1);
            this.panel1.Controls.Add(this.cmbCustId);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.txtProdQty);
            this.panel1.Controls.Add(this.lblProdQty);
            this.panel1.Controls.Add(this.txtBillId);
            this.panel1.Controls.Add(this.lblBillId);
            this.panel1.Controls.Add(this.lblCustomerId);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblBillDetails);
            this.panel1.Location = new System.Drawing.Point(-18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 771);
            this.panel1.TabIndex = 29;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(52, 552);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(228, 22);
            this.txtUnitPrice.TabIndex = 34;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUnitPrice.Location = new System.Drawing.Point(54, 511);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(139, 38);
            this.lblUnitPrice.TabIndex = 33;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(49, 412);
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(228, 25);
            this.txtCustName.TabIndex = 32;
            // 
            // txtProduct1
            // 
            this.txtProduct1.Location = new System.Drawing.Point(56, 275);
            this.txtProduct1.Multiline = true;
            this.txtProduct1.Name = "txtProduct1";
            this.txtProduct1.Size = new System.Drawing.Size(228, 25);
            this.txtProduct1.TabIndex = 31;
            // 
            // lblProduct1
            // 
            this.lblProduct1.AutoSize = true;
            this.lblProduct1.BackColor = System.Drawing.Color.Black;
            this.lblProduct1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct1.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProduct1.Location = new System.Drawing.Point(64, 234);
            this.lblProduct1.Name = "lblProduct1";
            this.lblProduct1.Size = new System.Drawing.Size(116, 38);
            this.lblProduct1.TabIndex = 30;
            this.lblProduct1.Text = "Product";
            this.lblProduct1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProdQty
            // 
            this.txtProdQty.Location = new System.Drawing.Point(49, 481);
            this.txtProdQty.Multiline = true;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(221, 27);
            this.txtProdQty.TabIndex = 25;
            this.txtProdQty.TextChanged += new System.EventHandler(this.txtProdQty_TextChanged);
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.BackColor = System.Drawing.Color.Black;
            this.lblProdQty.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdQty.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProdQty.Location = new System.Drawing.Point(47, 440);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(233, 38);
            this.lblProdQty.TabIndex = 24;
            this.lblProdQty.Text = "Product Quantity";
            this.lblProdQty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCustLogout);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Location = new System.Drawing.Point(282, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 83);
            this.panel2.TabIndex = 30;
            // 
            // lblBillgrdDisplay
            // 
            this.lblBillgrdDisplay.AutoSize = true;
            this.lblBillgrdDisplay.BackColor = System.Drawing.Color.Black;
            this.lblBillgrdDisplay.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillgrdDisplay.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBillgrdDisplay.Location = new System.Drawing.Point(488, 209);
            this.lblBillgrdDisplay.Name = "lblBillgrdDisplay";
            this.lblBillgrdDisplay.Size = new System.Drawing.Size(55, 38);
            this.lblBillgrdDisplay.TabIndex = 17;
            this.lblBillgrdDisplay.Text = "Bill";
            this.lblBillgrdDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGvProduct
            // 
            this.dataGvProduct.AllowUserToOrderColumns = true;
            this.dataGvProduct.AutoGenerateColumns = false;
            this.dataGvProduct.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvProduct.DataSource = this.jewelMgmtDBDataSetBindingSource;
            this.dataGvProduct.EnableHeadersVisualStyles = false;
            this.dataGvProduct.Location = new System.Drawing.Point(880, 251);
            this.dataGvProduct.Name = "dataGvProduct";
            this.dataGvProduct.RowHeadersWidth = 51;
            this.dataGvProduct.RowTemplate.Height = 24;
            this.dataGvProduct.Size = new System.Drawing.Size(579, 326);
            this.dataGvProduct.TabIndex = 36;
            this.dataGvProduct.DoubleClick += new System.EventHandler(this.dataGvProduct_DoubleClick);
            // 
            // lblProdGrdDisplay
            // 
            this.lblProdGrdDisplay.AutoSize = true;
            this.lblProdGrdDisplay.BackColor = System.Drawing.Color.Black;
            this.lblProdGrdDisplay.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdGrdDisplay.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProdGrdDisplay.Location = new System.Drawing.Point(1188, 210);
            this.lblProdGrdDisplay.Name = "lblProdGrdDisplay";
            this.lblProdGrdDisplay.Size = new System.Drawing.Size(116, 38);
            this.lblProdGrdDisplay.TabIndex = 37;
            this.lblProdGrdDisplay.Text = "Product";
            this.lblProdGrdDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(780, 641);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 39);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(627, 641);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1471, 692);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblProdGrdDisplay);
            this.Controls.Add(this.dataGvProduct);
            this.Controls.Add(this.lblBillgrdDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.dataGvBill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitleProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jewelMgmtDBDataSetBindingSource;
        private JewelMgmtDBDataSet jewelMgmtDBDataSet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.Label lblCustLogout;
        private System.Windows.Forms.DataGridView dataGvBill;
        private System.Windows.Forms.ComboBox cmbCustId;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBillDetails;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTitleProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProduct1;
        private System.Windows.Forms.Label lblProduct1;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblBillgrdDisplay;
        private System.Windows.Forms.DataGridView dataGvProduct;
        private System.Windows.Forms.Label lblProdGrdDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}