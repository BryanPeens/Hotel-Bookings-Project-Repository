using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Project2
{
    public partial class frmBooking : Form
    {
        private Suite suiteObject { get; set; }

        public frmBooking()
        {
            InitializeComponent();
        }

        List<Suite> mySuiteObject = new List<Suite>();
        DataHandler dh = new DataHandler();


        private void frmBooking_Load(object sender, EventArgs e)
        {
            imgBanner.BackgroundImageLayout = ImageLayout.Stretch;
            imgBanner.BackgroundImage = Image.FromFile(
            Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
           "Resources\\Banner.png"));

            mmDescription.Text = ""; // Clear text

            DataGridBinding();

            //strgrdSuite.
            //trgrdSuite.Rows[0].Selected = true;

            setData();
        }
        Filehandler fh = new Filehandler();

        public void DataGridBinding()
        {
            List<string> suiteObjects = fh.Readfile("Suites.sts");
            strgrdSuite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            strgrdSuite.DataSource = suiteObjects;
            DataTable dt = new DataTable();
            for (int i = 0; i < suiteObjects.Count; i++)
            {
                string currentString = suiteObjects[i];
                string[] columns = currentString.Split('*');
                if (i == 0)
                {
                    foreach (string item in columns)
                    {
                        dt.Columns.Add(item);
                    }
                }
                else
                {
                    DataRow row = dt.NewRow();
                    for (int j = 0; j < columns.Length; j++)
                    {
                        row[j] = columns[j];
                    }
                    dt.Rows.Add(row);
                }
            }
            strgrdSuite.DataSource = dt;
        }

        private void dgvSuites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //List<string> displayObject = new List<string>();
            //displayObject.Add(dgvSuites.SelectedRows.ToString());
            //displayObject.ForEach(n => lstBoxDisplay.Items.Add(n.ToString()));

            //DataBinding();
        }

        private void lstBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //public void DataBinding()
        //{
        //    DataHandler dh = new DataHandler();
        //    DataTable dt = dh.GetData("tblSuites");
        //    strgrdSuite.DataSource = dt;
        //    mySuiteObject.Clear();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        mySuiteObject.Add(new Suites(row[1].ToString(), row[2].ToString(), int.Parse(row[3].ToString()), double.Parse(row[4].ToString())));
        //    }
        //    List<string> clientstrings = new List<string>();
        //    mySuiteObject.ForEach(n => clientstrings.Add(n.ToString()));
        //    mmDescription.Text = clientstrings;
        //}

        private void btnSetBooking_Click(object sender, EventArgs e)
        {
        }

        private void btnSetBooking_Click_1(object sender, EventArgs e)
        {
            //Suites suite = new Suites();
            //XmlSerializer serializer = new XmlSerializer(typeof(Suites));
            //StreamWriter xsw = new StreamWriter("serials.xml");
            //serializer.Serialize(xsw.BaseStream, suite);
            //MessageBox.Show("Serialization Done");
            //xsw.Close();

            if (this.suiteObject == null)
            {
                MessageBox.Show("Please Pick a suit from the grid");
            }
            else
            {
                frmSetBooking f4 = new frmSetBooking(this.suiteObject);
                f4.Show();
                this.Hide();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMenuOptions fmo = new frmMenuOptions();
            fmo.Show();
            this.Close();
        }

        private void strgrdSuite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = sender as DataGridView;

        }

        private void setData()
        {
            if (strgrdSuite.SelectedCells.Count > 0)
            {
                int i = 0;
                int selectedrowindex = strgrdSuite.SelectedCells[0].RowIndex;

                DataTable dt = (DataTable)strgrdSuite.DataSource;
                DataRow selectedRow = dt.Rows[selectedrowindex];

                mmDescription.Text = selectedRow.ItemArray[1].ToString();
                this.suiteObject = new Suite(
                    selectedRow.ItemArray[0].ToString(),
                    selectedRow.ItemArray[1].ToString(),
                    Convert.ToInt32(selectedRow.ItemArray[2].ToString()),
                    Convert.ToDouble(selectedRow.ItemArray[3].ToString()));

                pnlSuite.BackgroundImageLayout = ImageLayout.Stretch;
                pnlSuite.BackgroundImage = Image.FromFile(
                Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
               "SuiteImages\\" + this.suiteObject.SuiteName.Replace(" ", "") + ".jpg")); // replaces all spaces with empty string

                //DataGridViewRow selectedRow = datagridview1.Rows[selectedrowindex];

                //string a = Convert.ToString(selectedRow.Cells["you have to mention you cell  corresponding column name"].Value);
            }
        }

        List<Suite> suiteList = new List<Suite>();
        private void strgrdSuite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setData();
        }

        private void strgrdSuite_SelectionChanged(object sender, EventArgs e)
        {
            
            //if (strgrdSuite.SelectedCells.Count > 0)
            //{
            //    int i = 0;
            //    int selectedrowindex = strgrdSuite.SelectedCells[0].RowIndex;

            //    DataTable dt = (DataTable)strgrdSuite.DataSource;
            //    DataRow selectedRow = dt.Rows[selectedrowindex];

            //    //DataGridViewRow selectedRow = datagridview1.Rows[selectedrowindex];

            //    //string a = Convert.ToString(selectedRow.Cells["you have to mention you cell  corresponding column name"].Value);


            //}
        }
    }
}

