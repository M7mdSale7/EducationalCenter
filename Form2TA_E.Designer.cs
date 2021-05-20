
namespace EducationalCenter
{
    partial class Form2TA_E
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
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.labelGradesReports = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExam1Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExam2Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExam3Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentName,
            this.ColumnPhoneNo,
            this.ColumnParentNo,
            this.ColumnExam1Grade,
            this.ColumnExam2Grade,
            this.ColumnExam3Grade});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(20, 192);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(342, 183);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // labelGradesReports
            // 
            this.labelGradesReports.AutoSize = true;
            this.labelGradesReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGradesReports.Location = new System.Drawing.Point(20, 139);
            this.labelGradesReports.Name = "labelGradesReports";
            this.labelGradesReports.Size = new System.Drawing.Size(128, 21);
            this.labelGradesReports.TabIndex = 19;
            this.labelGradesReports.Text = "Grades Reports:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(53, 84);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(78, 20);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(299, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(73, 31);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Student Name";
            this.ColumnStudentName.Name = "ColumnStudentName";
            this.ColumnStudentName.ReadOnly = true;
            // 
            // ColumnPhoneNo
            // 
            this.ColumnPhoneNo.HeaderText = "Phone Number";
            this.ColumnPhoneNo.Name = "ColumnPhoneNo";
            this.ColumnPhoneNo.ReadOnly = true;
            // 
            // ColumnParentNo
            // 
            this.ColumnParentNo.HeaderText = "Parent Number";
            this.ColumnParentNo.Name = "ColumnParentNo";
            this.ColumnParentNo.ReadOnly = true;
            // 
            // ColumnExam1Grade
            // 
            this.ColumnExam1Grade.HeaderText = "Exam1 Grade";
            this.ColumnExam1Grade.Name = "ColumnExam1Grade";
            this.ColumnExam1Grade.ReadOnly = true;
            // 
            // ColumnExam2Grade
            // 
            this.ColumnExam2Grade.HeaderText = "Exam2 Grade";
            this.ColumnExam2Grade.Name = "ColumnExam2Grade";
            this.ColumnExam2Grade.ReadOnly = true;
            // 
            // ColumnExam3Grade
            // 
            this.ColumnExam3Grade.HeaderText = "Exam3 Grade";
            this.ColumnExam3Grade.Name = "ColumnExam3Grade";
            this.ColumnExam3Grade.ReadOnly = true;
            // 
            // Form2TA_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelGradesReports);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2TA_E";
            this.Text = "Form2TA_E";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExam1Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExam2Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExam3Grade;
        private System.Windows.Forms.Label labelGradesReports;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
    }
}