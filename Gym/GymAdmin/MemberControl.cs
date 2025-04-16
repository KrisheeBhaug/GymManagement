using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace GymAdmin
{
    public partial class MemberControl: UserControl
    {
        public MemberControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //firstname text box
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }



        //add button
        private void button1_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Checked ? "Male" : "Female";

            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True"))
            {
                string query = @"
            INSERT INTO MemberData (
                MemberFirstName, MemberSurname, MemberGender, MemberDOB,
                MemberJoinDate, MemberGymTime, MemberAddress, MemberEmail,
                MemberMobile, MemberMembershipType, MemberPassword,
                EmergencyContactName, EmergencyContactNumber,
                FitnessGoals, PersonalPreferences, ProfilePicture
            ) VALUES (
                @FirstName, @Surname, @Gender, @DOB,
                @JoinDate, @GymTime, @Address, @Email,
                @Mobile, @MembershipType, @Password,
                @EmergencyName, @EmergencyNumber,
                @Goals, @Preferences, @ProfilePic
            )";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Surname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker2.Value.Date);

                    // Optional parameters with null checks
                    DateTime selectedTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GymTime", (object)selectedTime.TimeOfDay);

                    cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(richTextBox1.Text) ? DBNull.Value : (object)richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox4.Text);
                    cmd.Parameters.AddWithValue("@MembershipType", comboBox2.SelectedItem != null ? (object)comboBox2.SelectedItem.ToString() : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Password", "defaultpass123"); 
                    cmd.Parameters.AddWithValue("@EmergencyName", DBNull.Value);
                    cmd.Parameters.AddWithValue("@EmergencyNumber", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Goals", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Preferences", DBNull.Value);
                    cmd.Parameters.AddWithValue("@ProfilePic", DBNull.Value); 

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member added successfully.");
              
                    ClearForm();

                }
            }
        }

        //update button
        private void button2_Click(object sender, EventArgs e)
        {
            string gender = radioButton1.Checked ? "Male" : "Female";

            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True"))
            {
                string query = @"
            UPDATE MemberData SET
                MemberFirstName = @FirstName,
                MemberSurname = @Surname,
                MemberGender = @Gender,
                MemberDOB = @DOB,
                MemberJoinDate = @JoinDate,
                MemberGymTime = @GymTime,
                MemberAddress = @Address,
                MemberMobile = @Mobile,
                MemberMembershipType = @MembershipType
            WHERE MemberEmail = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Surname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker2.Value.Date);

                    // Update extra fields ONLY IF values are present
                    DateTime selectedTime = DateTime.Parse(comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GymTime", (object)selectedTime.TimeOfDay);

                    cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(richTextBox1.Text) ? DBNull.Value : (object)richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@Mobile", textBox4.Text);
                    cmd.Parameters.AddWithValue("@MembershipType", comboBox2.SelectedItem != null ? (object)comboBox2.SelectedItem.ToString() : DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", textBox3.Text);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Member updated." : "No match found.");
                }
            }
        }

        //delete button
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter the email of the member to delete.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True"))
            {
                string query = "DELETE FROM MemberData WHERE MemberEmail = @Email";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", textBox3.Text);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Member deleted." : "Member not found.");
                    ClearForm();
                }
            }
        }

        //search button
        private void button4_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter the member's first name to search.");
                return;
            }

            string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True;";
            string query = "SELECT * FROM MemberData WHERE MemberFirstName = @FirstName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);

                try
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Show data in DataGridView
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        // Populate form fields with the first result
                        DataRow row = dt.Rows[0];

                        textBox2.Text = row["MemberSurname"].ToString();
                        textBox3.Text = row["MemberEmail"].ToString();
                        textBox4.Text = row["MemberMobile"].ToString();
                        richTextBox1.Text = row["MemberAddress"].ToString();

                        // Gender
                        string gender = row["MemberGender"].ToString();
                        radioButton1.Checked = gender == "Male";
                        radioButton2.Checked = gender == "Female";

                        // Date pickers
                        if (row["MemberDOB"] != DBNull.Value)
                            dateTimePicker1.Value = Convert.ToDateTime(row["MemberDOB"]);

                        if (row["MemberJoinDate"] != DBNull.Value)
                            dateTimePicker2.Value = Convert.ToDateTime(row["MemberJoinDate"]);

                        // Dropdowns
                        comboBox1.Text = row["MemberGymTime"]?.ToString();
                        comboBox2.Text = row["MemberMembershipType"]?.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Member not found.");
                        ClearForm();
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //surname text box
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //male radio button
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //female radio button
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //date of birth picker
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //email text box
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //mobile text box
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           //join date picker
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gym time picker drop down
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //adress text box
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //member type drop down
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data grid view for table display
        }
    }
}
