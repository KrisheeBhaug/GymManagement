using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                Console.WriteLine("Text Changed:" + tb.Text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                Console.WriteLine("Text Changed:" + tb.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametextbox.Text; // Username input
            string password = textBox4.Text; // Password input

            // Hardcoded user credentials for testing
            Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "admin", "password123" },
                { "user1", "pass123" },
                { "testuser", "test123" }
            };

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!users.ContainsKey(username))
            {
                MessageBox.Show("Account does not exist. Please register first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (users[username] != password)
            {
                MessageBox.Show("Invalid password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide login form

                // Open another form (Example: Dashboard)
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp(); 
            signUpForm.Show(); 
            this.Hide();
        }
    }
}
