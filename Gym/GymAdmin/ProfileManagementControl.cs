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
using System.IO;

namespace GymAdmin
{
    public partial class ProfileManagementControl: UserControl
    {
        private string currentUserEmail;
        private string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True";

        public ProfileManagementControl(string userEmail)
        {
            InitializeComponent();
            currentUserEmail = userEmail;
        }

        public ProfileManagementControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //profile picture
        }

        //upload profile picture
        private void button3_Click(object sender, EventArgs e)
        {
            // Open file dialog to select an image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";  // Set the filter for image files

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox
                pictureBox1.Image = Image.FromFile(ofd.FileName);

                // Save the selected image to the database using the current user's email
                SaveProfilePicture(currentUserEmail);

                // Show a message indicating the picture was uploaded successfully
                MessageBox.Show("Profile picture uploaded successfully.");
            }
        }

        //remove profile picture    
        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MemberData SET ProfilePicture = NULL WHERE MemberEmail = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", currentUserEmail);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Profile picture removed.");
        }


        //change profile picture
        private void button4_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
        }

        //cancel profile picture update
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //login name credentials 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //login password credentials 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Confirm password to accept chnages
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //emergency name
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //change emergency contact mobile number credentials update memberdata table for it
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //To enter personal preferences 
        }

        private void SaveProfilePicture(string email)
        {
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE MemberData SET ProfilePicture = @Image WHERE MemberEmail = @Email";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Ensure parameters are added correctly
                        cmd.Parameters.AddWithValue("@Image", img);
                        cmd.Parameters.AddWithValue("@Email", email);  // Check this line

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }



        // save profile updates to database
        private void button10_Click(object sender, EventArgs e)
        {
            // Check if passwords match
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Save the profile picture first
            SaveProfilePicture(currentUserEmail);

            // Now, update other profile details including preferences
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE MemberData 
                         SET MemberFirstName = @FirstName, 
                             MemberPassword = @Password, 
                             EmergencyContactName = @ECName,
                             EmergencyContactNumber = @ECNumber,
                             PersonalPreferences = @Preferences
                         WHERE MemberEmail = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Adding parameters to the SQL query
                cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);  
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);   
                cmd.Parameters.AddWithValue("@ECName", textBox6.Text);    
                cmd.Parameters.AddWithValue("@ECNumber", textBox5.Text);   
                cmd.Parameters.AddWithValue("@Preferences", richTextBox1.Text); 
                cmd.Parameters.AddWithValue("@Email", currentUserEmail);   

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully.");
            }
        }


        //update profile credentials 
        private void button1_Click(object sender, EventArgs e)
        {
            button10.PerformClick();
        }

        //cancel profile update
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            //emergency contact number
        }

        private void ProfileManagementControl_Load(object sender, EventArgs e)
        {

        }
    }
}
