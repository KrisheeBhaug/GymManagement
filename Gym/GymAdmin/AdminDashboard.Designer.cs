namespace GymAdmin
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.MemberButton = new System.Windows.Forms.Button();
            this.EquipmentButton = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.TrainerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Member = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.ClassButton);
            this.panel1.Controls.Add(this.MemberButton);
            this.panel1.Controls.Add(this.EquipmentButton);
            this.panel1.Controls.Add(this.PaymentButton);
            this.panel1.Controls.Add(this.TrainerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 788);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "DASHBOARD";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(47, 697);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(163, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = " Logout";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // ClassButton
            // 
            this.ClassButton.BackColor = System.Drawing.Color.White;
            this.ClassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassButton.Image = ((System.Drawing.Image)(resources.GetObject("ClassButton.Image")));
            this.ClassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassButton.Location = new System.Drawing.Point(47, 572);
            this.ClassButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(163, 49);
            this.ClassButton.TabIndex = 5;
            this.ClassButton.Text = "  Class";
            this.ClassButton.UseVisualStyleBackColor = false;
            // 
            // MemberButton
            // 
            this.MemberButton.BackColor = System.Drawing.Color.White;
            this.MemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberButton.Image = ((System.Drawing.Image)(resources.GetObject("MemberButton.Image")));
            this.MemberButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MemberButton.Location = new System.Drawing.Point(47, 129);
            this.MemberButton.Margin = new System.Windows.Forms.Padding(4);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Size = new System.Drawing.Size(163, 54);
            this.MemberButton.TabIndex = 1;
            this.MemberButton.Text = "  Member";
            this.MemberButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MemberButton.UseVisualStyleBackColor = false;
            this.MemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EquipmentButton
            // 
            this.EquipmentButton.BackColor = System.Drawing.Color.White;
            this.EquipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentButton.Image = ((System.Drawing.Image)(resources.GetObject("EquipmentButton.Image")));
            this.EquipmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EquipmentButton.Location = new System.Drawing.Point(47, 453);
            this.EquipmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.EquipmentButton.Name = "EquipmentButton";
            this.EquipmentButton.Size = new System.Drawing.Size(163, 49);
            this.EquipmentButton.TabIndex = 4;
            this.EquipmentButton.Text = "     Equipment";
            this.EquipmentButton.UseVisualStyleBackColor = false;
            this.EquipmentButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.White;
            this.PaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentButton.Image")));
            this.PaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.Location = new System.Drawing.Point(47, 343);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(163, 49);
            this.PaymentButton.TabIndex = 3;
            this.PaymentButton.Text = "      Payment";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TrainerButton
            // 
            this.TrainerButton.BackColor = System.Drawing.Color.White;
            this.TrainerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainerButton.Image = ((System.Drawing.Image)(resources.GetObject("TrainerButton.Image")));
            this.TrainerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrainerButton.Location = new System.Drawing.Point(47, 235);
            this.TrainerButton.Margin = new System.Windows.Forms.Padding(4);
            this.TrainerButton.Name = "TrainerButton";
            this.TrainerButton.Size = new System.Drawing.Size(163, 49);
            this.TrainerButton.TabIndex = 2;
            this.TrainerButton.Text = " Trainer";
            this.TrainerButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GymAdmin.Properties.Resources._8d04c7fe77604f55786d06f9ec0cd92b;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Member);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(253, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 788);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(256, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 504);
            this.label1.TabIndex = 14;
            this.label1.Text = "using System;\r\n\r\nnamespace WelcomeApp\r\n{\r\n    class Program\r\n    {\r\n        stati" +
    "c void Main(string[] args)\r\n        {\r\n            Console.WriteLine(\"Welcome Ba" +
    "ck, Admin\");\r\n        }\r\n    }\r\n}";
            // 
            // Member
            // 
            this.Member.AutoSize = true;
            this.Member.Location = new System.Drawing.Point(1183, 11);
            this.Member.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(0, 16);
            this.Member.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Impact", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(959, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 56);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gym Hive Limited";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button EquipmentButton;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button TrainerButton;
        private System.Windows.Forms.Button MemberButton;
        private System.Windows.Forms.Label Member;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClassButton;
    }
}