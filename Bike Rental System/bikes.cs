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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "INSERT INTO Bikes values("+bike_No.Text +",'"+bike_model.Text+"','"+benefactor_No.Text+"','"+bike_color.Text+"','"+bike_accessory.Text+"','"+bike_condition.Text+"','"+donation_date.Text+"','"+isActiveState.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("bike added successfully");
                Con.Close();


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * from Bikes";
            SqlDataAdapter sqldata = new SqlDataAdapter(query, Con);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqldata.Fill(dtbl);

            dgvBikes.DataSource = dtbl;
            Con.Close();

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


    }
}
