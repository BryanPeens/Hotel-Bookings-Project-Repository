using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class frmMenuOptions : Form
    {
        public frmMenuOptions()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewSuitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooking f3 = new frmBooking();
            f3.Show();
            this.Hide();

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void exitBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("You Have Canceled the bookings process"));
            frmLogin f1 = new frmLogin();
            f1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
