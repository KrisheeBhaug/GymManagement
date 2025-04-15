namespace GymAdmin
{
    partial class BillingControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblPaymentID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbMembership = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTitle.Location = new System.Drawing.Point(382, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MEMBER BILLING";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblName.Location = new System.Drawing.Point(308, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name:";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.BackColor = System.Drawing.Color.Transparent;
            this.lblMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembership.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMembership.Location = new System.Drawing.Point(308, 203);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(111, 20);
            this.lblMembership.TabIndex = 2;
            this.lblMembership.Text = "Membership:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMethod.Location = new System.Drawing.Point(288, 286);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(148, 20);
            this.lblMethod.TabIndex = 3;
            this.lblMethod.Text = "Payment Method:";
            // 
            // lblPaymentID
            // 
            this.lblPaymentID.AutoSize = true;
            this.lblPaymentID.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentID.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPaymentID.Location = new System.Drawing.Point(308, 362);
            this.lblPaymentID.Name = "lblPaymentID";
            this.lblPaymentID.Size = new System.Drawing.Size(112, 20);
            this.lblPaymentID.TabIndex = 4;
            this.lblPaymentID.Text = "Payment_ID:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAmount.Location = new System.Drawing.Point(308, 447);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(110, 20);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount(Rs):";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStatus.Location = new System.Drawing.Point(385, 577);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Info;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(345, 510);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 41);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Payment";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(500, 510);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 41);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print Bill";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(447, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 24);
            this.txtName.TabIndex = 9;
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.BackColor = System.Drawing.SystemColors.Info;
            this.txtPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPaymentId.Location = new System.Drawing.Point(447, 364);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(206, 24);
            this.txtPaymentId.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmount.Location = new System.Drawing.Point(447, 447);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(206, 24);
            this.txtAmount.TabIndex = 11;
            // 
            // cbMembership
            // 
            this.cbMembership.BackColor = System.Drawing.SystemColors.Info;
            this.cbMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMembership.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMembership.FormattingEnabled = true;
            this.cbMembership.Location = new System.Drawing.Point(447, 203);
            this.cbMembership.Name = "cbMembership";
            this.cbMembership.Size = new System.Drawing.Size(206, 26);
            this.cbMembership.TabIndex = 12;
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cbMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(453, 283);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(200, 26);
            this.cbMethod.TabIndex = 13;
            // 
            // BillingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymAdmin.Properties.Resources.wp7661139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.cbMembership);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPaymentID);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblMembership);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "BillingControl";
            this.Size = new System.Drawing.Size(978, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblPaymentID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbMembership;
        private System.Windows.Forms.ComboBox cbMethod;
    }
}
