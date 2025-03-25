using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting logic
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting logic
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle list box selection changes
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Optional: Handle numeric input changes
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes (e.g., username input)
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes (e.g., password input)
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes (e.g., confirm password input)
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to Login Page when the link is clicked
            userlogin loginForm = new userlogin();
            loginForm.Show();
            this.Hide();
        }

        // Sign Up Button Click Event
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string username = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            // Check if the username or password is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check for password complexity (optional)
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Optionally, check for other criteria like special characters, etc.
            // For example: you can use regular expressions for stronger password checks

            // Save the user credentials here (Database or file storage can be used, for now, just a success message)
            // In a real app, save the username and password to a secure storage (e.g., database, or hashed password)

            MessageBox.Show("Sign Up Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Navigate to login page
            userlogin loginForm = new userlogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
