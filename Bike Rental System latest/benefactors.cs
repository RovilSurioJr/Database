using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Bike_Rental_System
{
    public partial class benefactors : Form
    {
        public benefactors()
        {
            InitializeComponent();
        }
 
        private void addbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                Con.Open();
                if(isActiveState.Text == "")
                {
                    MessageBox.Show("Active state is empty");
                    Con.Close();
                }

                else if (benefactor_No.Text != "")
                {
                    MessageBox.Show("The benefactor number is auto-generated!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Benefactors (surname, first_name, middle_name,email,phone_No,address,isActive) VALUES ('" + last_name.Text + "','" +
                        first_name.Text + "','" + middle_name.Text + "','" + email.Text + "','" + phone_No.Text + "','" + address.Text + "','"+ isActiveState.Text+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Benefactor added successfully");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void refreshbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT * FROM Benefactors";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);

                dgvbenefactors.DataSource = dtbl;
                Con.Close();
            }
        }
        private void activerecordbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))

            {
                Con.Open();
                string query = "SELECT benefactor_No, surname, first_name, middle_name, email, phone_No, address, isActive from Benefactors WHERE Benefactors.isActive = 'TRUE'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvbenefactors.DataSource = dtbl;
                Con.Close();
            }
        }
        private void inactiverecordbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT benefactor_No, surname, first_name, middle_name, email, phone_No, address, isActive from Benefactors WHERE Benefactors.isActive  = 'FALSE'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvbenefactors.DataSource = dtbl;
                Con.Close();
            }
        }

        private void dgvbenefactors_CellContentClick(object sender, DataGridViewCellEventArgs e) // Clicking the Data Grid View will put in the text box the content
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvbenefactors.Rows[e.RowIndex];
                benefactor_No.Text = row.Cells["benefactor_No"].Value.ToString();
                last_name.Text = row.Cells["surname"].Value.ToString();
                first_name.Text = row.Cells["first_name"].Value.ToString();
                middle_name.Text = row.Cells["middle_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                phone_No.Text = row.Cells["phone_No"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
                isActiveState.Text = row.Cells["isActive"].Value.ToString();
            }
        }
        private void deletebut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                if(benefactor_No.Text == "")
                {
                    MessageBox.Show("Select the benefactor to delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Benefactors WHERE benefactor_No=" + benefactor_No.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Benefactor record deleted");
                    Con.Close();
                }

            }catch(Exception ex)
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
                //if (benefactor_No.Text == "" || last_name.Text == "" || first_name.Text == "" || email.Text == "" || phone_No.Text == "" || address.Text == "")
                if (isActiveState.Text == "")
                {
                    MessageBox.Show("Active state is empty");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Benefactors SET surname = '" + last_name.Text + "', first_name = '" + first_name.Text + "', " +
                        "middle_name = '" + middle_name.Text + "', email = '" + email.Text + "',phone_No = '" + phone_No.Text + "', " +
                        "address = '" + address.Text + "', isActive = '" + isActiveState.Text + "' WHERE benefactor_No ='" + benefactor_No.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Benefactor record updated");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void cleartextbox_Click(object sender, EventArgs e)
        {
            benefactor_No.Text = "";
            last_name.Text = "";
            first_name.Text = "";
            middle_name.Text = "";
            email.Text = "";
            phone_No.Text = "";
            address.Text = "";
            isActiveState.Text = "";

        }

        private void exitbut_Click(object sender, EventArgs e)
        {
           // main m = new main();
            // m.ShowDialog();
            Application.Exit();
        }
    }
}
