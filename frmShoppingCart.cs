using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameLibrary_RDR_2353FA21
{
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.clearCart();
                ProgOps.OpenDatabaseTheGameLibrary();
                ProgOps.DatabaseCommandTheGameLibraryShoppingCart(dgvShoppingCart, lblSubtotalValue, lblTaxAmountValue, lblNetTotalValue);
                lblSubtotalValue.Text = "";
                lblTaxAmountValue.Text = "";
                lblNetTotalValue.Text = "";
            }
            catch 
            {
                lblSubtotalValue.Text = "";
                lblTaxAmountValue.Text = "";
                lblNetTotalValue.Text = "";
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try {     
            int selectedRowVar = dgvShoppingCart.CurrentCell.RowIndex;
            string titleVar = dgvShoppingCart.Rows[selectedRowVar].Cells[0].Value.ToString();
            ProgOps.removeFromCart(titleVar);
            ProgOps.OpenDatabaseTheGameLibrary();
                lblSubtotalValue.Text = "";
                lblTaxAmountValue.Text = "";
                lblNetTotalValue.Text = "";
                ProgOps.DatabaseCommandTheGameLibraryShoppingCart(dgvShoppingCart, lblSubtotalValue, lblTaxAmountValue, lblNetTotalValue);
            }
            catch 
            {
                lblSubtotalValue.Text = "";
                lblTaxAmountValue.Text = "";
                lblNetTotalValue.Text = "";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            /*
             Check Out Button: Should print out a detailed receipt using crystal
             reports. It should include the customer’s name,
             order number and pricing details listed above
             */
            //create an object of the Report
            CrystalReports.crptOrderReceipt orderReceiptVar = new CrystalReports.crptOrderReceipt();
            //set the database logon for the report
            orderReceiptVar.SetDatabaseLogon("rrichardsonfa212353", "1600361");
            
            
            //create an object of the frmViewer so we can use crvViewer
            frmViewer viewer = new frmViewer();
            //set to null first to clear the crvViewer
            viewer.crvViewer.ReportSource = null;
            //Then set the crvViewer to the report object
            viewer.crvViewer.ReportSource = orderReceiptVar;
            //then show the form with the crvViewer on it
            viewer.Show();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabaseTheGameLibrary();
            ProgOps.DatabaseCommandTheGameLibraryShoppingCart(dgvShoppingCart, lblSubtotalValue, lblTaxAmountValue, lblNetTotalValue);
        }









    }
}
