using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class BillingControl : UserControl
    {
        public BillingControl()
        {
            InitializeComponent();
        }

        // SQL Server connection string (update this based on your config)
        private string connectionString = "Data Source=localhost;Initial Catalog=GymManagementDB;Integrated Security=True;TrustServerCertificate=True;";

        // Full Name text change event (optional handling)
        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        // Membership type selection changed
        private void cbMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Payment method selection changed
        private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Payment ID text changed
        private void txtPaymentId_TextChanged(object sender, EventArgs e)
        {
        }

        // Amount text changed - show a popup error if non-numeric input is detected
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAmount.Text) && !decimal.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Amount must be a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Clear();
                txtAmount.Focus();
            }
        }


        // SUBMIT payment to database
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cbMembership.Text) ||
                string.IsNullOrWhiteSpace(cbMethod.Text) ||
                string.IsNullOrWhiteSpace(txtPaymentId.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Amount must be a valid number.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO BillingData 
                                    (FullName, MembershipType, PaymentMethod, PaymentID, Amount) 
                                     VALUES (@FullName, @MembershipType, @PaymentMethod, @PaymentID, @Amount)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@MembershipType", cbMembership.Text);
                    cmd.Parameters.AddWithValue("@PaymentMethod", cbMethod.Text);
                    cmd.Parameters.AddWithValue("@PaymentID", txtPaymentId.Text);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment successfully recorded!");

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        // Clear all input fields
        private void ClearForm()
        {
            txtName.Clear();
            cbMembership.SelectedIndex = -1;
            cbMethod.SelectedIndex = -1;
            txtPaymentId.Clear();
            txtAmount.Clear();
        }

        // PRINT the bill details
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc
            };
            preview.ShowDialog();
        }

        // Custom print layout
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            string printContent = $"***** Gym Hive Billing Receipt *****\n\n" +
                                  $"Name: {txtName.Text}\n" +
                                  $"Membership Type: {cbMembership.Text}\n" +
                                  $"Payment Method: {cbMethod.Text}\n" +
                                  $"Payment ID: {txtPaymentId.Text}\n" +
                                  $"Amount Paid: Rs {txtAmount.Text}\n" +
                                  $"Date: {DateTime.Now}\n\n" +
                                  $"Thank you for your payment!";

            e.Graphics.DrawString(printContent, new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
        }
    }
}
