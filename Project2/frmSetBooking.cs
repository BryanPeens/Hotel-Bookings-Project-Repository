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
    public partial class frmSetBooking : Form
    {
        private Suite suiteObject{ get; set; }
        public frmSetBooking()
        {
            InitializeComponent();
        }
        public frmSetBooking(Suite suiteObject)
        {
            this.suiteObject = suiteObject;
            InitializeComponent();
        }

        DataHandler dh = new DataHandler();
        private void Form4_Load(object sender, EventArgs e)
        {
            // Clear all fields on the form
            edtName.Clear();
            edtSurname.Clear();
            edtID.Clear();
            edtTelNumber.Clear();
            cspnedtnumPatrons.Value = 1;
            cspnedtNumdays.Value = 1;
            mmAddress.Clear();


            btbtnApply.Enabled = true;
            btbtnSaveQ.Enabled = false;


            List<SuiteOption> suiteOptions = dh.GetSuiteOptions();
            suiteOptions.ForEach(n =>
            {
                chcklstbxOptions.Items.Add(n.OptionName, false);
            });


            lblTextChange.Text = this.suiteObject.SuiteName;
        }

        private void btbtnApply_Click(object sender, EventArgs e)
        {
            if (edtName.Text.Trim() == "")
            {
                edtName.Focus();
                MessageBox.Show("Please supply a name");
                return;
            }
            if (edtSurname.Text.Trim() == "")
            {
                edtSurname.Focus();
                MessageBox.Show("Please supply a surname");
                return;
            }
            if (edtID.Text.Trim().Length != 13)
            {
                edtID.Focus();
                MessageBox.Show("Invalid ID Number - must be 13 characters");
                return;
            }
            if (edtTelNumber.Text.Trim().Length != 10)
            {
                edtTelNumber.Focus();
                MessageBox.Show("Please supply Telephone Number - must be 10 chaacters");
                return;
            }
            if (cspnedtnumPatrons.Value > suiteObject.MaxPatrons)
            {
                cspnedtnumPatrons.Focus();
                MessageBox.Show(string.Format("Number of Patrons can only be a Maximum of {0}", suiteObject.MaxPatrons));
                return;
            }
            if (cspnedtNumdays.Value < 1)
            {
                cspnedtNumdays.Focus();
                MessageBox.Show("Please choose Number of days greater than 0");
                return;
            }
            btbtnApply.Enabled = false;
            btbtnSaveQ.Enabled = true;
        }

        private void btbtnSaveQ_Click(object sender, EventArgs e)
        {
            //chcklstbxOptions.CheckedItems
            //chcklstbxOptions.CheckedItems.
            //List<SuiteOption> suiteOptions = dh.GetSuiteOptions();
            //chcklstbxOptions.CheckedItems.GetEnumerat

            var list = new List<string>();
            foreach (var item in chcklstbxOptions.CheckedItems)
            {
                list.Add(item.ToString());
                //int i = 0;
            }

            List<SuiteOption> suiteOptions = dh.GetSuiteOptions();
            var chosenSuiteOptions = suiteOptions.Where((item) => list.Contains(item.OptionName)).ToList();

            int i = 0;

            QuoteInput qinp = new QuoteInput(
                edtName.Text,
                edtSurname.Text,
                edtID.Text,
                edtTelNumber.Text,
                Convert.ToInt32(cspnedtnumPatrons.Value),
                Convert.ToInt32(cspnedtNumdays.Value),
                mmAddress.Text,
                chosenSuiteOptions, // object
                this.suiteObject
                );

            frmQuota fq = new frmQuota(qinp);
            fq.Show();
            this.Close();
        }
    }
}

/****
 * string name, string surname, string id, string telNumber, int numberOfPatrons, int numOfDays, string address
 * 
 * 
 *             edtName.Clear();
            edtSurname.Clear();
            edtID.Clear();
            edtTelNumber.Clear();
            cspnedtnumPatrons.Value = 1;
            cspnedtNumdays.Value = 1;
            mmAddress.Clear();
*/
