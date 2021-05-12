using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bike_Rental_System
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * from Staffs";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvStaffs.DataSource = dtbl;
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO Staffs values(" + staff_No.Text + ",'" + last_name.Text + "','" + first_name.Text + "','" + middle_name.Text + "','" + email.Text + "','" + phone_No.Text + "','"  + isActivestate.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Added Successfully");
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
    }
}
