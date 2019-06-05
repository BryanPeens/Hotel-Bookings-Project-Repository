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
    public partial class frmQuota : Form
    {
        private QuoteInput qInput { get; set; }

        public frmQuota(QuoteInput quota)
        {
            this.qInput = quota;
            InitializeComponent();
        }
        public frmQuota()
        {
            InitializeComponent();
        }

        private void frmQuota_Load(object sender, EventArgs e)
        {
            txtQuoteBox.Text = this.qInput.generateQuote();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("Do you want to save this quota? ", MessageBoxButtons.YesNo));
            if (MessageBox.Show("Do you want to save the quota ?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Save_Quota sq = new Save_Quota(this.qInput);
                sq.ShowDialog();
            }
            this.Close();
        }
    }
}