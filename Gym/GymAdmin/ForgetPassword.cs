using System;
using System.Windows.Forms;

public partial class ForgotPasswordForm : Form
{
    public string AdminID { get; private set; }

    public ForgotPasswordForm()
    {
        InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        AdminID = txtAdminID.Text; // Assuming txtAdminID is the TextBox for input
        this.DialogResult = DialogResult.OK; // Set dialog result to OK
        this.Close(); // Close the form
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel; // Set dialog result to Cancel
        this.Close(); // Close the form
    }
}