
namespace EducationalCenter
{
    partial class Form2T_E
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
            this.ColumnStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelGradesReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentName,
            this.ColumnPhoneNumber,
            this.ColumnParentNumber});
            this.dataGridView1.Location = new System.Drawing.Point(27, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnStudentName
            // 
            this.ColumnStudentName.HeaderText = "Student Name";
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
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(269, 61);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 50);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.Location = new System.Drawing.Point(27, 121);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(84, 15);
            this.labelGradesReport.TabIndex = 2;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // Form2T_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2T_E";
            this.Text = "Form2T-E";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNumber;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelGradesReport;
    }
}