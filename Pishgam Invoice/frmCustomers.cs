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
    public partial class frmCustomers : Form
    {

        SqlConnection con = new SqlConnection("Server = .; Database = Invoice; Integrated Security = True");

        public frmCustomers()
        {
            InitializeComponent();
            this.Text = "اطلاعات مشتریان";
            LoadData();
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select_Customers", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Add_Customer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@economicCode", txtEconomicCode.Text);
            cmd.Parameters.AddWithValue("@registerCode", txtRegiserCode.Text);
            cmd.Parameters.AddWithValue("@province", txtProvince.Text);
            cmd.Parameters.AddWithValue("@state", txtState.Text);
            cmd.Parameters.AddWithValue("@postalCode", txtPostalCode.Text);
            cmd.Parameters.AddWithValue("@city", txtCity.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }
    }
}
