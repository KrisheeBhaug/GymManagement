namespace GymAdmin
{
    partial class WorkoutPlanControl
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
            this.lblPlanName = new System.Windows.Forms.Label();
            this.lblExercise = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.txtExerciseName = new System.Windows.Forms.TextBox();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnSavePlan = new System.Windows.Forms.Button();
            this.lbExercises = new System.Windows.Forms.ListBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPlanName.Location = new System.Drawing.Point(288, 86);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(100, 20);
            this.lblPlanName.TabIndex = 0;
            this.lblPlanName.Text = "Plan Name:";
            // 
            // lblExercise
            // 
            this.lblExercise.AutoSize = true;
            this.lblExercise.BackColor = System.Drawing.Color.Transparent;
            this.lblExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercise.ForeColor = System.Drawing.SystemColors.Info;
            this.lblExercise.Location = new System.Drawing.Point(288, 180);
            this.lblExercise.Name = "lblExercise";
            this.lblExercise.Size = new System.Drawing.Size(133, 20);
            this.lblExercise.TabIndex = 1;
            this.lblExercise.Text = "Exercise Name:";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.BackColor = System.Drawing.Color.Transparent;
            this.lblSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSets.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSets.Location = new System.Drawing.Point(288, 264);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(51, 20);
            this.lblSets.TabIndex = 2;
            this.lblSets.Text = "Sets:";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.BackColor = System.Drawing.Color.Transparent;
            this.lblReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReps.ForeColor = System.Drawing.SystemColors.Info;
            this.lblReps.Location = new System.Drawing.Point(288, 348);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(56, 20);
            this.lblReps.TabIndex = 3;
            this.lblReps.Text = "Reps:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Info;
            this.lblStatus.Location = new System.Drawing.Point(373, 486);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 18);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(Plan save status)";
            // 
            // txtPlanName
            // 
            this.txtPlanName.BackColor = System.Drawing.SystemColors.Info;
            this.txtPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlanName.Location = new System.Drawing.Point(464, 86);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(222, 26);
            this.txtPlanName.TabIndex = 5;
            // 
            // txtExerciseName
            // 
            this.txtExerciseName.BackColor = System.Drawing.SystemColors.Info;
            this.txtExerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExerciseName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtExerciseName.Location = new System.Drawing.Point(464, 180);
            this.txtExerciseName.Name = "txtExerciseName";
            this.txtExerciseName.Size = new System.Drawing.Size(222, 26);
            this.txtExerciseName.TabIndex = 6;
            // 
            // txtSets
            // 
            this.txtSets.BackColor = System.Drawing.SystemColors.Info;
            this.txtSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSets.Location = new System.Drawing.Point(464, 260);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(222, 26);
            this.txtSets.TabIndex = 7;
            // 
            // txtReps
            // 
            this.txtReps.BackColor = System.Drawing.SystemColors.Info;
            this.txtReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReps.Location = new System.Drawing.Point(464, 348);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(222, 26);
            this.txtReps.TabIndex = 8;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExercise.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddExercise.Location = new System.Drawing.Point(371, 411);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(128, 47);
            this.btnAddExercise.TabIndex = 9;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            // 
            // btnSavePlan
            // 
            this.btnSavePlan.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSavePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePlan.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSavePlan.Location = new System.Drawing.Point(516, 411);
            this.btnSavePlan.Name = "btnSavePlan";
            this.btnSavePlan.Size = new System.Drawing.Size(128, 47);
            this.btnSavePlan.TabIndex = 10;
            this.btnSavePlan.Text = "Save Plan";
            this.btnSavePlan.UseVisualStyleBackColor = false;
            // 
            // lbExercises
            // 
            this.lbExercises.BackColor = System.Drawing.SystemColors.Info;
            this.lbExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExercises.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbExercises.FormattingEnabled = true;
            this.lbExercises.ItemHeight = 18;
            this.lbExercises.Items.AddRange(new object[] {
            "(List of added exercises)"});
            this.lbExercises.Location = new System.Drawing.Point(516, 486);
            this.lbExercises.Name = "lbExercises";
            this.lbExercises.Size = new System.Drawing.Size(170, 94);
            this.lbExercises.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.lbTitle.Location = new System.Drawing.Point(415, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 36);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Workout Plan";
            // 
            // WorkoutPlanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GymAdmin.Properties.Resources._2968326;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbExercises);
            this.Controls.Add(this.btnSavePlan);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.txtExerciseName);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblExercise);
            this.Controls.Add(this.lblPlanName);
            this.Name = "WorkoutPlanControl";
            this.Size = new System.Drawing.Size(978, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Label lblExercise;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.TextBox txtExerciseName;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnSavePlan;
        private System.Windows.Forms.ListBox lbExercises;
        private System.Windows.Forms.Label lbTitle;
    }
}
