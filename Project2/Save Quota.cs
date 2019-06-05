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
    public partial class Save_Quota : Form
    {
        private QuoteInput qInput { get; set; }
        public Save_Quota(QuoteInput quota)
        {
            this.qInput = quota;
            InitializeComponent();
        }

        Filehandler fh = new Filehandler();
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Save to textfile
            List<string> objList = new List<string>();
            objList.Add(this.qInput.generateQuote());
            fh.Writefile(txtQuotaFilename.Text, objList, false);
            MessageBox.Show(string.Format("Quota saved in : {0} ", txtQuotaFilename.Text));

            frmMenuOptions mo = new frmMenuOptions();
            mo.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenuOptions mo = new frmMenuOptions();
            mo.Show();
            this.Close();
        }
    }
}
