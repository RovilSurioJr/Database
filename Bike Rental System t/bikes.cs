﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bike_Rental_System
{
    public partial class bikes : Form
    {
        public bikes()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-FQPTJQM\SQLEXPRESS;Initial Catalog=Bike_Rental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void addBikebut_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                if (bike_model.Text == "" || benefactor_No.Text == "" || bike_color.Text == "" || bike_accessory.Text == "" || bike_condition.Text == "" || donation_date.Text == "" || isActiveState.Text == "")
                {
                    MessageBox.Show("There are columns that are not allowing nulls!");
                    Con.Close();
                }
                else if (bike_No.Text != "")
                {
                    MessageBox.Show("The bike number is auto-generated!");
                    Con.Close();
                }
                else
                {
                    string query = "INSERT INTO Bikes (bike_model, benefactor_No,bike_color,bike_accessory,bike_condition,donation_date,isActive) VALUES ('" + bike_model.Text + "','" +
                        benefactor_No.Text + "','" + bike_color.Text + "','" + bike_accessory.Text + "','" + bike_condition.Text + "','" + donation_date.Text + "','" + isActiveState.Text + "')";
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
            Con.Open();
            string query = "SELECT bike_No, bike_model, benefactor_No, bike_color, bike_accessory, bike_condition, donation_date from Bikes WHERE Bikes.isActive = 'FALSE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvBikes.DataSource = dtbl;
            Con.Close();
        }
        private void activebut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT bike_No, bike_model, benefactor_No, bike_color, bike_accessory, bike_condition, donation_date from Bikes WHERE Bikes.isActive = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvBikes.DataSource = dtbl;
            Con.Close();
        }
        private void editbikedetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (bike_No.Text == "" || bike_model.Text == "" || benefactor_No.Text == "" || bike_color.Text == "" || bike_accessory.Text == "" || bike_condition.Text == "" || donation_date.Text == "" || isActiveState.Text == "")

                {
                    MessageBox.Show("All columns does not allow Null!");
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    string query = "UPDATE Bikes SET bike_model = '" + bike_model.Text + "', benefactor_No = '" + benefactor_No.Text + "', " +
                        "bike_color = '" + bike_color.Text + "', bike_accessory = '" + bike_accessory.Text + "',bike_condition = '" + bike_condition.Text + "', " +
                        "donation_date= '" + donation_date.Text + "', isActive = '" + isActiveState.Text + "' WHERE bike_No ='" + bike_No.Text + "'";
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
                donation_date.Text = row.Cells["donation_date"].Value.ToString();
                isActiveState.Text = row.Cells["isActive"].Value.ToString();

            }
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
        private void showbenefactors_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT benefactor_No, surname, first_name from Benefactors WHERE Benefactors.isActive = 'TRUE'";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvBikes.DataSource = dtbl;
            Con.Close();
        }
        private void refreshbut_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * from Bikes";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);
            dgvBikes.DataSource = dtbl;
            Con.Close();
        }
        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
