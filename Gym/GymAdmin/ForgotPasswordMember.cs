using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class ForgotPasswordMember : Form
    {
        public ForgotPasswordMember()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            // Get the email entered by the user.
            string username = txtUsername.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;

            // Validate input: ensure email is provided.
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Read the connection string from the configuration.
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to retrieve the password using the email and date of birth
                    string query = "SELECT MemberPassword FROM MemberData WHERE MemberEmail = @Email AND MemberDOB = @DOB";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set parameters using email and dob.
                        cmd.Parameters.AddWithValue("@Email", username);
                        cmd.Parameters.AddWithValue("@DOB", dob);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string password = result.ToString();
                            MessageBox.Show($"Your password is: {password}", "Password Retrieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the forgot password form
                        }
                        else
                        {
                            MessageBox.Show("No matching user found. Please check your inputs.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}