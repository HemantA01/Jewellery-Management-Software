namespace JewelleryShopManagementApp
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnUpdateProd = new System.Windows.Forms.Button();
            this.jewelMgmtDBDataSet = new JewelleryShopManagementApp.JewelMgmtDBDataSet();
            this.jewelMgmtDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProdCategory = new System.Windows.Forms.ComboBox();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtProdQty = new System.Windows.Forms.TextBox();
            this.lblProdQty = new System.Windows.Forms.Label();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.lblTitleProd = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustLogout = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dataGvProduct = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProd.Location = new System.Drawing.Point(769, 634);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(127, 39);
            this.btnDeleteProd.TabIndex = 25;
            this.btnDeleteProd.Text = "Delete";
            this.btnDeleteProd.UseVisualStyleBackColor = false;
            this.btnDeleteProd.Click += new System.EventHandler(this.btnDeleteProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(293, 634);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(127, 39);
            this.btnAddProd.TabIndex = 23;
            this.btnAddProd.Text = "Add";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnUpdateProd
            // 
            this.btnUpdateProd.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProd.Location = new System.Drawing.Point(524, 634);
            this.btnUpdateProd.Name = "btnUpdateProd";
            this.btnUpdateProd.Size = new System.Drawing.Size(127, 39);
            this.btnUpdateProd.TabIndex = 24;
            this.btnUpdateProd.Text = "Update";
            this.btnUpdateProd.UseVisualStyleBackColor = false;
            this.btnUpdateProd.Click += new System.EventHandler(this.btnUpdateProd_Click);
            // 
            // jewelMgmtDBDataSet
            // 
            this.jewelMgmtDBDataSet.DataSetName = "JewelMgmtDBDataSet";
            this.jewelMgmtDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jewelMgmtDBDataSetBindingSource
            // 
            this.jewelMgmtDBDataSetBindingSource.DataSource = this.jewelMgmtDBDataSet;
            this.jewelMgmtDBDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbProdCategory);
            this.panel1.Controls.Add(this.cmbProdName);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.lblUnitPrice);
            this.panel1.Controls.Add(this.txtProdQty);
            this.panel1.Controls.Add(this.lblProdQty);
            this.panel1.Controls.Add(this.txtProdId);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.lblProductCategory);
            this.panel1.Controls.Add(this.lblProductDetails);
            this.panel1.Location = new System.Drawing.Point(-42, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 771);
            this.panel1.TabIndex = 20;
            // 
            // cmbProdCategory
            // 
            this.cmbProdCategory.FormattingEnabled = true;
            this.cmbProdCategory.Items.AddRange(new object[] {
            "Wedding and Brial Jewellery",
            "Pearl Jewellery",
            "Fashon Jewellery",
            "Men\'s Jewellery",
            "Vintage Jewellery",
            "Ethinc and Cultural Jewellery"});
            this.cmbProdCategory.Location = new System.Drawing.Point(61, 445);
            this.cmbProdCategory.Name = "cmbProdCategory";
            this.cmbProdCategory.Size = new System.Drawing.Size(221, 24);
            this.cmbProdCategory.TabIndex = 29;
            // 
            // cmbProdName
            // 
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Items.AddRange(new object[] {
            "Diamond Engagement Ring",
            "Pearl Necklace",
            "Men\'s Golden Bracelet",
            "Golden Jewellery Set",
            "Vintage Brooch",
            "Ethnic Beaded Necklace"});
            this.cmbProdName.Location = new System.Drawing.Point(61, 338);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(221, 24);
            this.cmbProdName.TabIndex = 28;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(54, 643);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(228, 22);
            this.txtUnitPrice.TabIndex = 27;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblUnitPrice.Location = new System.Drawing.Point(54, 602);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(139, 38);
            this.lblUnitPrice.TabIndex = 26;
            this.lblUnitPrice.Text = "Unit Price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProdQty
            // 
            this.txtProdQty.Location = new System.Drawing.Point(54, 547);
            this.txtProdQty.Multiline = true;
            this.txtProdQty.Name = "txtProdQty";
            this.txtProdQty.Size = new System.Drawing.Size(228, 27);
            this.txtProdQty.TabIndex = 25;
            // 
            // lblProdQty
            // 
            this.lblProdQty.AutoSize = true;
            this.lblProdQty.BackColor = System.Drawing.Color.Black;
            this.lblProdQty.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdQty.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProdQty.Location = new System.Drawing.Point(54, 506);
            this.lblProdQty.Name = "lblProdQty";
            this.lblProdQty.Size = new System.Drawing.Size(233, 38);
            this.lblProdQty.TabIndex = 24;
            this.lblProdQty.Text = "Product Quantity";
            this.lblProdQty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProdId
            // 
            this.txtProdId.Location = new System.Drawing.Point(61, 240);
            this.txtProdId.Multiline = true;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(228, 25);
            this.txtProdId.TabIndex = 23;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.Color.Black;
            this.lblProductId.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProductId.Location = new System.Drawing.Point(54, 189);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(149, 38);
            this.lblProductId.TabIndex = 20;
            this.lblProductId.Text = "Product Id";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Black;
            this.lblProductName.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProductName.Location = new System.Drawing.Point(54, 296);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(200, 38);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.BackColor = System.Drawing.Color.Black;
            this.lblProductCategory.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProductCategory.Location = new System.Drawing.Point(54, 404);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(239, 38);
            this.lblProductCategory.TabIndex = 18;
            this.lblProductCategory.Text = "Product Category";
            this.lblProductCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.BackColor = System.Drawing.Color.Black;
            this.lblProductDetails.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblProductDetails.Location = new System.Drawing.Point(54, 24);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(116, 38);
            this.lblProductDetails.TabIndex = 17;
            this.lblProductDetails.Text = "Product";
            this.lblProductDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitleProd
            // 
            this.lblTitleProd.AutoSize = true;
            this.lblTitleProd.BackColor = System.Drawing.Color.Black;
            this.lblTitleProd.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProd.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitleProd.Location = new System.Drawing.Point(601, 9);
            this.lblTitleProd.Name = "lblTitleProd";
            this.lblTitleProd.Size = new System.Drawing.Size(242, 38);
            this.lblTitleProd.TabIndex = 18;
            this.lblTitleProd.Text = "JEWELLERY SHOP";
            this.lblTitleProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Yellow;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1364, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 39);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCustLogout);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Location = new System.Drawing.Point(258, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 83);
            this.panel2.TabIndex = 21;
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
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Black;
            this.lblBill.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblBill.Location = new System.Drawing.Point(642, 27);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(55, 38);
            this.lblBill.TabIndex = 15;
            this.lblBill.Text = "Bill";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
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
            // dataGvProduct
            // 
            this.dataGvProduct.AllowUserToOrderColumns = true;
            this.dataGvProduct.AutoGenerateColumns = false;
            this.dataGvProduct.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvProduct.DataSource = this.jewelMgmtDBDataSetBindingSource;
            this.dataGvProduct.EnableHeadersVisualStyles = false;
            this.dataGvProduct.Location = new System.Drawing.Point(293, 215);
            this.dataGvProduct.Name = "dataGvProduct";
            this.dataGvProduct.RowHeadersWidth = 51;
            this.dataGvProduct.RowTemplate.Height = 24;
            this.dataGvProduct.Size = new System.Drawing.Size(926, 355);
            this.dataGvProduct.TabIndex = 22;
            this.dataGvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGvProduct_DoubleClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1018, 634);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 39);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = " Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1408, 689);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdateProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.dataGvProduct);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitleProd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnUpdateProd;
        private JewelMgmtDBDataSet jewelMgmtDBDataSet;
        private System.Windows.Forms.BindingSource jewelMgmtDBDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProdCategory;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtProdQty;
        private System.Windows.Forms.Label lblProdQty;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Label lblTitleProd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustLogout;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dataGvProduct;
        private System.Windows.Forms.Button btnReset;
    }
}