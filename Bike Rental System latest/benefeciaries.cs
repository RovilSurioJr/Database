using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Bike_Rental_System
{
    public partial class benefeciaries : Form
    {
        public benefeciaries()
        {
            InitializeComponent();
        }
        private void exitbut_Click(object sender, EventArgs e)
        {
            main s = new main();
            this.Close();
        }
        private void addbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                Con.Open();
                if (beneficiary_No.Text != "")
                {
                    MessageBox.Show("The benefiary number is auto-generated!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Beneficiaries (surname, first_name, middle_name,email,phone_No,address) VALUES ('"+ surname.Text + "','" +
                        first_name.Text + "','" + middle_name.Text + "','" + email.Text + "','" + phone_No.Text + "','" + address.Text + "')"; 
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Beneficiary added successfully");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void editbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                if (beneficiary_No.Text == "")
                {
                    MessageBox.Show("Please select the beneficiary number");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Beneficiaries SET surname = '" + surname.Text + "', first_name = '" + first_name.Text + "', " +
                        "middle_name = '" + middle_name.Text + "', email = '" + email.Text + "',phone_No = '" + phone_No.Text + "', " +
                        "address = '" + address.Text + "' WHERE beneficiary_No ='" + beneficiary_No.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Beneficiary record updated");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                if (beneficiary_No.Text == "")
                {
                    MessageBox.Show("Select the beneficiary to delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Beneficiaries WHERE beneficiary_No=" + beneficiary_No.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Beneficiary record deleted");
                    Con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))

            {
                Con.Open();
                string query = "SELECT * FROM Beneficiaries";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvbenefeciaries.DataSource = dtbl;
                Con.Close();
            }
        }

        private void dgvbenefeciaries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbenefeciaries.Rows[e.RowIndex];
                beneficiary_No.Text = row.Cells["beneficiary_No"].Value.ToString();
                surname.Text = row.Cells["surname"].Value.ToString();
                first_name.Text = row.Cells["first_name"].Value.ToString();
                middle_name.Text = row.Cells["middle_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                phone_No.Text = row.Cells["phone_No"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
            }
        }

        private void cleartext_Click(object sender, EventArgs e)
        {
            beneficiary_No.Text = "";
            surname.Text = "";
            first_name.Text = "";
            middle_name.Text = "";
            email.Text = "";
            phone_No.Text = "";
            address.Text = "";
        }

    }
}
