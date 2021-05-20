
namespace EducationalCenter
{
    partial class Form2S_C
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAvailableLessons = new System.Windows.Forms.Label();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPricePerLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlot1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(411, 26);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(12, 65);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(60, 15);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome,";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubject,
            this.ColumnTeacher,
            this.ColumnGrade,
            this.ColumnPricePerLesson,
            this.ColumnSlot1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(536, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelAvailableLessons
            // 
            this.labelAvailableLessons.AutoSize = true;
            this.labelAvailableLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvailableLessons.Location = new System.Drawing.Point(12, 105);
            this.labelAvailableLessons.Name = "labelAvailableLessons";
            this.labelAvailableLessons.Size = new System.Drawing.Size(105, 15);
            this.labelAvailableLessons.TabIndex = 3;
            this.labelAvailableLessons.Text = "Available Lessons:";
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
            // ColumnGrade
            // 
            this.ColumnGrade.HeaderText = "Grade";
            this.ColumnGrade.Name = "ColumnGrade";
            this.ColumnGrade.ReadOnly = true;
            // 
            // ColumnPricePerLesson
            // 
            this.ColumnPricePerLesson.HeaderText = "Price per Lesson";
            this.ColumnPricePerLesson.Name = "ColumnPricePerLesson";
            this.ColumnPricePerLesson.ReadOnly = true;
            // 
            // ColumnSlot1
            // 
            this.ColumnSlot1.HeaderText = "Slot1";
            this.ColumnSlot1.Name = "ColumnSlot1";
            // 
            // Form2S_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.labelAvailableLessons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2S_C";
            this.Text = "Form2S_C";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPricePerLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSlot1;
        private System.Windows.Forms.Label labelAvailableLessons;
    }
}