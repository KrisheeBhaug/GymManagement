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
            string username = txtUsername.Text.Trim();
            DateTime dob = dtpDOB.Value.Date;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT AdminPassword FROM AdminData WHERE AdminName = @username AND AdminDOB = @dob";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string password = result.ToString();
                            MessageBox.Show($"Your password is: {password}", "Password Retrieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // close the forgot password form
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