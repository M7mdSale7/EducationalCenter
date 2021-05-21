
namespace EducationalCenter
{
    partial class Form2TA_D
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
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelOldID = new System.Windows.Forms.Label();
            this.textBoxOldID = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentName,
            this.ColumnID,
            this.ColumnPhoneNo,
            this.ColumnParentNumber});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(439, 134);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Student Name";
            this.ColumnStudentName.Name = "ColumnStudentName";
            this.ColumnStudentName.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnPhoneNo
            // 
            this.ColumnPhoneNo.HeaderText = "Phone Number";
            this.ColumnPhoneNo.Name = "ColumnPhoneNo";
            this.ColumnPhoneNo.ReadOnly = true;
            // 
            // ColumnParentNumber
            // 
            this.ColumnParentNumber.HeaderText = "Parent Number";
            this.ColumnParentNumber.Name = "ColumnParentNumber";
            this.ColumnParentNumber.ReadOnly = true;
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAttendance.Location = new System.Drawing.Point(12, 113);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(102, 21);
            this.labelAttendance.TabIndex = 19;
            this.labelAttendance.Text = "Attendance:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.labelWelcome.Location = new System.Drawing.Point(45, 71);
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
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(20, 307);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 54;
            this.labelID.Text = "ID";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(192, 320);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 50;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(23, 323);
            this.textBoxStudentID.MaxLength = 15;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 49;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(192, 376);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 51;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelOldID
            // 
            this.labelOldID.AutoSize = true;
            this.labelOldID.Location = new System.Drawing.Point(23, 360);
            this.labelOldID.Name = "labelOldID";
            this.labelOldID.Size = new System.Drawing.Size(90, 13);
            this.labelOldID.TabIndex = 55;
            this.labelOldID.Text = "Old ID for Update";
            // 
            // textBoxOldID
            // 
            this.textBoxOldID.Location = new System.Drawing.Point(26, 376);
            this.textBoxOldID.MaxLength = 15;
            this.textBoxOldID.Name = "textBoxOldID";
            this.textBoxOldID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldID.TabIndex = 56;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(297, 119);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 57;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // Form2TA_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.textBoxOldID);
            this.Controls.Add(this.labelOldID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2TA_D";
            this.Text = "Form2TA_D";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNumber;
        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelOldID;
        private System.Windows.Forms.TextBox textBoxOldID;
        private System.Windows.Forms.Label labelDelete;
    }
}