
namespace EducationalCenter
{
    partial class Form2TA_B
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
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudyYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnID,
            this.ColumnPhoneNo,
            this.ColumnParentNumber,
            this.ColumnStudyYear});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(19, 190);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(341, 183);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStudents.Location = new System.Drawing.Point(19, 137);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(81, 21);
            this.labelStudents.TabIndex = 19;
            this.labelStudents.Text = "Students:";
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
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
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
            // ColumnStudyYear
            // 
            this.ColumnStudyYear.HeaderText = "Study Year";
            this.ColumnStudyYear.Name = "ColumnStudyYear";
            this.ColumnStudyYear.ReadOnly = true;
            // 
            // Form2TA_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2TA_B";
            this.Text = "Form2TA_B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudyYear;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
    }
}