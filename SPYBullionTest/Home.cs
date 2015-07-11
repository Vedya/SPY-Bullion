using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPYBullionTest
{
    public partial class FrmHome : Form
    {
        //public FrmHome()
        //{
        //    InitializeComponent();
        //}

        private void directSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void supplierRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SuplierReg secondForm = new Frm_SuplierReg();
            secondForm.ShowDialog();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CustReg secondForm = new Frm_CustReg();
            secondForm.ShowDialog();

        }

        private void purchaseEntrieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PurchaseOrder secondForm = new Frm_PurchaseOrder();
            secondForm.ShowDialog();
        }

        private void stockEntrieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_StockEntry secondForm = new Frm_StockEntry();
            secondForm.ShowDialog();
        }

        private void itemDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
