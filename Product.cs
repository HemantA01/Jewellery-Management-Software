using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagementApp
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            DisplayProduct();
        }
        public readonly SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["JewelleryShopManagementApp.Properties.Settings.JewelMgmtDBConStr"].ToString());

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
                    txtProdId.Text = "1";
                    txtProdId.Enabled = false;
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
            txtProdId.Text = " ";
            txtProdQty.Text = " ";
            txtUnitPrice.Text = " ";
            //cmbProdCategory.SelectedIndex = 0;
            cmbProdCategory.Text = " ";
            //cmbProdName.SelectedIndex = 0;
            cmbProdName.Text = " ";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdId.Text == "" || txtProdId.Text == " " || txtProdQty.Text == "" || txtProdQty.Text == " " || txtUnitPrice.Text == "" || txtUnitPrice.Text == " " || cmbProdCategory.Text == "" || cmbProdCategory.Text == " " || cmbProdName.Text == "" || cmbProdName.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string inlineQuery = "insert into tblProduct(ProdName,ProdCategory,ProdQty,ProdUnitPrice,IsActive,CreatedBy,CreatedOn) values('" + cmbProdName.Text + "','" + cmbProdCategory.Text + "',"+Convert.ToInt32(txtProdQty.Text)+ ","+Convert.ToDouble(txtUnitPrice.Text)+",1,99,GETDATE())";
                    SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record inserted successfully.");
                    ClearData();
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
        public void ClearData()
        {
            txtProdId.Text = " ";
            txtProdQty.Text = " ";
            txtUnitPrice.Text = " ";
            cmbProdCategory.Text = " ";
            cmbProdName.Text = " ";
        }

        private void dataGvProduct_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdId.Text = dataGvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProdQty.Text = dataGvProduct.SelectedRows[0].Cells[3].Value.ToString();
            txtUnitPrice.Text = dataGvProduct.SelectedRows[0].Cells[4].Value.ToString();
            cmbProdCategory.Text = dataGvProduct.SelectedRows[0].Cells[2].Value.ToString();
            cmbProdName.Text = dataGvProduct.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProdId.Text == "" || txtProdId.Text == " " || txtProdQty.Text == "" || txtProdQty.Text == " " || txtUnitPrice.Text == "" || txtUnitPrice.Text == " " || cmbProdCategory.Text == "" || cmbProdCategory.Text == " " || cmbProdName.Text == "" || cmbProdName.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else 
                {
                    conn.Open();
                    string query = "select * from tblProduct(nolock) where ProdId=" + Convert.ToInt32(txtProdId.Text) + " and IsActive=1";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        string inlineQuery = "update tblProduct set ProdName = @PName, ProdCategory=@Pcategory, ProdQty=@PQty, ProdUnitPrice=@PUnitPrice,ModifiedOn=getdate(), ModifiedBy=@ModifiedBy where ProdId=@PId";
                        SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                        cmd.Parameters.AddWithValue("@PName", cmbProdName.Text);
                        cmd.Parameters.AddWithValue("@Pcategory", cmbProdCategory.Text);
                        cmd.Parameters.AddWithValue("@PQty", Convert.ToInt32(txtProdQty.Text));
                        cmd.Parameters.AddWithValue("@PUnitPrice",Convert.ToDouble(txtUnitPrice.Text));
                        cmd.Parameters.AddWithValue("@ModifiedBy", 19);
                        cmd.Parameters.AddWithValue("@PId", Convert.ToInt32(txtProdId.Text));
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

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            try
            {
                string prodId = dataGvProduct.SelectedRows[0].Cells[0].Value.ToString();
                //if (txtCustId.Text == "" || txtCustId.Text == " " || custId == null)
                if (prodId == null)
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string inlineQuery = "update tblProduct set IsActive=@IsActive where ProdId=@PId";
                    SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                    //cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(txtCustId.Text));
                    cmd.Parameters.AddWithValue("@PId", Convert.ToInt32(prodId));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record deleted successfully.");
                    ClearData();
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

        private void Product_Load(object sender, EventArgs e)
        {
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

        private void lblBill_Click(object sender, EventArgs e)
        {
            Bill obj = new Bill();
            obj.Show();
            this.Hide();
        }

        private void lblCustLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
