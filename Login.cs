using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace skills_international_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=SAHIRULLAH\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                SqlCommand cmd = new SqlCommand("select username, password from Logins where username='" + username + "'and password='" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    Register register = new Register();
                    register.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials, please check Username and Password and try again.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearText();
                }
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearText();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearText() {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
