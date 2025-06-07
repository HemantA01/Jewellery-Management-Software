using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagementApp
{
    public partial class Bill : Form
    {
        public static DataGridView sharedDataGridView;
        public Bill()
        {
            InitializeComponent();
            DisplayBill();
            GetCustId();
            DisplayProduct();
            sharedDataGridView = dataGvBill;
        }
        public readonly SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["JewelleryShopManagementApp.Properties.Settings.JewelMgmtDBConStr"].ToString());

        
        private void DisplayBill()
        {
            try
            {
                conn.Open();
                string query = "select b.Id, b.BillId, b.Product, b.CustomerId, b.CustomerName,c.CustPhone as CustomerContact,  b.ProductQty, b.UnitPrice, b.TotalPrice, case b.IsActive when 1 then 'Active' else 'Inactive' end as IsActive from tblBill(nolock) b" +
                    " inner join tblCustomer c(nolock) on b.CustomerId=c.CustId";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGvBill.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    dataGvBill.DataSource = null;
                    conn.Close();
                    txtBillId.Text = "1";
                    txtBillId.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void DisplayProduct()
        {
            try
            {
                conn.Open();
                string query = "select ProdId, ProdName, ProdCategory, ProdQty, ProdUnitPrice, case IsActive when 1 then 'Active' else 'Inactive' end as IsActive from tblProduct(nolock)";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGvProduct.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    dataGvProduct.DataSource = null;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetCustId()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select CustId from tblCustomer(nolock)", conn);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CustId", typeof(int));
                dt.Load(rdr);
                cmbCustId.ValueMember = "CustId";
                cmbCustId.DataSource = dt;
                conn.Close() ;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        string custName;
        void DisplayCustomerName()
        {
            try 
            {
                conn.Open();
                string str = "select CustName from tblCustomer(nolock) where CustId=" + Convert.ToInt32(cmbCustId.SelectedValue.ToString()) + " and IsActive=1";
                SqlCommand cmd = new SqlCommand(str, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    custName = dr["CustName"].ToString();
                    txtCustName.Text = custName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBillId.Text = " ";
            txtProduct1.Text = " ";
            cmbCustId.Text = " ";
            txtCustName.Text = " ";
            txtProdQty.Text = " ";
            txtUnitPrice.Text = " ";
            txtTotalPrice.Text = " ";
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            DisplayCustomerName();
            dataGvBill.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGvBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGvBill.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGvBill.BackgroundColor = Color.Black;
            dataGvBill.ForeColor = Color.White;
            dataGvBill.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGvBill.RowsDefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            dataGvBill.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGvBill.AutoGenerateColumns = true;

            dataGvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGvProduct.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGvProduct.BackgroundColor = Color.Black;
            dataGvProduct.ForeColor = Color.White;
            dataGvProduct.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGvProduct.RowsDefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            dataGvProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGvProduct.AutoGenerateColumns = true;
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
            obj.Show();
            this.Hide();
        }
        int flag = 0, stock;
        private void dataGvProduct_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtProduct1.Text = dataGvProduct.SelectedRows[0].Cells[1].Value.ToString();
                txtUnitPrice.Text = dataGvProduct.SelectedRows[0].Cells[4].Value.ToString();
                stock = Convert.ToInt32(dataGvProduct.SelectedRows[0].Cells[3].Value.ToString());
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        double sum = 0;
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBillId.Text == "" || txtBillId.Text == " " || txtProdQty.Text == "" || txtProdQty.Text == " " || txtTotalPrice.Text == "" || txtTotalPrice.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else if (Convert.ToInt32(txtProdQty.Text) > stock || Convert.ToInt32(txtProdQty.Text) == 0)
                {
                    MessageBox.Show("Stock not available");
                }
                else 
                {
                    conn.Open();
                    string cnt = "SELECT count(*)+1 FROM tblBill(nolock)";
                    SqlCommand cmd = new SqlCommand(cnt, conn);
                    string BillNo = cmd.ExecuteScalar().ToString();
                    double totalPrice = Convert.ToInt32(txtProdQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
                    sum = sum + totalPrice;
                    txtTotalPrice.Text = totalPrice.ToString();
                    //string query = "insert into tblBill(BillId,Product,CustomerId,CustomerName,ProductQty,TotalPrice,IsActive,CreatedBy," +
                    //    "CreatedOn) values ('KRJS/BL/" + BillNo + "','" + txtProduct1.Text + "'," + Convert.ToInt32(cmbCustId.Text) + "," +
                    //    "'" + txtCustName.Text + "'," + Convert.ToInt32(txtProdQty.Text) + "," + Convert.ToDouble(txtTotalPrice.Text) + ",1,99,GETDATE())";
                    string query = "insert into tblBill(BillId,Product,CustomerId,CustomerName,ProductQty,UnitPrice,TotalPrice,IsActive,CreatedBy,CreatedOn)" +
                        "values(@BillNo,@ProdName,@CustId,@CustName,@ProdQty,@UnitPrice,@TotalPrice,@IsActive,@CreatedBy,@CreatedDate)";
                    SqlCommand cmd1 = new SqlCommand(query, conn);
                    cmd1.Parameters.AddWithValue("@BillNo", "KRJS/BL/" + BillNo + "");
                    cmd1.Parameters.AddWithValue("@ProdName", txtProduct1.Text);
                    cmd1.Parameters.AddWithValue("@CustId", Convert.ToInt32(cmbCustId.Text));
                    cmd1.Parameters.AddWithValue("@CustName", txtCustName.Text);
                    cmd1.Parameters.AddWithValue("@ProdQty", Convert.ToInt32(txtProdQty.Text));
                    cmd1.Parameters.AddWithValue("@UnitPrice", Convert.ToDouble(txtUnitPrice.Text));
                    cmd1.Parameters.AddWithValue("@TotalPrice", Convert.ToDouble(txtTotalPrice.Text));
                    cmd1.Parameters.AddWithValue("@IsActive", true);
                    cmd1.Parameters.AddWithValue("@CreatedBy", 99);
                    cmd1.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record inserted successfully");
                    DisplayBill();
                    UpdateProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtProdQty_TextChanged(object sender, EventArgs e)
        {
            if(txtProdQty.Text== " " || txtProdQty.Text == "" || txtProdQty.Text == "0" || txtUnitPrice.Text == " " || txtUnitPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(int.TryParse(txtProdQty.Text, out int val))
            {
                double tiotalPrice = Convert.ToInt32(txtProdQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
                txtTotalPrice.Text = tiotalPrice.ToString();
                txtTotalPrice.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please input a valid quantity");
            }
        }

        private void lblCustLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string billId = dataGvBill.SelectedRows[0].Cells[0].Value.ToString();
                //if (txtCustId.Text == "" || txtCustId.Text == " " || custId == null)
                if (billId == null)
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string inlineQuery = "update tblBill set IsActive=@IsActive where Id=@BId";
                    SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                    //cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(txtCustId.Text));
                    cmd.Parameters.AddWithValue("@BId", Convert.ToInt32(billId));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record deleted successfully.");
                    ClearData();
                    DisplayBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void ClearData()
        {
            txtBillId.Text = " ";
            txtProduct1.Text = " ";
            cmbCustId.Text = " ";
            txtCustName.Text = " ";
            txtProdQty.Text = " ";
            txtUnitPrice.Text = " ";
            txtTotalPrice.Text = " ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtBillId.Text == "" || txtBillId.Text == " " || txtProdQty.Text == "" || txtProdQty.Text == " " || txtTotalPrice.Text == "" || txtTotalPrice.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else if (Convert.ToInt32(txtProdQty.Text) > stock || Convert.ToInt32(txtProdQty.Text) == 0)
                {
                    MessageBox.Show("Stock not available");
                }
                else
                {
                    conn.Open();
                    string query = "select * from tblBill(nolock) where Id=" + Convert.ToInt32(txtBillId.Text) + " and IsActive=1";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        double totalPrice = Convert.ToInt32(txtProdQty.Text) * Convert.ToDouble(txtUnitPrice.Text);
                        string inlineQuery = "update tblBill set Product = @PName,CustomerId=@CId,CustomerName=@CName, ProductQty=@PQty,UnitPrice=@PUnitPrice ,TotalPrice=@PTotalPrice,ModifiedOn=getdate(), ModifiedBy=@ModifiedBy where Id=@BId";
                        SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                        cmd.Parameters.AddWithValue("@PName", txtProduct1.Text);
                        cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(cmbCustId.Text));
                        cmd.Parameters.AddWithValue("@CName", txtCustName.Text);
                        cmd.Parameters.AddWithValue("@PQty", Convert.ToInt32(txtProdQty.Text));
                        cmd.Parameters.AddWithValue("@PUnitPrice", Convert.ToDouble(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@PTotalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@ModifiedBy", 19);
                        cmd.Parameters.AddWithValue("@BId", Convert.ToInt32(txtBillId.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record updated successfully.");
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed as Product is either inactive or out of stock");
                    }
                    DisplayProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGvBill_DoubleClick(object sender, EventArgs e)
        {
            txtBillId.Text = dataGvBill.SelectedRows[0].Cells[0].Value.ToString();
            txtProduct1.Text = dataGvBill.SelectedRows[0].Cells[2].Value.ToString();
            cmbCustId.Text = dataGvBill.SelectedRows[0].Cells[3].Value.ToString();
            txtCustName.Text = dataGvBill.SelectedRows[0].Cells[4].Value.ToString();
            txtProdQty.Text = dataGvBill.SelectedRows[0].Cells[5].Value.ToString();
            txtUnitPrice.Text = dataGvBill.SelectedRows[0].Cells[6].Value.ToString();
            txtTotalPrice.Text = dataGvBill.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void cmbCustId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplayCustomerName();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintBill pb1 = new PrintBill(dataGvBill);
            
            pb1.Show();
        }

        void UpdateProduct()
        {
            try 
            { 
                string id = dataGvProduct.SelectedRows[0].Cells[0].Value.ToString();
                int qty = stock - Convert.ToInt32(txtProdQty.Text);
                if (qty < 0)
                {
                    MessageBox.Show("Operation failed");
                }
                else {
                    conn.Open();
                    string query = "update tblproduct set ProdQty = " + qty + " where ProdId=" + Convert.ToInt32(id) + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    DisplayProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
