namespace JewelleryShopManagementApp
{
    partial class Customer
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustPhoneNo = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerContactNo = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustLogout = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dataGvCustomer = new System.Windows.Forms.DataGridView();
            this.jewelMgmtDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jewelMgmtDBDataSet = new JewelleryShopManagementApp.JewelMgmtDBDataSet();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Yellow;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1406, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 39);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Location = new System.Drawing.Point(643, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 38);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "JEWELLERY SHOP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCustId);
            this.panel1.Controls.Add(this.txtCustName);
            this.panel1.Controls.Add(this.txtCustPhoneNo);
            this.panel1.Controls.Add(this.lblCustomerId);
            this.panel1.Controls.Add(this.lblCustomerName);
            this.panel1.Controls.Add(this.lblCustomerContactNo);
            this.panel1.Controls.Add(this.lblCustomerDetails);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 771);
            this.panel1.TabIndex = 11;
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(29, 275);
            this.txtCustId.Multiline = true;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(228, 35);
            this.txtCustId.TabIndex = 23;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(29, 402);
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(228, 38);
            this.txtCustName.TabIndex = 22;
            // 
            // txtCustPhoneNo
            // 
            this.txtCustPhoneNo.Location = new System.Drawing.Point(29, 540);
            this.txtCustPhoneNo.Multiline = true;
            this.txtCustPhoneNo.Name = "txtCustPhoneNo";
            this.txtCustPhoneNo.Size = new System.Drawing.Size(228, 34);
            this.txtCustPhoneNo.TabIndex = 21;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.Color.Black;
            this.lblCustomerId.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerId.Location = new System.Drawing.Point(34, 219);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(172, 38);
            this.lblCustomerId.TabIndex = 20;
            this.lblCustomerId.Text = "Customer Id";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Black;
            this.lblCustomerName.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerName.Location = new System.Drawing.Point(34, 347);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(223, 38);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerContactNo
            // 
            this.lblCustomerContactNo.AutoSize = true;
            this.lblCustomerContactNo.BackColor = System.Drawing.Color.Black;
            this.lblCustomerContactNo.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNo.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerContactNo.Location = new System.Drawing.Point(34, 486);
            this.lblCustomerContactNo.Name = "lblCustomerContactNo";
            this.lblCustomerContactNo.Size = new System.Drawing.Size(97, 38);
            this.lblCustomerContactNo.TabIndex = 18;
            this.lblCustomerContactNo.Text = "Phone";
            this.lblCustomerContactNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.BackColor = System.Drawing.Color.Black;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCustomerDetails.Location = new System.Drawing.Point(34, 24);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(139, 38);
            this.lblCustomerDetails.TabIndex = 17;
            this.lblCustomerDetails.Text = "Customer";
            this.lblCustomerDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCustLogout);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Controls.Add(this.lblCustomer);
            this.panel2.Location = new System.Drawing.Point(272, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 83);
            this.panel2.TabIndex = 12;
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
            // 
            // dataGvCustomer
            // 
            this.dataGvCustomer.AllowUserToOrderColumns = true;
            this.dataGvCustomer.AutoGenerateColumns = false;
            this.dataGvCustomer.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvCustomer.DataSource = this.jewelMgmtDBDataSetBindingSource;
            this.dataGvCustomer.EnableHeadersVisualStyles = false;
            this.dataGvCustomer.Location = new System.Drawing.Point(335, 219);
            this.dataGvCustomer.Name = "dataGvCustomer";
            this.dataGvCustomer.RowHeadersWidth = 51;
            this.dataGvCustomer.RowTemplate.Height = 24;
            this.dataGvCustomer.Size = new System.Drawing.Size(926, 355);
            this.dataGvCustomer.TabIndex = 13;
            this.dataGvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGvCustomer_DoubleClick);
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
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.Yellow;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(335, 638);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(127, 39);
            this.btnAddCust.TabIndex = 14;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(566, 638);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(811, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1060, 638);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 39);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1439, 773);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.dataGvCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jewelMgmtDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustLogout;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerContactNo;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustPhoneNo;
        private System.Windows.Forms.DataGridView dataGvCustomer;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.BindingSource jewelMgmtDBDataSetBindingSource;
        private JewelMgmtDBDataSet jewelMgmtDBDataSet;
    }
}