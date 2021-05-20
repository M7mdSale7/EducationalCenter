
namespace EducationalCenter
{
    partial class Form2TA_C
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
            this.labelExamsDates = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ColumnExamNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExamType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnExamNumber,
            this.ColumnExamType,
            this.ColumnDate,
            this.ColumnTime});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(19, 189);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowTemplate.Height = 25;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(342, 183);
            this.dataGridViewSchedule.TabIndex = 20;
            // 
            // labelExamsDates
            // 
            this.labelExamsDates.AutoSize = true;
            this.labelExamsDates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExamsDates.Location = new System.Drawing.Point(19, 136);
            this.labelExamsDates.Name = "labelExamsDates";
            this.labelExamsDates.Size = new System.Drawing.Size(110, 21);
            this.labelExamsDates.TabIndex = 19;
            this.labelExamsDates.Text = "Exams Dates:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(52, 81);
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
            // ColumnExamNumber
            // 
            this.ColumnExamNumber.HeaderText = "Exam Number";
            this.ColumnExamNumber.Name = "ColumnExamNumber";
            this.ColumnExamNumber.ReadOnly = true;
            // 
            // ColumnExamType
            // 
            this.ColumnExamType.HeaderText = "Exam Type";
            this.ColumnExamType.Name = "ColumnExamType";
            this.ColumnExamType.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // Form2TA_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelExamsDates);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonBack);
            this.Name = "Form2TA_C";
            this.Text = "Form2TA_C";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExamNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExamType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.Label labelExamsDates;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
    }
}