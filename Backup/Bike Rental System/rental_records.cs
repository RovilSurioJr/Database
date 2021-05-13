using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bike_Rental_System
{
    public partial class rental_records : Form
    {
        public rental_records()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void addbut_Click(object sender, System.EventArgs e)
        {
           /* try
            {
                Con.Open();

                if (rental_rec_No.Text == "" || bike_No.Text == "" || beneficiary_No.Text == "" || rental_date.Text == "" || return_date.Text == "" || cond_before.Text == "" || cond_after.Text == "" || lender_staff_No.Text == "" || receiver_staff_No.Text == "" || validity.Text == "")
                {
                    MessageBox.Show("There are columns that are not allowing nulls!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Rental_records VALUES(" + beneficiary_No.Text + ",'" + surname.Text + "','" +
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
            } */
        }
    }

}
