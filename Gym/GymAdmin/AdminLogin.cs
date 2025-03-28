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
            this.WindowState = FormWindowState.Maximized;
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

                // Navigate to the admin dashboard
                AdminDashboard adminDashboard = new AdminDashboard(); 
                adminDashboard.Show();
                this.Hide(); 
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

            // Disable login button until the user enters new data
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
        txtUsername.BackColor = Color.LightCoral; 
    }
    else
    {
        // Reset the background color if the input is valid
        txtUsername.BackColor = Color.White;
    }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Check if password TextBox is empty
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // If empty, disable the login button
                Login_Button.Enabled = false; 
            }
            else
            {
                // If not empty, enable the login button
                Login_Button.Enabled = true;
            }

            // Optional: Provide feedback on password strength
            if (txtPassword.Text.Length < 6)
            {
                // If the password is less than 6 characters,Red background for weak password
                txtPassword.BackColor = Color.LightCoral; 
            }
            else
            {
                // Reset the background color if the input is valid
                txtPassword.BackColor = Color.White; 
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
