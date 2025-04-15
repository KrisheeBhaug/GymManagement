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
    public partial class memberClassControl: UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True";

        public memberClassControl()
        {
            InitializeComponent();
            LoadTrainerNames(); // Populate trainer dropdown
        }
        private void LoadTrainerNames()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT TrainerName FROM TrainerData";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["TrainerName"].ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //classid
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //classname
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trainer name appear in dropdown from TrainerData table
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //class duration
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //classcategory
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //claas location
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //classmax capacity
        }

        // search class based on class id, class name and trainer name
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT c.ClassID, c.ClassName, t.TrainerName AS Trainer, c.Duration, 
                   c.Location, c.MaxCapacity, c.Category, c.ClassStatus
            FROM Classes c
            INNER JOIN TrainerData t ON c.TrainerID = t.TrainerID
            WHERE 
                (@ClassID IS NULL OR c.ClassID = @ClassID) AND 
                (@ClassName IS NULL OR c.ClassName LIKE '%' + @ClassName + '%') AND 
                (@Trainer IS NULL OR t.TrainerName = @Trainer)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassID", string.IsNullOrEmpty(textBox1.Text) ? (object)DBNull.Value : int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@ClassName", string.IsNullOrEmpty(textBox2.Text) ? (object)DBNull.Value : textBox2.Text);
                cmd.Parameters.AddWithValue("@Trainer", comboBox1.SelectedItem == null ? (object)DBNull.Value : comboBox1.SelectedItem.ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No matching classes found.");
                    ClearFields(); 
                }
                else
                {
                    // Automatically fill the form fields with the first result
                    DataRow row = dt.Rows[0];
                    textBox1.Text = row["ClassID"].ToString();
                    textBox2.Text = row["ClassName"].ToString();
                    comboBox1.Text = row["Trainer"].ToString();
                    comboBox3.Text = row["Duration"].ToString();
                    textBox4.Text = row["Location"].ToString();
                    textBox5.Text = row["MaxCapacity"].ToString();
                    comboBox2.Text = row["Category"].ToString();
                }
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();
            comboBox2.SelectedIndex = -1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Join Class
            UpdateClassStatus(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Leave Class
            UpdateClassStatus(false);
        }


        private void UpdateClassStatus(bool join)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a class first.");
                return;
            }

            int classId = int.Parse(textBox1.Text);

            // Check if the class exists in the database
            if (!ClassExists(classId))
            {
                MessageBox.Show("The class you are trying to join/leave does not exist.");
                return;
            }

            // Proceed to join or leave the class
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Classes SET ClassStatus = @Status WHERE ClassID = @ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Update with 1 for 'Joint' and 0 for 'Not Joint'
                cmd.Parameters.AddWithValue("@Status", join ? "Joint" : "NotJoint");
                cmd.Parameters.AddWithValue("@ClassID", classId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(join ? "Joined the class." : "Left the class.");
            button1.PerformClick(); // Refresh
        }

        private bool ClassExists(int classId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Classes WHERE ClassID = @ClassID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ClassID", classId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Return true if class exists, false otherwise
            }
        }

        //datagrid view for table display
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ClassID"].Value.ToString();
                textBox2.Text = row.Cells["ClassName"].Value.ToString();
                comboBox1.Text = row.Cells["Trainer"].Value.ToString();
                comboBox3.Text = row.Cells["Duration"].Value.ToString();
                textBox4.Text = row.Cells["Location"].Value.ToString();
                textBox5.Text = row.Cells["MaxCapacity"].Value.ToString();
                comboBox2.Text = row.Cells["Category"].Value.ToString();

                // Set ClassStatus based on the numeric value
                string classStatus = row.Cells["ClassStatus"].Value.ToString();
        
            }
        }
    }
}
