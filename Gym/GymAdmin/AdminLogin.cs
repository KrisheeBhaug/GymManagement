using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // Center the login panel
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

            // Mask password input with ●
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM AdminData WHERE AdminName = @username AND AdminPassword = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful! Welcome, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear fields
            txtUsername.Clear();
            txtPassword.Clear();

            // Reset colors
            txtUsername.BackColor = Color.LightYellow;
            txtPassword.BackColor = Color.LightYellow;

            Login_Button.Enabled = true; 

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        { 

            // Visual validation: highlight if too short
            if (txtUsername.Text.Length > 0 && txtUsername.Text.Length < 3)
                txtUsername.BackColor = Color.LightCoral;
            else
                txtUsername.BackColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Login_Button.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);

            if (txtPassword.Text.Length > 0 && txtPassword.Text.Length < 6)
                txtPassword.BackColor = Color.LightCoral;
            else
                txtPassword.BackColor = Color.White;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open Forgot Password form
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
        }
    }
}
