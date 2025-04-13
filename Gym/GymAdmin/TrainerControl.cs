using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace GymAdmin
{
    public partial class TrainerControl : UserControl
    {
        public TrainerControl()
        {
            InitializeComponent();
        }

        private void TrainerControl_Load(object sender, EventArgs e)
        {
            // get trainer certification data from TrainerCertification text box
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the TrainerID from textBox1 

        }
        

      
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Trainer Mobile Number
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TrainerName
        }

        private void txtTrainerEmail_TextChanged(object sender, EventArgs e)
        {
            //TrainerEmaill 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //JoinDate
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //Availabledays
        }

        //Add Trainer data
        private void button1_Click(object sender, EventArgs e)
        {
            string trainerName = TrainerName.Text.Trim();
            string mobileNumber = txtMobileNumber.Text.Trim();
            string trainerEmail = TrainerEmail.Text.Trim();
            DateTime joinDate = dateTimePicker1.Value;
            string availableDays = textBox8.Text.Trim();

            // Validate all required fields
            if (string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("The 'Trainer Name' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(mobileNumber))
            {
                MessageBox.Show("The 'Mobile Number' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(trainerEmail))
            {
                MessageBox.Show("The 'Email' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(availableDays))
            {
                MessageBox.Show("The 'Available Days' field should not be empty.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "INSERT INTO TrainerData (TrainerName, TrainerMobileNumber, TrainerEmail, TrainerJoinDate, TrainerAvailableDays) VALUES (@TrainerName, @TrainerMobileNumber, @TrainerEmail, @TrainerJoinDate, @TrainerAvailableDays)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerName", trainerName);
                        command.Parameters.AddWithValue("@TrainerMobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@TrainerEmail", trainerEmail);
                        command.Parameters.AddWithValue("@TrainerJoinDate", joinDate);
                        command.Parameters.AddWithValue("@TrainerAvailableDays", availableDays);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trainer added successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add trainer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        //Update Trainer data
        private void button2_Click(object sender, EventArgs e)
        {
            string trainerID = TrainerID.Text.Trim();
            string trainerName = TrainerName.Text.Trim();
            string mobileNumber = txtMobileNumber.Text.Trim();
            string trainerEmail = TrainerEmail.Text.Trim();
            DateTime joinDate = dateTimePicker1.Value;
            string availableDays = textBox8.Text.Trim();

            if (string.IsNullOrEmpty(trainerID))
            {
                MessageBox.Show("The 'Trainer ID' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("The 'Trainer Name' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(mobileNumber))
            {
                MessageBox.Show("The 'Mobile Number' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(trainerEmail))
            {
                MessageBox.Show("The 'Email' field should not be empty.");
                return;
            }

            if (string.IsNullOrEmpty(availableDays))
            {
                MessageBox.Show("The 'Available Days' field should not be empty.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "UPDATE TrainerData SET TrainerName = @TrainerName, TrainerMobileNumber = @TrainerMobileNumber, TrainerEmail = @TrainerEmail, TrainerJoinDate = @TrainerJoinDate, TrainerAvailableDays = @TrainerAvailableDays WHERE TrainerID = @TrainerID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", trainerID);
                        command.Parameters.AddWithValue("@TrainerName", trainerName);
                        command.Parameters.AddWithValue("@TrainerMobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@TrainerEmail", trainerEmail);
                        command.Parameters.AddWithValue("@TrainerJoinDate", joinDate);
                        command.Parameters.AddWithValue("@TrainerAvailableDays", availableDays);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trainer details updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update trainer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string trainerID = TrainerID.Text.Trim();

            if (string.IsNullOrEmpty(trainerID))
            {
                MessageBox.Show("TrainerID is required to delete.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "DELETE FROM TrainerData WHERE TrainerID = @TrainerID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", trainerID);

                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Trainer deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete trainer.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string trainerID = TrainerID.Text.Trim();
            string trainerName = TrainerName.Text.Trim();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "SELECT * FROM TrainerData WHERE (@TrainerID IS NULL OR TrainerID LIKE @TrainerID) AND (@TrainerName IS NULL OR TrainerName LIKE @TrainerName)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", string.IsNullOrEmpty(trainerID) ? (object)DBNull.Value : "%" + trainerID + "%");
                        command.Parameters.AddWithValue("@TrainerName", string.IsNullOrEmpty(trainerName) ? (object)DBNull.Value : "%" + trainerName + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Assuming you have a DataGridView named dataGridView1
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}