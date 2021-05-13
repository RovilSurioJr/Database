﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStaffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                if (staff_No.Text == "" || surname.Text == "" || first_name.Text == "" || email.Text == "" || phone_No.Text == "" || address.Text == "" || isActivestate.Text == "")
                {
                    MessageBox.Show("There are columns that are not allowing nulls!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Staffs VALUES(" + staff_No.Text + ",'" + surname.Text + "','" +
                        first_name.Text + "','" + middle_name.Text + "','" + email.Text + "','" + phone_No.Text + "','" + address.Text + "','" + isActivestate.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff added successfully");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }
        private void deletestaffbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (staff_No.Text == "")
                {
                    MessageBox.Show("Select the staff you want to delete");
                }
                else
                {
                    Con.Open();
                    string query = "DELETE FROM Staffs WHERE staff_No=" + staff_No.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff record deleted");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebut_Click(object sender, EventArgs e)
        {
            try
            {
                if (staff_No.Text == "" || surname.Text == "" || first_name.Text == "" || email.Text == "" || phone_No.Text == "" || address.Text == "")
                {
                    MessageBox.Show("There is missing field! Only Middle_name allow NULLS");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Staffs SET surname = '" + surname.Text + "', first_name = '" + first_name.Text + "', " +
                        "middle_name = '" + middle_name.Text + "', email = '" + email.Text + "',phone_No = '" + phone_No.Text + "', " +
                        "address = '" + address.Text + "', isActive = '" + isActivestate.Text + "' WHERE staff_No ='" + staff_No.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff record updated");
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void dgvstaffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvstaffs.Rows[e.RowIndex];
                staff_No.Text = row.Cells["staff_No"].Value.ToString();
                surname.Text = row.Cells["surname"].Value.ToString();
                first_name.Text = row.Cells["first_name"].Value.ToString();
                middle_name.Text = row.Cells["middle_name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                phone_No.Text = row.Cells["phone_No"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
                isActivestate.Text = row.Cells["isActive"].Value.ToString();
            }
        }

        private void refreshbut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM Staffs";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvstaffs.DataSource = dtbl;
            Con.Close();
        }

        private void activestafffsbut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT staff_No, surname, first_name, middle_name, email, phone_No, address from Staffs WHERE Staffs.isActive = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvstaffs.DataSource = dtbl;
            Con.Close();
        }

        private void inactivestaffsbut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT staff_No, surname, first_name, middle_name, email, phone_No, address from Staffs WHERE Staffs.isActive = 'FALSE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvstaffs.DataSource = dtbl;
            Con.Close();
        }

        private void cleartextbox_Click(object sender, EventArgs e)
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
