namespace GymAdmin
{
    partial class Home
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
            this.LogAsMember = new System.Windows.Forms.Button();
            this.LogAsAdmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.joinUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesAndMembershipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogAsMember
            // 
            this.LogAsMember.BackColor = System.Drawing.SystemColors.Info;
            this.LogAsMember.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogAsMember.Location = new System.Drawing.Point(533, 333);
            this.LogAsMember.Name = "LogAsMember";
            this.LogAsMember.Size = new System.Drawing.Size(84, 34);
            this.LogAsMember.TabIndex = 1;
            this.LogAsMember.Text = "MEMBER";
            this.LogAsMember.UseVisualStyleBackColor = false;
            this.LogAsMember.Click += new System.EventHandler(this.LogAsMember_Click);
            // 
            // LogAsAdmin
            // 
            this.LogAsAdmin.BackColor = System.Drawing.SystemColors.Info;
            this.LogAsAdmin.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogAsAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogAsAdmin.Location = new System.Drawing.Point(394, 333);
            this.LogAsAdmin.Name = "LogAsAdmin";
            this.LogAsAdmin.Size = new System.Drawing.Size(81, 34);
            this.LogAsAdmin.TabIndex = 0;
            this.LogAsAdmin.Text = "ADMIN";
            this.LogAsAdmin.UseVisualStyleBackColor = false;
            this.LogAsAdmin.Click += new System.EventHandler(this.LogAsAdmin_Click_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(985, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to Gym Hive Limited—Your Path to a Healthier Lifestyle!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(273, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "Train Hard, Live Strong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(403, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Please choose an option:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinUsToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.feesAndMembershipsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 613);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1168, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // joinUsToolStripMenuItem
            // 
            this.joinUsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.joinUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
            this.joinUsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinUsToolStripMenuItem.Name = "joinUsToolStripMenuItem";
            this.joinUsToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.joinUsToolStripMenuItem.Text = "Join Us";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.contactUsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // feesAndMembershipsToolStripMenuItem
            // 
            this.feesAndMembershipsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.feesAndMembershipsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesAndMembershipsToolStripMenuItem.Name = "feesAndMembershipsToolStripMenuItem";
            this.feesAndMembershipsToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.feesAndMembershipsToolStripMenuItem.Text = "Membership";
            this.feesAndMembershipsToolStripMenuItem.Click += new System.EventHandler(this.feesAndMembershipsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LogAsMember);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LogAsAdmin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 429);
            this.panel1.TabIndex = 19;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymAdmin.Properties.Resources.OIP;
            this.ClientSize = new System.Drawing.Size(1168, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogAsMember;
        private System.Windows.Forms.Button LogAsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem joinUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesAndMembershipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}