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
    public partial class EquipmentControl: UserControl
    {
        public EquipmentControl()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //equipment name text box
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //equipment ID text box
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Description of equipment text box
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Category of equipment
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //condition of equipment text box
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //quantity of equipment text box
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Location of equipment text box
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Maintenance of equipment text box
        }

        //search equipment
        private void button4_Click(object sender, EventArgs e)
        {
            {
                string equipmentID = textBox2.Text.Trim();
                string equipmentName = textBox1.Text.Trim();
                string equipmentCategory = comboBox1.SelectedItem?.ToString();
                string equipmentMaintenance = comboBox2.SelectedItem?.ToString();

                // Create a base query
                string query = "SELECT * FROM EquipmentData WHERE 1=1";

                // List of parameters to add to the query
                List<SqlParameter> parameters = new List<SqlParameter>();

                // Add conditions to the query based on user input
                if (!string.IsNullOrEmpty(equipmentID))
                {
                    query += " AND EquipmentID = @EquipmentID";
                    parameters.Add(new SqlParameter("@EquipmentID", equipmentID));
                }

                if (!string.IsNullOrEmpty(equipmentName))
                {
                    query += " AND EquipmentName LIKE @EquipmentName";
                    parameters.Add(new SqlParameter("@EquipmentName", "%" + equipmentName + "%"));
                }

                if (!string.IsNullOrEmpty(equipmentCategory))
                {
                    query += " AND EquipmentCategory = @EquipmentCategory";
                    parameters.Add(new SqlParameter("@EquipmentCategory", equipmentCategory));
                }

                if (!string.IsNullOrEmpty(equipmentMaintenance))
                {
                    query += " AND EquipmentMaintenance = @EquipmentMaintenance";
                    parameters.Add(new SqlParameter("@EquipmentMaintenance", equipmentMaintenance));
                }

                // Connection string
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the result to the DataGridView
                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            textBox2.Text = row["EquipmentID"].ToString(); // Show the EquipmentID in the textBox2
                            textBox1.Text = row["EquipmentName"].ToString();
                            richTextBox1.Text = row["EquipmentDescription"].ToString();
                            comboBox1.SelectedItem = row["EquipmentCategory"].ToString();
                            textBox3.Text = row["EquipmentCondition"].ToString();
                            textBox4.Text = row["EquipmentQuantity"].ToString();
                            textBox5.Text = row["EquipmentLocation"].ToString();
                            comboBox2.SelectedItem = row["EquipmentMaintenance"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No matching equipment found.");
                            dataGridView1.DataSource = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // Add equipment
        private void button1_Click(object sender, EventArgs e)
        {
            string equipmentName = textBox1.Text.Trim();
            string equipmentID = textBox2.Text.Trim(); 
            string equipmentDescription = richTextBox1.Text.Trim();
            string equipmentCategory = comboBox1.SelectedItem?.ToString();
            string equipmentCondition = textBox3.Text.Trim();
            string equipmentQuantity = textBox4.Text.Trim();
            string equipmentLocation = textBox5.Text.Trim();
            string equipmentMaintenance = comboBox2.SelectedItem?.ToString();


            // Validation checks
            if (string.IsNullOrEmpty(equipmentName) || string.IsNullOrEmpty(equipmentQuantity) || string.IsNullOrEmpty(equipmentCondition))
            {
                MessageBox.Show("Name, Quantity, and Condition are required fields.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "INSERT INTO EquipmentData (EquipmentName, EquipmentDescription, EquipmentCategory, EquipmentCondition, EquipmentQuantity, EquipmentLocation, EquipmentMaintenance) " +
                           "VALUES (@EquipmentName, @EquipmentDescription, @EquipmentCategory, @EquipmentCondition, @EquipmentQuantity, @EquipmentLocation, @EquipmentMaintenance)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                cmd.Parameters.AddWithValue("@EquipmentDescription", string.IsNullOrEmpty(equipmentDescription) ? (object)DBNull.Value : equipmentDescription);
                cmd.Parameters.AddWithValue("@EquipmentCategory", string.IsNullOrEmpty(equipmentCategory) ? (object)DBNull.Value : equipmentCategory);
                cmd.Parameters.AddWithValue("@EquipmentCondition", equipmentCondition);
                cmd.Parameters.AddWithValue("@EquipmentQuantity", equipmentQuantity);
                cmd.Parameters.AddWithValue("@EquipmentLocation", string.IsNullOrEmpty(equipmentLocation) ? (object)DBNull.Value : equipmentLocation);
                cmd.Parameters.AddWithValue("@EquipmentMaintenance", string.IsNullOrEmpty(equipmentMaintenance) ? (object)DBNull.Value : equipmentMaintenance);
   



                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Equipment added successfully." : "Failed to add equipment.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       

        // Update equipment with ID validation
        private void button2_Click(object sender, EventArgs e)
        {
            string equipmentID = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(equipmentID))
            {
                MessageBox.Show("Please provide Equipment ID to update.");
                return;
            }

            // Validate that the EquipmentID is not already used by another record
            if (IsEquipmentIDExists(equipmentID))
            {
                MessageBox.Show("Equipment ID already exists. Please provide a unique ID.");
                return;
            }

            string equipmentName = textBox1.Text.Trim();
            string equipmentDescription = richTextBox1.Text.Trim();
            string equipmentCategory = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;
            string equipmentCondition = textBox3.Text.Trim();
            string equipmentQuantity = textBox4.Text.Trim();
            string equipmentLocation = textBox5.Text.Trim();
            string equipmentMaintenance = comboBox2.SelectedItem?.ToString();

            // Validation checks
            if (string.IsNullOrEmpty(equipmentName) || string.IsNullOrEmpty(equipmentCondition) || string.IsNullOrEmpty(equipmentQuantity))
            {
                MessageBox.Show("Name, Quantity, and Condition are required fields.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "UPDATE EquipmentData SET EquipmentName=@EquipmentName, EquipmentDescription=@EquipmentDescription, EquipmentCategory=@EquipmentCategory, " +
                           "EquipmentCondition=@EquipmentCondition, EquipmentQuantity=@EquipmentQuantity, EquipmentLocation=@EquipmentLocation, EquipmentMaintenance=@EquipmentMaintenance " +
                           "WHERE EquipmentID=@EquipmentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);
                cmd.Parameters.AddWithValue("@EquipmentName", equipmentName);
                cmd.Parameters.AddWithValue("@EquipmentDescription", equipmentDescription);
                cmd.Parameters.AddWithValue("@EquipmentCategory", equipmentCategory);
                cmd.Parameters.AddWithValue("@EquipmentCondition", equipmentCondition);
                cmd.Parameters.AddWithValue("@EquipmentQuantity", equipmentQuantity);
                cmd.Parameters.AddWithValue("@EquipmentLocation", equipmentLocation);
                cmd.Parameters.AddWithValue("@EquipmentMaintenance", string.IsNullOrEmpty(equipmentMaintenance) ? (object)DBNull.Value : equipmentMaintenance);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Equipment updated successfully." : "Update failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Method to check if the EquipmentID already exists in the database
        private bool IsEquipmentIDExists(string equipmentID)
        {
            string query = "SELECT COUNT(*) FROM EquipmentData WHERE EquipmentID=@EquipmentID";
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }


        //Delete equipment

        private void button3_Click(object sender, EventArgs e)
        {
            string equipmentID = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(equipmentID))
            {
                MessageBox.Show("Enter Equipment ID to delete.");
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GymDBConnection"].ConnectionString;
            string query = "DELETE FROM EquipmentData WHERE EquipmentID=@EquipmentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EquipmentID", equipmentID);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Equipment deleted successfully." : "No equipment found with this ID.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
