using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Bike_Rental_System
{
    public partial class bikes : Form
    {
        public bikes()
        {
            InitializeComponent();
        }
        private void addBikebut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                Con.Open();

                if (isActiveState.Text == "")
                {
                    MessageBox.Show("Active state is empty");
                    Con.Close();
                }
                else if (bike_No.Text != "")
                {
                    MessageBox.Show("The bike number is auto-generated!");
                    Con.Close();
                }

                else
                {
                    var Date = DateTime.Now.ToString("M/d/yyyy");
                   /* string query = "INSERT INTO Bikes (bike_model, benefactor_No,bike_color,bike_accessory,bike_condition,donation_date,isActive) VALUES ('" + bike_model.Text + "','" +
                        benefactor_No.Text + "','" + bike_color.Text + "','" + bike_accessory.Text + "','" + bike_condition.Text + "','" + donation_date.Text + "','" + isActiveState.Text + "')"; */
                    string query = "INSERT INTO Bikes (bike_model, benefactor_No,bike_color,bike_accessory,bike_condition,isActive,donation_date) VALUES ('" + bike_model.Text + "','" +
                        benefactor_No.Text + "','" + bike_color.Text + "','" + bike_accessory.Text + "','" + bike_condition.Text + "','"  + isActiveState.Text + "','" + Date + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike added successfully");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void inactivebut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT bike_No, bike_model, benefactor_No, bike_color, bike_accessory, bike_condition, donation_date, isActive from Bikes WHERE Bikes.isActive = 'FALSE'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);

                dgvBikes.DataSource = dtbl;
                Con.Close();
            }
        }
        private void activebut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT bike_No, bike_model, benefactor_No, bike_color, bike_accessory, bike_condition, donation_date, isActive from Bikes WHERE Bikes.isActive = 'TRUE'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvBikes.DataSource = dtbl;
                Con.Close();
            }
        }
        private void editbikedetails_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                if (isActiveState.Text == "")

                {
                    MessageBox.Show("Active state is empty");
                    Con.Close();
                }
                else if (bike_No.Text == "")
                {
                    MessageBox.Show("Please select the bike_No of bike you want to edit");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Bikes SET bike_model = '" + bike_model.Text + "', benefactor_No = '" + benefactor_No.Text + "', " +
                        "bike_color = '" + bike_color.Text + "', bike_accessory = '" + bike_accessory.Text + "',bike_condition = '" + bike_condition.Text + "', " +
                        "isActive = '" + isActiveState.Text + "' WHERE bike_No ='" + bike_No.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike record was updated");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void deletebutbikes_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            try
            {
                if (bike_No.Text == "")
                {
                    MessageBox.Show("Select the bike you want to delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Bikes WHERE bike_No=" + bike_No.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike record deleted");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvBikes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBikes.Rows[e.RowIndex];
                bike_No.Text = row.Cells["bike_No"].Value.ToString();
                bike_model.Text = row.Cells["bike_model"].Value.ToString();
                benefactor_No.Text = row.Cells["benefactor_No"].Value.ToString();
                bike_color.Text = row.Cells["bike_color"].Value.ToString();
                bike_accessory.Text = row.Cells["bike_accessory"].Value.ToString();
                bike_condition.Text = row.Cells["bike_condition"].Value.ToString();
                isActiveState.Text = row.Cells["isActive"].Value.ToString();

            }
        }
        private void cleartextbox_Click(object sender, EventArgs e)
        {
            bike_model.Text = "";
            benefactor_No.Text = "";
            bike_color.Text = "";
            bike_accessory.Text = "";
            bike_condition.Text = "";
            isActiveState.Text = "";
            bike_No.Text = "";
        }
        private void showbenefactors_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT benefactor_No, surname, first_name from Benefactors WHERE Benefactors.isActive = 'TRUE'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvBikes.DataSource = dtbl;
                Con.Close();
            }
        }
        private void refreshbut_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                Con.Open();
                string query = "SELECT * from Bikes";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
                System.Data.DataTable dtbl = new System.Data.DataTable();
                sqldata.Fill(dtbl);
                dgvBikes.DataSource = dtbl;
                Con.Close();
            }
        }
        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
