using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void addbut_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                if (beneficiary_No.Text == "" || surname.Text == "" || first_name.Text == "" || email.Text == "" || phone_No.Text == "" || address.Text == "")
                {
                    MessageBox.Show("There are columns that are not allowing nulls!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Beneficiaries VALUES(" + beneficiary_No.Text + ",'" + surname.Text + "','" +
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
            try
            {
                if (beneficiary_No.Text == "" || surname.Text == "" || first_name.Text == "" || email.Text == "" || phone_No.Text == "" || address.Text == "")
                {
                    MessageBox.Show("There is missing field! Only Middle_name allow NULLS");
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
            Con.Open();
            string query = "SELECT * FROM Beneficiaries";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvbenefeciaries.DataSource = dtbl;
            Con.Close();
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
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }
    }
}
