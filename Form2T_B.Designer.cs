
namespace EducationalCenter
{
    partial class Form2T_B
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
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudyYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(452, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 50);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnID,
            this.ColumnPhoneNumber,
            this.ColumnParentNumber,
            this.ColumnStudyYear});
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 1;
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
            // ColumnStudyYear
            // 
            this.ColumnStudyYear.HeaderText = "Study Year";
            this.ColumnStudyYear.Name = "ColumnStudyYear";
            this.ColumnStudyYear.ReadOnly = true;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(13, 110);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(56, 15);
            this.labelStudents.TabIndex = 2;
            this.labelStudents.Text = "Students:";
            // 
            // Form2T_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2T_B";
            this.Text = "Form2T-B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudyYear;
        private System.Windows.Forms.Label labelStudents;
    }
}