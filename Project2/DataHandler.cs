using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project2
{
    class DataHandler
    {
        static string connString = @"Data Source=localhost;Initial Catalog=HotelPerfect;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);

        public DataTable GetData(string table)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT * FROM " + table, conn);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public void Insert(MyClient mc)
        {
            try
            {
                conn.Open();
                string query = string.Format("INSERT INTO tblClient(clientName,clientSurname,clientIDnumber,clienttelephone) VALUES('{0}','{1}','{2}','{3}')", mc.Name, mc.Surname, mc.IdNumber, mc.PhoneNumber);
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Client Has Been Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(MyClient mc)
        {
            try
            {
                conn.Open();
                string query = string.Format("UPDATE tblClient SET clientName='{0}',clientSurname='{1}','clientIDnumber={2}','clienttelephoneNumber WHERE clientID='{3}'", mc.Name, mc.Surname, mc.IdNumber, mc.PhoneNumber);
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Client Has Been Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(string id)
        {
            try
            {
                conn.Open();
                string query = string.Format("DELETE FROM tblClient WHERE clientIDnumber='{0}'", id);
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Client Has Been Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<SuiteOption> GetSuiteOptions()
        {
            DataTable dt = this.GetData("tblSuiteOptions");
            List<SuiteOption> suiteOption = new List<SuiteOption>();

            var qry = from item in dt.AsEnumerable()
                      //where Convert.ToDecimal(item["optionPrice"]) >= 100
                       select new SuiteOption(Convert.ToInt32(item["optionID"]), item["optionName"].ToString(), Convert.ToDecimal(item["optionPrice"]), Convert.ToBoolean(item["perDay"]));

            List<SuiteOption> rows = qry.ToList();

            return rows;
        }

        public List<Users> GetUserData()
        {
            DataTable dt = this.GetData("tblUsers");
            List<Users> suiteOption = new List<Users>();

            var qry = from item in dt.AsEnumerable()
                      select new Users(item[0].ToString(), item[1].ToString());

            List<Users> rows = qry.ToList();

            return rows;
        }


    }
}
