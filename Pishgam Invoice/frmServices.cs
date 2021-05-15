using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pishgam_Invoice
{
    public partial class frmServices : Form
    {

        SqlConnection con = new SqlConnection("server = localhost;DataBase = Invoice;Integrated Security = True");

        public frmServices()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("Select_All_Services", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvServices.DataSource = dt;
        }
    }
}
