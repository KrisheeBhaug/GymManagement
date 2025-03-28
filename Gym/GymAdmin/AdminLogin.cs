using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class AdminLogin: Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from the text boxes
            string username = txtUsername.Text; 
            string password = txtPassword.Text; 

            // Define the expected admin credentials
            string adminUsername = "admin"; 
            string adminPassword = "password"; 

            // Validate the credentials
            if (username == adminUsername && password == adminPassword)
            {
                // Successful login
                MessageBox.Show("Login successful! Welcome, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to the admin dashboard or main application form
                AdminDashboard adminDashboard = new AdminDashboard(); // Assuming you have an AdminDashboard form
                adminDashboard.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                // Failed login
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the username and password TextBoxes
            txtUsername.Clear(); 
            txtPassword.Clear();

            // Optionally, disable the login button until the user enters new data
            Login_Button.Enabled = false; 
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                // Check if the username TextBox is empty
    if (string.IsNullOrWhiteSpace(txtUsername.Text))
    {
                // If empty, disable the login button
                Login_Button.Enabled = false;
    }
    else
    {
                // If not empty, enable the login button
                Login_Button.Enabled = true;
    }

    //provide feedback on username criteria
    if (txtUsername.Text.Length < 3)
    {
        // If the username is less than 3 characters, Change txt box colour
        txtUsername.BackColor = Color.LightCoral; // Red background for invalid input
    }
    else
    {
        // Reset the background color if the input is valid
        txtUsername.BackColor = Color.White;
    }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Check if the password TextBox is empty
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // If empty, disable the login button
                Login_Button.Enabled = false; // Assuming button1 is your login button
            }
            else
            {
                // If not empty, enable the login button
                Login_Button.Enabled = true;
            }

            // Optional: Provide feedback on password strength
            if (txtPassword.Text.Length < 6)
            {
                // If the password is less than 6 characters, you can show a message or change the UI
                txtPassword.BackColor = Color.LightCoral; // Red background for weak password
            }
            else
            {
                // Reset the background color if the input is valid
                txtPassword.BackColor = Color.White; // Default background color
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
