
namespace EducationalCenter
{
    partial class Form2S_B
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelGradesReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(375, 37);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnDateTime,
            this.ColumnGrade});
            this.dataGridView1.Location = new System.Drawing.Point(39, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 1;
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
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Grade";
            this.ColumnGrade.Name = "ColumnGrade";
            this.ColumnGrade.ReadOnly = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(39, 85);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome,";
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGradesReport.Location = new System.Drawing.Point(39, 117);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(91, 15);
            this.labelGradesReport.TabIndex = 3;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // Form2S_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2S_B";
            this.Text = "Form2S_B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelGradesReport;
    }
}