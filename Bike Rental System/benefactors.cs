using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bike_Rental_System
{
    public partial class benefactors : Form
    {
        public benefactors()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into Benefactors values(" + benefactor_No.Text + ",'" + last_name.Text + "','" + first_name.Text + "','" + middle_name.Text + "','" + email.Text + "','" + phone_No.Text + "','" + address.Text + "','" + isActiveState.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("benefactor added successfully");
                Con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from Benefactors";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvbenefactors.DataSource = dtbl;
            Con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Con.Open();
            // string query = "select * from Benefactors";
            string query = "SELECT benefactor_No, surname, first_name, middle_name, email, phone_No, address from Benefactors WHERE Benefactors.isActive IS NOT NULL";

            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvbenefactors.DataSource = dtbl;
            Con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Con.Open();
            // string query = "select * from Benefactors";
            string query = "SELECT benefactor_No, surname, first_name, middle_name, email, phone_No, address from Benefactors WHERE Benefactors.isActive IS NULL";

            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvbenefactors.DataSource = dtbl;
            Con.Close();
        }
    }
}
