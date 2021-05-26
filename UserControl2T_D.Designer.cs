
namespace EducationalCenter
{
    partial class UserControl2T_D
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
            this.label_Grade = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.label_ExamID = new System.Windows.Forms.Label();
            this.labelStudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGradesReport = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxExamID = new System.Windows.Forms.ComboBox();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.Location = new System.Drawing.Point(170, 212);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(36, 13);
            this.label_Grade.TabIndex = 66;
            this.label_Grade.Text = "Grade";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(173, 227);
            this.textBoxGrade.MaxLength = 15;
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 65;
            // 
            // label_ExamID
            // 
            this.label_ExamID.AutoSize = true;
            this.label_ExamID.Location = new System.Drawing.Point(35, 264);
            this.label_ExamID.Name = "label_ExamID";
            this.label_ExamID.Size = new System.Drawing.Size(47, 13);
            this.label_ExamID.TabIndex = 64;
            this.label_ExamID.Text = "Exam ID";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(32, 212);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(44, 13);
            this.labelStudent.TabIndex = 63;
            this.labelStudent.Text = "Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentID,
            this.ColumnStudentName,
            this.ColumnPhoneNumber,
            this.ColumnParentNumber,
            this.ColumnExamID,
            this.ColumnGrade});
            this.dataGridView1.Location = new System.Drawing.Point(32, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(536, 130);
            this.dataGridView1.TabIndex = 60;
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.BackColor = System.Drawing.Color.Transparent;
            this.labelGradesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradesReport.Location = new System.Drawing.Point(29, 28);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(133, 20);
            this.labelGradesReport.TabIndex = 89;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(414, 49);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 88;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(332, 224);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 87;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(35, 228);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudent.TabIndex = 90;
            // 
            // comboBoxExamID
            // 
            this.comboBoxExamID.FormattingEnabled = true;
            this.comboBoxExamID.Location = new System.Drawing.Point(35, 280);
            this.comboBoxExamID.Name = "comboBoxExamID";
            this.comboBoxExamID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExamID.TabIndex = 91;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Student ID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.ReadOnly = true;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Student name";
            this.ColumnStudentName.Name = "ColumnStudentName";
            this.ColumnStudentName.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Phone Number";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            this.ColumnPhoneNumber.ReadOnly = true;
            // 
            // ColumnParentNumber
            // 
            this.ColumnParentNumber.HeaderText = "Parent Number";
            this.ColumnParentNumber.Name = "ColumnParentNumber";
            this.ColumnParentNumber.ReadOnly = true;
            // 
            // ColumnExamID
            // 
            this.ColumnExamID.HeaderText = "Exam ID";
            this.ColumnExamID.Name = "ColumnExamID";
            this.ColumnExamID.ReadOnly = true;
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Grade";
            this.ColumnGrade.Name = "ColumnGrade";
            this.ColumnGrade.ReadOnly = true;
            // 
            // UserControl2T_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources._52cf2839_f541_4fe6_b077_385373bd2004;
            this.Controls.Add(this.comboBoxExamID);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label_Grade);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.label_ExamID);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2T_D";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label label_ExamID;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelGradesReport;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
    }
}
