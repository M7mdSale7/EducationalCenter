
namespace EducationalCenter
{
    partial class UserControl2S_A
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnSubject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLessons = new System.Windows.Forms.Label();
            this.labelExams = new System.Windows.Forms.Label();
            this.labelTA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject2,
            this.ColumnTeacher2,
            this.ColumnDateTime2,
            this.ColumnRoom2});
            this.dataGridView2.Location = new System.Drawing.Point(23, 222);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(434, 98);
            this.dataGridView2.TabIndex = 3;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnTeacher,
            this.ColumnDateTime,
            this.ColumnRoom});
            this.dataGridView1.Location = new System.Drawing.Point(22, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 90);
            this.dataGridView1.TabIndex = 4;
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
            // labelLessons
            // 
            this.labelLessons.AutoSize = true;
            this.labelLessons.BackColor = System.Drawing.Color.Transparent;
            this.labelLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLessons.Location = new System.Drawing.Point(18, 31);
            this.labelLessons.Name = "labelLessons";
            this.labelLessons.Size = new System.Drawing.Size(81, 20);
            this.labelLessons.TabIndex = 98;
            this.labelLessons.Text = "Lessons:";
            // 
            // labelExams
            // 
            this.labelExams.AutoSize = true;
            this.labelExams.BackColor = System.Drawing.Color.Transparent;
            this.labelExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExams.Location = new System.Drawing.Point(19, 187);
            this.labelExams.Name = "labelExams";
            this.labelExams.Size = new System.Drawing.Size(67, 20);
            this.labelExams.TabIndex = 99;
            this.labelExams.Text = "Exams:";
            // 
            // labelTA
            // 
            this.labelTA.AutoSize = true;
            this.labelTA.BackColor = System.Drawing.Color.Transparent;
            this.labelTA.Location = new System.Drawing.Point(263, 50);
            this.labelTA.Name = "labelTA";
            this.labelTA.Size = new System.Drawing.Size(194, 13);
            this.labelTA.TabIndex = 100;
            this.labelTA.Text = "Double Click on a Row to Contact a TA";
            // 
            // UserControl2S_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources._52cf2839_f541_4fe6_b077_385373bd2004;
            this.Controls.Add(this.labelTA);
            this.Controls.Add(this.labelExams);
            this.Controls.Add(this.labelLessons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UserControl2S_A";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.Label labelLessons;
        private System.Windows.Forms.Label labelExams;
        private System.Windows.Forms.Label labelTA;
    }
}
