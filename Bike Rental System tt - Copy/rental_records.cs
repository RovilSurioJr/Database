using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace Bike_Rental_System
{
    public partial class rental_records : Form
    {
        public rental_records()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void exitbut_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void addbut_Click(object sender, System.EventArgs e)
        {
            try
            {
                Con.Open();

                if (bike_No.Text == "" || beneficiary_No.Text == "" || rental_date.Text == "" || cond_before.Text == "" || lender_staff_No.Text == "" || validity.Text == "")
                {
                    MessageBox.Show("There are columns that are not allowing nulls!");
                    Con.Close();
                }
                else if (rental_rec_No.Text != "")
                {
                    MessageBox.Show("The rental record number is auto-generated!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Rental_records (bike_No, beneficiary_No,rental_date,bike_condition_before,staff_lender_No,isValid) VALUES ('" + bike_No.Text + "','" +
                        beneficiary_No.Text + "','" + rental_date.Text + "','" + cond_before.Text + "','" + lender_staff_No.Text + "','" + validity.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike Rental Record Added Successfully");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void showbeneficiary_Click(object sender, System.EventArgs e)
        {
            Con.Open();
            string query = "SELECT beneficiary_No, surname, first_name FROM Beneficiaries";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close(); 
        }

        private void dgvrentalrec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvrentalrec.Rows[e.RowIndex];
                rental_rec_No.Text = row.Cells["rental_record_No"].Value.ToString();
                bike_No.Text = row.Cells["bike_No"].Value.ToString();
                beneficiary_No.Text = row.Cells["beneficiary_No"].Value.ToString();
                rental_date.Text = row.Cells["rental_date"].Value.ToString();
                return_date.Text = row.Cells["return_date"].Value.ToString();
                cond_before.Text = row.Cells["bike_condition_before"].Value.ToString();
                cond_after.Text = row.Cells["bike_condition_after"].Value.ToString();
                lender_staff_No.Text = row.Cells["staff_lender_No"].Value.ToString();
                receiver_staff_No.Text = row.Cells["staff_receiver_No"].Value.ToString();
                validity.Text = row.Cells["isValid"].Value.ToString();

            }
        }
        private void showbikes_Click(object sender, System.EventArgs e)
        {
            Con.Open();
            string query = "SELECT bike_No, bike_model, bike_color,bike_condition from Bikes WHERE Bikes.isActive = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close();
        }

        private void showstaffs_Click(object sender, System.EventArgs e)
        {
            Con.Open();
            string query = "SELECT staff_No, surname, first_name FROM Staffs WHERE Staffs.isActive = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close();
        }

        private void refreshbut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * from Rental_records";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close();
        }

        private void editbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (bike_No.Text == "" || beneficiary_No.Text == "" || rental_date.Text == "" || cond_before.Text == "" || lender_staff_No.Text == "" || validity.Text == "" || rental_rec_No.Text == "" || return_date.Text == "" || cond_after.Text == "" || receiver_staff_No.Text == "")

                {
                    MessageBox.Show("All columns does not allow Null!");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Rental_records SET bike_No = '" + bike_No.Text + "', beneficiary_No = '" + beneficiary_No.Text + "', " +
                        "rental_date = '" + rental_date.Text + "', bike_condition_before = '" + cond_before.Text + "', bike_condition_after = '" + cond_after.Text + "', " +
                        "staff_lender_No= '" + lender_staff_No.Text + "', staff_receiver_No = '" + receiver_staff_No.Text + "', isValid = '"+ validity.Text + "', return_date = '"+return_date.Text+"' WHERE rental_record_No ='" + rental_rec_No.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rental record was updated");
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
            try
            {
                if (rental_rec_No.Text == "")
                {
                    MessageBox.Show("Select the record you want to delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Rental_records WHERE rental_record_No=" + rental_rec_No.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike rental record deleted");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void active_but_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT rental_record_No, bike_No, beneficiary_No, rental_date, return_date, bike_condition_before, bike_condition_after, staff_lender_No, staff_receiver_No,isValid FROM Rental_records WHERE Rental_records.isValid = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close();
        }
        private void inactivebut_Click(object sender, EventArgs e)
        {
            string query = "SELECT rental_record_No, bike_No, beneficiary_No, rental_date, return_date, bike_condition_before, bike_condition_after, staff_lender_No, staff_receiver_No,isValid FROM Rental_records WHERE Rental_records.isValid = 'FALSE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvrentalrec.DataSource = dtbl;
            Con.Close();
        }

        private void cleartext_Click(object sender, EventArgs e)
        {
            bike_No.Text = "";
            beneficiary_No.Text = "";
            rental_date.Text = "";
            return_date.Text = "";
            cond_after.Text = "";
            cond_before.Text = "";
            rental_rec_No.Text = "";
            lender_staff_No.Text = "";
            receiver_staff_No.Text = "";
            validity.Text = "";
        }
    }

}
