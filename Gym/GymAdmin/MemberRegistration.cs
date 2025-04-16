using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace GymAdmin
{
    public partial class MemberRegistration : Form
    {
        public MemberRegistration()
        {
            InitializeComponent();
        }

        // Sign Up button event handler—this inserts only the fields from the registration form.
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form controls.
            string firstName = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();
            string gender = radioButton1.Checked ? "Male" : "Female";
            DateTime dob = dateTimePicker1.Value.Date;
            DateTime joinDate = dateTimePicker2.Value.Date;
            string gymTime = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;
            string address = !string.IsNullOrWhiteSpace(richTextBox1.Text) ? richTextBox1.Text : string.Empty;
            string email = textBox3.Text.Trim();
            string mobile = textBox4.Text.Trim();
            string membershipType = comboBox2.SelectedItem != null ? comboBox2.SelectedItem.ToString() : string.Empty;

            // Basic required field validations.
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(mobile))
            {
                MessageBox.Show("Please fill in all the required fields: First Name, Surname, Email, Mobile.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare the SQL INSERT query—only include the columns you want to populate.
            string query = @"
                INSERT INTO MemberData (
                    MemberFirstName,
                    MemberSurname,
                    MemberGender,
                    MemberDOB,
                    MemberJoinDate,
                    MemberGymTime,
                    MemberAddress,
                    MemberEmail,
                    MemberMobile,
                    MemberMembershipType
                ) VALUES (
                    @FirstName,
                    @Surname,
                    @Gender,
                    @DOB,
                    @JoinDate,
                    @GymTime,
                    @Address,
                    @Email,
                    @Mobile,
                    @MembershipType
                );";

            // Use your connection string (adjust as necessary).
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-ENGKM2N;Initial Catalog=GymManagementDB;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters to avoid SQL injection.
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@JoinDate", joinDate);

                    // Parse gym time if provided; if not, pass DBNull.
                    if (!string.IsNullOrEmpty(gymTime))
                    {
                        // Try parsing the gym time string to a TimeSpan.
                        if (TimeSpan.TryParse(gymTime, out TimeSpan gymTimeValue))
                        {
                            cmd.Parameters.AddWithValue("@GymTime", gymTimeValue);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@GymTime", DBNull.Value);
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@GymTime", DBNull.Value);
                    }

                    // Address—if empty, use DBNull.
                    if (!string.IsNullOrEmpty(address))
                        cmd.Parameters.AddWithValue("@Address", address);
                    else
                        cmd.Parameters.AddWithValue("@Address", DBNull.Value);

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Mobile", mobile);

                    // Membership type—if empty, use DBNull.
                    if (!string.IsNullOrEmpty(membershipType))
                        cmd.Parameters.AddWithValue("@MembershipType", membershipType);
                    else
                        cmd.Parameters.AddWithValue("@MembershipType", DBNull.Value);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Reset button event handler—clears all the form fields.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        // Resets or clears all input controls on the registration form.
        private void ResetFields()
        {
            textBox1.Clear();                // Clear First Name.
            textBox2.Clear();                // Clear Surname.
            radioButton1.Checked = false;    // Uncheck Male.
            radioButton2.Checked = false;    // Uncheck Female.
            dateTimePicker1.Value = DateTime.Now; // Reset DOB to current date.
            dateTimePicker2.Value = DateTime.Now; // Reset Join Date to current date.
            comboBox1.SelectedIndex = -1;    // Reset Gym Time selection.
            richTextBox1.Clear();            // Clear Address.
            textBox3.Clear();                // Clear Email.
            textBox4.Clear();                // Clear Mobile.
            comboBox2.SelectedIndex = -1;    // Reset Membership Type.
        }

        // (Optional) LinkLabel event handler to go to the Login form.
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMember loginForm = new LoginMember();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            this.Close();
        }
    }
}