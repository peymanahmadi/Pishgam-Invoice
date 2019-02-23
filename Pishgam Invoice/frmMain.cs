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
    public partial class frmMain : Form
    {

        SqlConnection con = new SqlConnection("server = localhost;DataBase = Invoice;Integrated Security = True");

        public frmMain()
        {
            InitializeComponent();
            this.Text = "شرکت فنی مهندسی توسعه الکترونیک پیشگام";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt_Date = new DataTable();
            dt_Date.Columns.Add("date");
            dt_Date.Rows.Add();
            dt_Date.Rows[0]["date"] = "1396/04/25";
            //
            SqlDataAdapter da = new SqlDataAdapter("Report_Invoice_Number", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            DataTable dt_Invoice = new DataTable();
            da.Fill(dt_Invoice);
            DataSet ds = new DataSet();
            ds.Merge(dt_Date);
            ds.Merge(dt_Invoice);
            ds.Tables[0].TableName = "dt_Date";
            ds.Tables[1].TableName = "dt_Invoice";
            stiReport_Invoice.Load("stiReport_Invoice.mrt");
            stiReport_Invoice.RegData(ds);
            stiReport_Invoice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.ShowDialog();
        }
    }
}
