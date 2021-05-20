
namespace EducationalCenter
{
    partial class Form2E_A
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBookLessons = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(30, 55);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(342, 22);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentID,
            this.ColumnTeacher,
            this.ColumnSubject,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(418, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Student ID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            // 
            // ColumnTeacher
            // 
            this.ColumnTeacher.HeaderText = "Teacher";
            this.ColumnTeacher.Name = "ColumnTeacher";
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Room";
            this.ColumnRoom.Name = "ColumnRoom";
            // 
            // labelBookLessons
            // 
            this.labelBookLessons.AutoSize = true;
            this.labelBookLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBookLessons.Location = new System.Drawing.Point(30, 113);
            this.labelBookLessons.Name = "labelBookLessons";
            this.labelBookLessons.Size = new System.Drawing.Size(84, 15);
            this.labelBookLessons.TabIndex = 8;
            this.labelBookLessons.Text = "Book Lessons:";
            // 
            // Form2E_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.labelBookLessons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2E_A";
            this.Text = "Form2E_A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.Label labelBookLessons;
    }
}