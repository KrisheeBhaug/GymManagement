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

        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string trainerID = TrainerID.Text.Trim();
            string trainerName = TrainerName.Text.Trim();
            string mobileNumber = MobileNumber.Text.Trim();
            string trainerEmail = TrainerEmail.Text.Trim();
            DateTime joinDate = JoinDate.Value;
            string availableDays = TrainerAvailableDays.Text.Trim();

            if (string.IsNullOrEmpty(trainerID) || string.IsNullOrEmpty(trainerName))
            {
                MessageBox.Show("TrainerID and TrainerName are required.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "INSERT INTO TrainerData (TrainerID, TrainerName, MobileNumber, TrainerEmail, JoinDate, AvailableDays) VALUES (@TrainerID, @TrainerName, @MobileNumber, @TrainerEmail, @JoinDate, @AvailableDays)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", trainerID);
                        command.Parameters.AddWithValue("@TrainerName", trainerName);
                        command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@TrainerEmail", trainerEmail);
                        command.Parameters.AddWithValue("@JoinDate", joinDate);
                        command.Parameters.AddWithValue("@AvailableDays", availableDays);

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


        private void button2_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string trainerID = TrainerID.Text.Trim();
            string trainerName = TrainerName.Text.Trim();
            string mobileNumber = MobileNumber.Text.Trim();
            string trainerEmail = TrainerEmail.Text.Trim();
            DateTime joinDate = JoinDate.Value;
            string availableDays = TrainerAvailableDays.Text.Trim();

            if (string.IsNullOrEmpty(trainerID))
            {
                MessageBox.Show("TrainerID is required.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "UPDATE TrainerData SET TrainerName = @TrainerName, MobileNumber = @MobileNumber, TrainerEmail = @TrainerEmail, JoinDate = @JoinDate, AvailableDays = @AvailableDays WHERE TrainerID = @TrainerID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", trainerID);
                        command.Parameters.AddWithValue("@TrainerName", trainerName);
                        command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                        command.Parameters.AddWithValue("@TrainerEmail", trainerEmail);
                        command.Parameters.AddWithValue("@JoinDate", joinDate);
                        command.Parameters.AddWithValue("@AvailableDays", availableDays);

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