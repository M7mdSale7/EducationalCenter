
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
            this.labelAttendance = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewSchedule.Location = new System.Drawing.Point(19, 190);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(342, 183);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // labelAttendance
            // 
            this.labelAttendance.AutoSize = true;
            this.labelAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttendance.Location = new System.Drawing.Point(19, 137);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(102, 21);
            this.labelAttendance.TabIndex = 19;
            this.labelAttendance.Text = "Attendance:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(52, 82);
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
            // Form2TA_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelAttendance);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonBack);
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
    }
}