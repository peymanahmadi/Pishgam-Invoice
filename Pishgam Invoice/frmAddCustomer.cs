using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pishgam_Invoice
{
    public partial class frmAddCustomer : Form
    {

        SqlConnection con = new SqlConnection("Server = .; Database = Invoice; Integrated Security = True");

        public frmAddCustomer()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("Select_All_Customers", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
        }
    }
}
