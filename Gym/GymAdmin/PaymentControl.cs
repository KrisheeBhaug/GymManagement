using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace GymAdmin
{
    public partial class PaymentControl: UserControl
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True";
        public PaymentControl()
        {
            InitializeComponent();
        }

        private void PaymentControl_Load(object sender, EventArgs e)
        {
            LoadPaymentData(); 
        }

        private void LoadPaymentData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PaymentData";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid view 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //full name text box
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //memebrship type drop down
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //payment method drop down
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //payment id text box
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //amount text box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add payment
            // Check if the required fields are filled in
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in the required fields.");
                return;
            }

            // Assuming MemberEmail is pre-set or already known and the correct full name is entered
            string fullName = textBox1.Text; // Payment full name
            string membership = comboBox1.Text; // Selected membership type
            string paymentMethod = comboBox2.Text; // Selected payment method
            decimal amount = Convert.ToDecimal(textBox4.Text); // Payment amount

            // Get the email of the member, for instance, using a predefined method (not from the current form).
            string memberEmail = GetMemberEmailForPayment(fullName); // Implement this method to fetch the email.

            if (string.IsNullOrEmpty(memberEmail))
            {
                MessageBox.Show("Member not found or invalid member name.");
                return;
            }

            // Now insert the data into PaymentData with the existing MemberEmail
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO PaymentData (MemberEmail, PaymentFullName, PaymentMembership, PaymentMethod, PaymentAmount)
                         VALUES (@memberEmail, @fullname, @membership, @method, @amount)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@memberEmail", memberEmail); // This is fetched from GetMemberEmailForPayment
                cmd.Parameters.AddWithValue("@fullname", fullName); // Full name entered
                cmd.Parameters.AddWithValue("@membership", membership); // Selected membership
                cmd.Parameters.AddWithValue("@method", paymentMethod); // Selected payment method
                cmd.Parameters.AddWithValue("@amount", amount); // Payment amount

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Payment Added Successfully.");
                LoadPaymentData(); // Reload data in the grid
                ClearForm(); // Clear the form for new entry
            }
        }

        // Helper method to fetch the MemberEmail based on the PaymentFullName
        private string GetMemberEmailForPayment(string fullName)
        {
            string memberEmail = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Split the fullName into first and last name.
                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string surname = nameParts.Length > 1 ? nameParts[1] : string.Empty;

                // Query to fetch email by first name or surname
                string query = "SELECT MemberEmail FROM MemberData WHERE MemberFirstName = @firstName OR MemberSurname = @surname";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@surname", surname);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    memberEmail = result.ToString();
                }
            }

            return memberEmail;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Delete payment by PaymentID
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Enter PaymentID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PaymentData WHERE PaymentID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox3.Text));
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Payment Deleted Successfully.");
                    LoadPaymentData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("PaymentID not found.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Search by MemberEmail (assuming textBox1 contains the MemberEmail)
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter Name to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PaymentData WHERE PaymentFullName LIKE @name"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", "%" + textBox1.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Populate the DataGridView with the results
                dataGridView1.DataSource = table;

                // Check if any rows were returned
                if (table.Rows.Count > 0)
                {
                    // If a row is found, populate the textboxes and dropdowns
                    DataRow row = table.Rows[0];

                    // Set the values for the textboxes
                    textBox3.Text = row["PaymentID"].ToString();
                    textBox1.Text = row["PaymentFullName"].ToString();
                    textBox4.Text = row["PaymentAmount"].ToString();

                    // Set the dropdown selections
                    comboBox1.Text = row["PaymentMembership"].ToString();
                    comboBox2.Text = row["PaymentMethod"].ToString();
                }
                else
                {
                    MessageBox.Show("No records found.");
                }
            }
        }
        private void ClearForm()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //print payment 

            string paymentId = textBox3.Text;
            string fullName = textBox1.Text;
            string email = textBox1.Text; 
            string membership = comboBox1.SelectedItem?.ToString();
            string method = comboBox2.SelectedItem?.ToString();
            string amount = textBox4.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            
            string receipt = $"--- Gym Payment Receipt ---\n" +
                             $"Payment ID: {paymentId}\n" +
                             $"Full Name: {fullName}\n" +
                             $"Email: {email}\n" +
                             $"Membership Type: {membership}\n" +
                             $"Payment Method: {method}\n" +
                             $"Amount Paid: £{amount}\n" +
                             $"Payment Date: {date}\n" +
                             $"---------------------------\n" +
                             $"Thank you for your payment!";

            // Create a new form to display the receipt
            Form receiptForm = new Form();
            receiptForm.Text = "Payment Receipt";
            receiptForm.Size = new Size(400, 300);
            receiptForm.StartPosition = FormStartPosition.CenterScreen;

      // Create a TextBox to display the receipt
            TextBox receiptTextBox = new TextBox();
            receiptTextBox.Multiline = true;
            receiptTextBox.ReadOnly = true;
            receiptTextBox.Dock = DockStyle.Fill;
            receiptTextBox.Text = receipt;
            receiptTextBox.Font = new Font("Consolas", 10); // Use a fixed-width font for clarity
            receiptTextBox.ScrollBars = ScrollBars.Vertical;

            // Add the TextBox to the form
            receiptForm.Controls.Add(receiptTextBox);

            // Show the form as a dialog
            receiptForm.ShowDialog();

        }
    }
}
