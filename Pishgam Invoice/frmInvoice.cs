using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pishgam_Invoice
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void dgvNewInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvNewInvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void dgvNewInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
