using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymAdmin;

namespace GymAdmin
{
    public partial class LoginMember: Form
    {
        public LoginMember()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Hide password on form load
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Member Registration form
            MemberRegistration registerForm = new MemberRegistration();
            registerForm.ShowDialog();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the ForgotPasswordMember form
            ForgotPasswordMember forgotForm = new ForgotPasswordMember();
            forgotForm.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //username text box
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //password text box
        }

        //login button
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT MemberFirstName, MemberEmail FROM MemberData WHERE MemberEmail = @Email AND MemberPassword = @Password";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string firstName = reader["MemberFirstName"].ToString();
                        MessageBox.Show($"Welcome, {firstName}!");

                        // Open the MemberDashboard form
                        MemberDashboard dashboardForm = new MemberDashboard();
                        dashboardForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        //show password
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password
            }

        }
    }
}
