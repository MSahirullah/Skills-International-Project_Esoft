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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=SAHIRULLAH\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");

        Boolean isLoading = true;
       
        private void Register_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            con.Open();
            GetStudentRegNo();
            con.Close();
            ClearAll();
            isLoading = false;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                isLoading = true;

                if (cmbBoxRegNo.Text == "")
                {
                    con.Open();

                    string fName = txtFName.Text;
                    string lName = txtLName.Text;
                    string dob = dateTimeDOB.Text;

                    string gender = "";
                    if (radioButtonMale.Checked) { gender = "Male"; }
                    else { gender = "Female"; }

                    string address = txtAddress.Text;
                    string mobilePhone = txtMobilePhone.Text;
                    string homePhone = txtHomePhone.Text;
                    string parentName = txtParentName.Text;
                    string parentNIC = txtNIC.Text;
                    string parentContactNumber = txtContactNumber.Text;
                    string email = txtEmail.Text;

                    if (fName == "" || lName == "" || dob == "" || gender == "" || address == "" || mobilePhone == "" || parentName == "" || parentNIC == "" || parentContactNumber == "")
                    {
                        MessageBox.Show("Please fill out required the information.", "Required fields are missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DateTime dobC = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
                        dob = dobC.ToString("yyyy-MM-dd HH:mm:ss.fff");

                        string inQ = "INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES('" + fName + "'," + "'" + lName + "','" + dob + "','" + gender + "','" + address + "','" + email + "'," + "'" + mobilePhone + "','" + homePhone + "','" + parentName + "','" + parentNIC + "','" + parentContactNumber + "')";

                        SqlCommand cmdIN = new SqlCommand(inQ, con);
                        cmdIN.ExecuteNonQuery();

                        GetStudentRegNo();
                        ClearAll();

                        MessageBox.Show("Record Added successfully!", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Student Already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                isLoading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Please try again." + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbBoxRegNo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string regNo = cmbBoxRegNo.Text;

                if (regNo != "" && !isLoading)
                {
                    con.Open();
                    string searchQ = "SELECT * FROM Registration WHERE regNo = '" + regNo + "'";
                    SqlCommand searchCMD = new SqlCommand(searchQ, con);
                    SqlDataReader searchRDR = searchCMD.ExecuteReader();

                    if (searchRDR.HasRows)
                    {
                        int x = 0;
                        while (searchRDR.Read())
                        {
                            if (x == 0)
                            {
                                cmbBoxRegNo.Text = searchRDR[0].ToString();
                                txtFName.Text = searchRDR[1].ToString();
                                txtLName.Text = searchRDR[2].ToString();
                                dateTimeDOB.Text = searchRDR[3].ToString();

                                if (searchRDR[4].ToString() == "Male")
                                {
                                    radioButtonMale.Checked = true;
                                }
                                else
                                {
                                    radioButtonFemale.Checked = true;
                                }

                                txtAddress.Text = searchRDR[5].ToString();
                                txtEmail.Text = searchRDR[6].ToString();
                                txtMobilePhone.Text = searchRDR[7].ToString();
                                txtHomePhone.Text = searchRDR[8].ToString();
                                txtParentName.Text = searchRDR[9].ToString();
                                txtNIC.Text = searchRDR[10].ToString();
                                txtContactNumber.Text = searchRDR[11].ToString(); ;
                            }
                            x++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student Reg No.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    searchRDR.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Please try again." + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = cmbBoxRegNo.Text;
                isLoading = true;

                if (regNo != "")
                {
                    con.Open();

                    if (CheckStudnetExist(regNo))
                    {
                        string fName = txtFName.Text;
                        string lName = txtLName.Text;
                        string dob = dateTimeDOB.Text;

                        string gender = "";
                        if (radioButtonMale.Checked) { gender = "Male"; }
                        else { gender = "Female"; }

                        string address = txtAddress.Text;
                        string mobilePhone = txtMobilePhone.Text;
                        string homePhone = txtHomePhone.Text;
                        string parentName = txtParentName.Text;
                        string parentNIC = txtNIC.Text;
                        string parentContactNumber = txtContactNumber.Text;
                        string email = txtEmail.Text;

                        if (fName == "" || lName == "" || dob == "" || gender == "" || address == "" || mobilePhone == "" || parentName == "" || parentNIC == "" || parentContactNumber == "")
                        {
                            MessageBox.Show("Please fill out required the information.", "Required fields are missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DateTime dobC = DateTime.ParseExact(dob, "dd/MM/yyyy", null);
                            dob = dobC.ToString("yyyy-MM-dd HH:mm:ss.fff");

                            string updateQ = "UPDATE Registration SET firstName = '" + fName + "', lastName = '" + lName + "', dateOfBirth = '" + dob + "', gender = '" + gender + "', address = '" + address + "', email = '" + email + "', mobilePhone = '" + mobilePhone + "', homePhone = '" + homePhone + "', parentName = '" + parentName + "', nic = '" + parentNIC + "', contactNo = '" + parentContactNumber + "' WHERE regNo = '" + regNo + "'";

                            SqlCommand cmdUpdate = new SqlCommand(updateQ, con);
                            cmdUpdate.ExecuteNonQuery();

                            MessageBox.Show("Record Updated successfully!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student Index.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Student Index.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                isLoading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Please try again." + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = cmbBoxRegNo.Text;
                isLoading = true;

                if (regNo != "")
                {
                    con.Open();

                    if (CheckStudnetExist(regNo))
                    {
                        var confirmResult = MessageBox.Show("Are you sure, Do you really want to Delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {
                            string DeleteQ = "DELETE from Registration WHERE regNo = '" + regNo + "'";

                            SqlCommand cmdDelete = new SqlCommand(DeleteQ, con);
                            cmdDelete.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted successfully!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetStudentRegNo();
                            ClearAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Student Index.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Student Index.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                isLoading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Please try again." + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void linklabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || string.IsNullOrWhiteSpace(e.KeyChar.ToString()) || e.KeyChar == '.') || e.KeyChar == 13;
        }

        void TxtNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == 8 || e.KeyChar == '.' || e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == 'v' || e.KeyChar == 'V') || e.KeyChar == 13;
        }

        private void ClearAll()
        {
            cmbBoxRegNo.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            dateTimeDOB.Text = DateTime.Today.ToString();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobilePhone.Text = "";
            txtHomePhone.Text = "";
            txtParentName.Text = "";
            txtNIC.Text = "";
            txtContactNumber.Text = "";
        }

        private void SetMyCustomFormat()
        {
            dateTimeDOB.MaxDate = DateTime.Today;
            dateTimeDOB.Format = DateTimePickerFormat.Custom;
            dateTimeDOB.CustomFormat = "dd/MM/yyyy";
            dateTimeDOB.MinDate = new DateTime(DateTime.Today.Year - 20, 1, 1);
            dateTimeDOB.Text = DateTime.Today.ToString();
        }

        private void GetStudentRegNo() {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT regNo FROM Registration ORDER BY regNo DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBoxRegNo.DataSource = dt;
                cmbBoxRegNo.DisplayMember = "regNo";
                cmbBoxRegNo.ValueMember = "regNo";
            }
            catch (Exception ex )
            {
                MessageBox.Show("Something went worng. Please try again." +ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean CheckStudnetExist(String regNo) {
            try
            {
                string checkQ = "SELECT * FROM Registration WHERE regNo = '" + regNo + "'";
                SqlCommand checkCMD = new SqlCommand(checkQ, con);
                SqlDataReader checkRDR = checkCMD.ExecuteReader();

                if (checkRDR.HasRows)
                {
                    int x = 0;
                    while (checkRDR.Read())
                    {
                        if (x == 0)
                        {
                            checkRDR.Close();
                            return true;
                        }
                        x++;
                    }
                }
                checkRDR.Close();
                return false;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
