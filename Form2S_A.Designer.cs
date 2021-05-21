
namespace EducationalCenter
{
    partial class Form2S_A
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnSubject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLessons = new System.Windows.Forms.Label();
            this.labelExams = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnTeacher,
            this.ColumnDateTime,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(10, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 90);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnTeacher
            // 
            this.ColumnTeacher.HeaderText = "Teacher";
            this.ColumnTeacher.Name = "ColumnTeacher";
            this.ColumnTeacher.ReadOnly = true;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Date&Time";
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Room";
            this.ColumnRoom.Name = "ColumnRoom";
            this.ColumnRoom.ReadOnly = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(508, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 20);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject2,
            this.ColumnTeacher2,
            this.ColumnDateTime2,
            this.ColumnRoom2});
            this.dataGridView2.Location = new System.Drawing.Point(11, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(434, 98);
            this.dataGridView2.TabIndex = 2;
            // 
            // ColumnSubject2
            // 
            this.ColumnSubject2.HeaderText = "Subject";
            this.ColumnSubject2.Name = "ColumnSubject2";
            this.ColumnSubject2.ReadOnly = true;
            // 
            // ColumnTeacher2
            // 
            this.ColumnTeacher2.HeaderText = "Teacher";
            this.ColumnTeacher2.Name = "ColumnTeacher2";
            this.ColumnTeacher2.ReadOnly = true;
            // 
            // ColumnDateTime2
            // 
            this.ColumnDateTime2.HeaderText = "Date&Time";
            this.ColumnDateTime2.Name = "ColumnDateTime2";
            this.ColumnDateTime2.ReadOnly = true;
            // 
            // ColumnRoom2
            // 
            this.ColumnRoom2.HeaderText = "Room";
            this.ColumnRoom2.Name = "ColumnRoom2";
            this.ColumnRoom2.ReadOnly = true;
            // 
            // labelLessons
            // 
            this.labelLessons.AutoSize = true;
            this.labelLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelLessons.Location = new System.Drawing.Point(11, 67);
            this.labelLessons.Name = "labelLessons";
            this.labelLessons.Size = new System.Drawing.Size(52, 15);
            this.labelLessons.TabIndex = 3;
            this.labelLessons.Text = "Lessons:";
            // 
            // labelExams
            // 
            this.labelExams.AutoSize = true;
            this.labelExams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelExams.Location = new System.Drawing.Point(11, 202);
            this.labelExams.Name = "labelExams";
            this.labelExams.Size = new System.Drawing.Size(45, 15);
            this.labelExams.TabIndex = 4;
            this.labelExams.Text = "Exams:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(11, 28);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // Form2S_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelExams);
            this.Controls.Add(this.labelLessons);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2S_A";
            this.Text = "Form1S";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom2;
        private System.Windows.Forms.Label labelLessons;
        private System.Windows.Forms.Label labelExams;
        private System.Windows.Forms.Label labelWelcome;
    }
}