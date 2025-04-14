namespace GymMembership
{
    partial class MemberDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.BillingButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ProfileManagementButton = new System.Windows.Forms.Button();
            this.WorkoutPlanButton = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 640);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BillingButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LogoutButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ProfileManagementButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkoutPlanButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClassButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CalculatorButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28082F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 640);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "DASHBOARD";
            // 
            // BillingButton
            // 
            this.BillingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillingButton.BackColor = System.Drawing.Color.LightGray;
            this.BillingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingButton.Image = global::GymMembership.Properties.Resources.credit_card;
            this.BillingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BillingButton.Location = new System.Drawing.Point(35, 480);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.Size = new System.Drawing.Size(122, 40);
            this.BillingButton.TabIndex = 4;
            this.BillingButton.TabStop = false;
            this.BillingButton.Text = "     Billing Info";
            this.BillingButton.UseVisualStyleBackColor = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutButton.BackColor = System.Drawing.Color.LightGray;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(35, 573);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(122, 40);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.TabStop = false;
            this.LogoutButton.Text = " Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            // 
            // ProfileManagementButton
            // 
            this.ProfileManagementButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProfileManagementButton.BackColor = System.Drawing.Color.LightGray;
            this.ProfileManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileManagementButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProfileManagementButton.Image = global::GymMembership.Properties.Resources.group;
            this.ProfileManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileManagementButton.Location = new System.Drawing.Point(27, 109);
            this.ProfileManagementButton.Name = "ProfileManagementButton";
            this.ProfileManagementButton.Size = new System.Drawing.Size(139, 54);
            this.ProfileManagementButton.TabIndex = 1;
            this.ProfileManagementButton.TabStop = false;
            this.ProfileManagementButton.Text = "Profile Management";
            this.ProfileManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileManagementButton.UseVisualStyleBackColor = false;
            // 
            // WorkoutPlanButton
            // 
            this.WorkoutPlanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkoutPlanButton.BackColor = System.Drawing.Color.LightGray;
            this.WorkoutPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkoutPlanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutPlanButton.Image = global::GymMembership.Properties.Resources.gym;
            this.WorkoutPlanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WorkoutPlanButton.Location = new System.Drawing.Point(35, 202);
            this.WorkoutPlanButton.Name = "WorkoutPlanButton";
            this.WorkoutPlanButton.Size = new System.Drawing.Size(122, 51);
            this.WorkoutPlanButton.TabIndex = 2;
            this.WorkoutPlanButton.TabStop = false;
            this.WorkoutPlanButton.Text = "       Workout Plan";
            this.WorkoutPlanButton.UseVisualStyleBackColor = false;
            // 
            // ClassButton
            // 
            this.ClassButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassButton.BackColor = System.Drawing.Color.LightGray;
            this.ClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassButton.Image = global::GymMembership.Properties.Resources.group_class;
            this.ClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassButton.Location = new System.Drawing.Point(40, 298);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(113, 40);
            this.ClassButton.TabIndex = 5;
            this.ClassButton.TabStop = false;
            this.ClassButton.Text = "   Class";
            this.ClassButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculatorButton.BackColor = System.Drawing.Color.LightGray;
            this.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButton.Image = global::GymMembership.Properties.Resources._7067484_finance_calculate_calculator_icon;
            this.CalculatorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatorButton.Location = new System.Drawing.Point(26, 383);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(140, 53);
            this.CalculatorButton.TabIndex = 3;
            this.CalculatorButton.TabStop = false;
            this.CalculatorButton.Text = "     Calorie/BMI \r\n     Calculator";
            this.CalculatorButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(892, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gym Hive Limited";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GymMembership.Properties.Resources._5416547_crossfit_wallpaper;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 640);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(117, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 403);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MemberDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MemberDashboard";
            this.Text = "MemberDashboard";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ProfileManagementButton;
        private System.Windows.Forms.Button WorkoutPlanButton;
        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button BillingButton;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}