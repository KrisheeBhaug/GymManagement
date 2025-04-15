using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GymAdmin
{
    public partial class ClassControl: UserControl
    {
        public ClassControl()
        {

            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TrainerName FROM TrainerData", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox1.Items.Clear(); // clear previous items

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["TrainerName"].ToString());
                }

                reader.Close();
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Max Capacity
        }

        //AddClass
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Validate ClassID
                if (!int.TryParse(textBox1.Text, out int classId))
                {
                    MessageBox.Show("Please enter a valid Class ID (integer).");
                    return;
                }

                // Check if ClassID already exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Classes WHERE ClassID = @id", conn);
                checkCmd.Parameters.AddWithValue("@id", classId);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Class ID already exists!");
                    return;
                }

                // Validate MaxCapacity
                if (!int.TryParse(textBox5.Text, out int maxCapacity))
                {
                    MessageBox.Show("Please enter a valid Max Capacity (integer).");
                    return;
                }

                // Get TrainerID from TrainerName
                SqlCommand trainerCmd = new SqlCommand("SELECT TrainerID FROM TrainerData WHERE TrainerName = @name", conn);
                trainerCmd.Parameters.AddWithValue("@name", comboBox1.Text);
                object result = trainerCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Trainer not found!");
                    return;
                }
                int trainerId = (int)result;

                // Enable IDENTITY_INSERT
                SqlCommand enableIdentityInsert = new SqlCommand("SET IDENTITY_INSERT Classes ON", conn);
                enableIdentityInsert.ExecuteNonQuery();

                // INSERT command including ClassID
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO Classes 
            (ClassID, ClassName, TrainerID, Duration, Location, MaxCapacity, Category) 
            VALUES (@id, @name, @trainerId, @duration, @loc, @cap, @cat)", conn);

                cmd.Parameters.AddWithValue("@id", classId);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@trainerId", trainerId);
                cmd.Parameters.AddWithValue("@duration", comboBox3.Text);
                cmd.Parameters.AddWithValue("@loc", textBox4.Text);
                cmd.Parameters.AddWithValue("@cap", maxCapacity);
                cmd.Parameters.AddWithValue("@cat", comboBox2.Text);

                cmd.ExecuteNonQuery();

                // Disable IDENTITY_INSERT
                SqlCommand disableIdentityInsert = new SqlCommand("SET IDENTITY_INSERT Classes OFF", conn);
                disableIdentityInsert.ExecuteNonQuery();

                MessageBox.Show("Class added successfully!");
            }


        }

        private void ClassControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ClassID
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //ClassName
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TrainerName Make trainer names from trainer Data table apeear here
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClassDuration
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //ClassLocation  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Category
        }

        //updateclass
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Validate ClassID
                if (!int.TryParse(textBox1.Text, out int classId))
                {
                    MessageBox.Show("Please enter a valid Class ID (integer).");
                    return;
                }

                // Check if class exists
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Classes WHERE ClassID = @id", conn);
                checkCmd.Parameters.AddWithValue("@id", classId);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists == 0)
                {
                    MessageBox.Show("Class ID does not exist.");
                    return;
                }

                // Validate MaxCapacity
                if (!int.TryParse(textBox5.Text, out int maxCapacity))
                {
                    MessageBox.Show("Please enter a valid Max Capacity (integer).");
                    return;
                }

                // Get TrainerID from TrainerName
                SqlCommand trainerCmd = new SqlCommand("SELECT TrainerID FROM TrainerData WHERE TrainerName = @name", conn);
                trainerCmd.Parameters.AddWithValue("@name", comboBox1.Text);
                object result = trainerCmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Trainer not found!");
                    return;
                }
                int trainerId = (int)result;

                // Update query
                SqlCommand updateCmd = new SqlCommand(@"
            UPDATE Classes 
            SET ClassName = @name,
                TrainerID = @trainerId,
                Duration = @duration,
                Location = @loc,
                MaxCapacity = @cap,
                Category = @cat
            WHERE ClassID = @id", conn);

                updateCmd.Parameters.AddWithValue("@id", classId);
                updateCmd.Parameters.AddWithValue("@name", textBox2.Text);
                updateCmd.Parameters.AddWithValue("@trainerId", trainerId);
                updateCmd.Parameters.AddWithValue("@duration", comboBox3.Text);
                updateCmd.Parameters.AddWithValue("@loc", textBox4.Text);
                updateCmd.Parameters.AddWithValue("@cap", maxCapacity);
                updateCmd.Parameters.AddWithValue("@cat", comboBox2.Text);

                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Class updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //DeletedClass
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //SearchClass
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview
        }
    }
}
