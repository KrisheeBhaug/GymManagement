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
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadAdminCredentials(); // Load credentials into the hash table
        }

        private void LoadAdminCredentials()
        {
            adminCredentials = new HashTable(100); // Initialize hash table with a size of 100

            // Sample data from database (replace with actual data retrieval if needed)
            adminCredentials.Add("admin1", "password1");
            adminCredentials.Add("admin2", "password2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the username and password from text boxes
            string username = txtUsername.Text.ToLower(); // Normalize to lower case
            string password = txtPassword.Text;

            // Validate credentials using the hash table
            if (adminCredentials.Contains(username, password))
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

            // Disable login button until new input is provided 
            Login_Button.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Check if the username TextBox is empty
            Login_Button.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text);
            txtUsername.BackColor = txtUsername.Text.Length < 3 ? Color.LightCoral : Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Check if password TextBox is empty
            Login_Button.Enabled = !string.IsNullOrWhiteSpace(txtPassword.Text);
            txtPassword.BackColor = txtPassword.Text.Length < 6 ? Color.LightCoral : Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Handle link label click event if needed
        }

            private void AdminLogin_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
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