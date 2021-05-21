
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
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelGradesReports = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label_Grade = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label_ExamID = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
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
            this.ColumnExamID,
            this.ColumnGrade});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(28, 124);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(544, 159);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Student ID";
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
            // ColumnExamID
            // 
            this.ColumnExamID.HeaderText = "Exam ID";
            this.ColumnExamID.Name = "ColumnExamID";
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Grade";
            this.ColumnGrade.Name = "ColumnGrade";
            // 
            // labelGradesReports
            // 
            this.labelGradesReports.AutoSize = true;
            this.labelGradesReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGradesReports.Location = new System.Drawing.Point(24, 102);
            this.labelGradesReports.Name = "labelGradesReports";
            this.labelGradesReports.Size = new System.Drawing.Size(128, 21);
            this.labelGradesReports.TabIndex = 19;
            this.labelGradesReports.Text = "Grades Reports:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelWelcome.Location = new System.Drawing.Point(45, 73);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(78, 20);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(508, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 20);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(176, 307);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(36, 13);
            this.label_Grade.TabIndex = 70;
            this.label_Grade.Text = "Grade";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(179, 323);
            this.textBoxGrade.MaxLength = 15;
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 69;
            // 
            // label_ExamID
            // 
            this.label_ExamID.AutoSize = true;
            this.label_ExamID.Location = new System.Drawing.Point(41, 359);
            this.label_ExamID.Name = "label_ExamID";
            this.label_ExamID.Size = new System.Drawing.Size(47, 13);
            this.label_ExamID.TabIndex = 66;
            this.label_ExamID.Text = "Exam ID";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(38, 307);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 64;
            this.labelStudentID.Text = "Student ID";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(338, 373);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 63;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(338, 323);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 62;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Location = new System.Drawing.Point(41, 376);
            this.textBoxExamID.MaxLength = 15;
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.Size = new System.Drawing.Size(100, 20);
            this.textBoxExamID.TabIndex = 61;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(41, 323);
            this.textBoxStudentID.MaxLength = 15;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 59;
            // 
            // Form2TA_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label_Grade);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label_ExamID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelGradesReports);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2TA_E";
            this.Text = "Form2TA_E";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Label labelGradesReports;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label_ExamID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxExamID;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
    }
}