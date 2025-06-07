using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagementApp
{
    public partial class PrintBill : Form
    {
        public Bill _bill;
        public DataGridView _dataGrid;
        public PrintBill(DataGridView dgv)
        {
            InitializeComponent();
            _dataGrid = dgv;

        }


        private void PrintBill_Load(object sender, EventArgs e)
        {
            DisplayBillReport();
            btnPrint.Visible = true;
        }
        public void DisplayBillReport()
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            if (_dataGrid.Rows.Count > 0)
            {
                var billnumber = ""; var customername = ""; var customercontact = ""; var prodname = ""; var unitprice = ""; var prodqty = "";
                var totprice = "";
                if (_dataGrid.SelectedRows.Count > 0)
                {
                    billnumber = _dataGrid.SelectedRows[0].Cells[1].Value?.ToString();
                    lblPrintBillNo.Text = billnumber;
                    customername = _dataGrid.SelectedRows[0].Cells[4].Value?.ToString();
                    lblCustName.Text = customername;
                    customercontact = _dataGrid.SelectedRows[0].Cells[5].Value?.ToString();
                    lblCustomerContect.Text = customercontact;
                    prodname = _dataGrid.SelectedRows[0].Cells[2].Value?.ToString();
                    lblBillProdName.Text = prodname;
                    unitprice = _dataGrid.SelectedRows[0].Cells[7].Value?.ToString();
                    lblbillProdUnitPrice.Text = unitprice;
                    prodqty = _dataGrid.SelectedRows[0].Cells[6].Value?.ToString();
                    lblBillProdQty.Text = prodqty;
                    totprice = _dataGrid.SelectedRows[0].Cells[8].Value?.ToString();
                    lblBillTotAmt.Text = totprice;
                    lblAmountPayable.Text = totprice;
                }
                else
                {
                    //var selectedbillno = _dataGrid.SelectedRows[0].Cells[1].Value as string;
                    billnumber = _dataGrid.Rows[0].Cells[1].Value?.ToString();
                    lblPrintBillNo.Text = billnumber;
                    customername = _dataGrid.Rows[0].Cells[4].Value?.ToString();
                    lblCustName.Text = customername;
                    customercontact = _dataGrid.Rows[0].Cells[5].Value?.ToString();
                    lblCustomerContect.Text = customercontact;
                    prodname = _dataGrid.Rows[0].Cells[2].Value?.ToString();
                    lblBillProdName.Text = prodname;
                    unitprice = _dataGrid.Rows[0].Cells[7].Value?.ToString();
                    lblbillProdUnitPrice.Text = unitprice;
                    prodqty = _dataGrid.Rows[0].Cells[6].Value?.ToString();
                    lblBillProdQty.Text = prodqty;
                    totprice = _dataGrid.Rows[0].Cells[8].Value?.ToString();
                    lblBillTotAmt.Text = totprice;
                    lblAmountPayable.Text = totprice;
                }
            }
        }
        Bitmap BitMapToPrint;
        private void CaptureFormShot()
        {
            BitMapToPrint = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(BitMapToPrint, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void lblJewellersHeader_Click(object sender, EventArgs e)
        {

        }
        private void printTaxInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rect = e.PageBounds;
            e.Graphics.DrawImage(BitMapToPrint, rect);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureFormShot();
            btnPrint.Visible = false;
            printPreviewDialog1.ShowDialog();
        }


    }
}
