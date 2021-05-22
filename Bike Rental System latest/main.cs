using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Rental_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staffsbut_Click(object sender, EventArgs e)
        {
            staff s = new staff();
            s.ShowDialog();
        }

        private void benefeciariesbut_Click(object sender, EventArgs e)
        {
            benefeciaries bfs = new benefeciaries();
            bfs.ShowDialog();
        }

        private void benefactorbut_Click(object sender, EventArgs e)
        {
            benefactors bns = new benefactors();
            bns.ShowDialog();
        }

        private void bikes_Click(object sender, EventArgs e)
        {
            bikes bi = new bikes();
            bi.ShowDialog();
        }

        private void rentalrecordbut_Click(object sender, EventArgs e)
        {
            rental_records rr = new rental_records();
            rr.ShowDialog();
        }
    }
}
