using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class AdminLogin : Form
    {
        private HashTable adminCredentials;

        public AdminLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadAdminCredentials(); // Load credentials into the hash table
        }

        private void LoadAdminCredentials()
        {
            adminCredentials = new HashTable(100); // Initialize hash table with a size of 100

            // Sample data from database
            adminCredentials.Add("admin1", "password1");
            adminCredentials.Add("admin2", "password2");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from text box
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate credentials using the hash table
            if (adminCredentials.Contains(username, password))
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the username and password TextBoxes
            txtUsername.Clear();
            txtPassword.Clear();

            // Disable the login button until new input is provided 
            Login_Button.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
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

            if (txtUsername.Text.Length < 3)
            {
                // If the username is less than 3 characters, change txt box colour
                txtUsername.BackColor = Color.LightCoral;
            }
            else
            {
                // Reset the background color if the input is valid
                txtUsername.BackColor = Color.White;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
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

            if (txtPassword.Text.Length < 6)
            {
                txtPassword.BackColor = Color.LightCoral;
            }
            else
            {
                // Reset the background color if the input is valid
                txtPassword.BackColor = Color.White;
            }
        }


        private void AdminLogin_Load(object sender, EventArgs e)
        {
            Login_Button.Enabled = true;
           
        }
    }

    // HashTable class implementation
    public class HashTable
    {
        private List<KeyValuePair<string, string>>[] buckets;
        private int size;

        public HashTable(int size)
        {
            this.size = size;
            buckets = new List<KeyValuePair<string, string>>[size];
        }

        private int Hash(string key)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }

        public void Add(string username, string password)
        {
            int index = Hash(username);
            if (buckets[index] == null)
            {
                buckets[index] = new List<KeyValuePair<string, string>>();
            }
            buckets[index].Add(new KeyValuePair<string, string>(username, password));
        }

        public bool Contains(string username, string password)
        {
            int index = Hash(username);
            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key == username && pair.Value == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
