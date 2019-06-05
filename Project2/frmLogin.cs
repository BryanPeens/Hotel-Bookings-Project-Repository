using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Project2
{
    public partial class frmLogin : Form
    {
        DataHandler dh = new DataHandler();
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();

            testStuff();
        }

        private void testStuff()
        {
//            int i = 0;
        }

        public void splashStart()
        {
            Application.Run(new SplashScreen());
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            edtUsername.Clear();
            mskedtPassword.Clear();
        }

        private string GeneratePassword(string username)
        {

            char[] chars = username.ToCharArray();
            string newPass = "";
            int sum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if ((i + 1) % 2 != 0)
                {
                    sum += (int)chars[i];
                    newPass += chars[i];
                }
            }
            newPass += sum.ToString(); ;
            return newPass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (edtUsername.Text.Trim() == "")
            {
                edtUsername.Focus();
                MessageBox.Show("Username is required.");
                return;
            }
            if (mskedtPassword.Text.Trim() == "")
            {
                mskedtPassword.Focus();
                MessageBox.Show("Password is required.");
                return;
            }
            try
            {
                List<Users> userList = dh.GetUserData();

                var usenameCheck = (from user in userList
                                   where user.Username == edtUsername.Text
                                   select user).FirstOrDefault();                

                if (usenameCheck != null)
                {
                    string pass = GeneratePassword(edtUsername.Text);
                    if (pass == mskedtPassword.Text)
                    {
                        MessageBox.Show("Login Succesful");
                        frmMenuOptions f2 = new frmMenuOptions();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Invalid login Password : " + pass));
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = chkBoxShowPass.Checked;
            switch (check)
            {
                case true:
                    mskedtPassword.UseSystemPasswordChar = false;
                    break;
                default:
                    mskedtPassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
