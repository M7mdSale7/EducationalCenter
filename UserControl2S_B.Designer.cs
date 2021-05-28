
namespace EducationalCenter
{
    partial class UserControl2S_B
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelGradesReport = new System.Windows.Forms.Label();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnDateTime,
            this.ColumnExam1,
            this.ColumnGrade});
            this.dataGridView1.Location = new System.Drawing.Point(26, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(441, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.BackColor = System.Drawing.Color.Transparent;
            this.labelGradesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradesReport.Location = new System.Drawing.Point(22, 40);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(133, 20);
            this.labelGradesReport.TabIndex = 90;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.ReadOnly = true;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Date&Time";
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            // 
            // ColumnExam1
            // 
            this.ColumnExam1.HeaderText = "Exam 1";
            this.ColumnExam1.Name = "ColumnExam1";
            this.ColumnExam1.ReadOnly = true;
            // 
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Grade";
            this.ColumnGrade.Name = "ColumnGrade";
            this.ColumnGrade.ReadOnly = true;
            // 
            // UserControl2S_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2S_B";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.Label labelGradesReport;
    }
}
