using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagementApp
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            DisplayCustomer();
        }
        public readonly SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["JewelleryShopManagementApp.Properties.Settings.JewelMgmtDBConStr"].ToString());
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayCustomer()
        {
            try
            {
                conn.Open();
                string query = "select CustId, CustName, CustPhone, case IsActive when 1 then 'Active' else 'Inactive' end as IsActive from tblCustomer(nolock)";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGvCustomer.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    dataGvCustomer.DataSource = null;
                    conn.Close();
                    txtCustId.Text = "1";
                    txtCustId.Enabled = false;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustId.Text = " ";
            txtCustName.Text = " ";
            txtCustPhoneNo.Text = " ";
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustId.Text == "" || txtCustId.Text == " " || txtCustName.Text == "" || txtCustName.Text == " " || txtCustPhoneNo.Text == "" || txtCustPhoneNo.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string inlineQuery = "insert into tblCustomer(CustName,CustPhone,IsActive,CreatedBy,CreatedoN) values('" + txtCustName.Text + "','" + txtCustPhoneNo.Text + "',1,99,GETDATE())";
                    SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record inserted successfully.");
                    ClearData();
                    DisplayCustomer();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustId.Text == "" || txtCustId.Text == " " || txtCustName.Text == "" || txtCustName.Text == " " || txtCustPhoneNo.Text == "" || txtCustPhoneNo.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    /* string query = "select * from tblCustomer(nolock) where CustId=@CId and IsActive=@IsActive";
                     SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                     DataTable dt = new DataTable();
                     sda.Fill(dt);*/
                    string query = "select * from tblCustomer(nolock) where CustId=" + Convert.ToInt32(txtCustId.Text) + " and IsActive=1";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        string inlineQuery = "update tblCustomer set CustName = @CName, CustPhone=@CPhone,UpdatedOn=getdate(), UpdatedBy=@UpdatedBy where CustId=@CId";
                        SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                        cmd.Parameters.AddWithValue("@CName", txtCustName.Text);
                        cmd.Parameters.AddWithValue("@CPhone", txtCustPhoneNo.Text);
                        cmd.Parameters.AddWithValue("@UpdatedBy", 19);
                        cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(txtCustId.Text));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record updated successfully.");
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed as Customer is either inactive or not exists");
                    }
                    
                    DisplayCustomer();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = dataGvCustomer.SelectedRows[0].Cells[0].Value.ToString();
                //if (txtCustId.Text == "" || txtCustId.Text == " " || custId == null)
                if (custId == null)
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    conn.Open();
                    string inlineQuery = "update tblCustomer set IsActive=@IsActive where CustId=@CId";
                    SqlCommand cmd = new SqlCommand(inlineQuery, conn);
                    cmd.Parameters.AddWithValue("@IsActive", 0);
                    //cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(txtCustId.Text));
                    cmd.Parameters.AddWithValue("@CId", Convert.ToInt32(custId));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record deleted successfully.");
                    ClearData();
                    DisplayCustomer();
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

        public void Customer_Load(object sender, EventArgs e)
        {
            dataGvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGvCustomer.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGvCustomer.BackgroundColor = Color.Black;
            dataGvCustomer.ForeColor = Color.White;
            dataGvCustomer.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGvCustomer.RowsDefaultCellStyle.SelectionBackColor = Color.Goldenrod;
            dataGvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGvCustomer.AutoGenerateColumns = true;
        }

        public void dataGvCustomer_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustId.Text = dataGvCustomer.SelectedRows[0].Cells[0].Value.ToString();
            txtCustName.Text = dataGvCustomer.SelectedRows[0].Cells[1].Value.ToString();
            txtCustPhoneNo.Text = dataGvCustomer.SelectedRows[0].Cells[2].Value.ToString();
        }

        public void ClearData()
        {
            txtCustId.Text = " ";
            txtCustName.Text = " ";
            txtCustPhoneNo.Text = " ";
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            Product obj = new Product();
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
