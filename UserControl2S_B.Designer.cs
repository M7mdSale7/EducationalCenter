
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
            this.dataGridViewGradesReport = new System.Windows.Forms.DataGridView();
            this.labelGradesReport = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGradesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGradesReport
            // 
            this.dataGridViewGradesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGradesReport.Location = new System.Drawing.Point(15, 230);
            this.dataGridViewGradesReport.Name = "dataGridViewGradesReport";
            this.dataGridViewGradesReport.ReadOnly = true;
            this.dataGridViewGradesReport.RowTemplate.Height = 25;
            this.dataGridViewGradesReport.Size = new System.Drawing.Size(441, 187);
            this.dataGridViewGradesReport.TabIndex = 2;
            // 
            // labelGradesReport
            // 
            this.labelGradesReport.AutoSize = true;
            this.labelGradesReport.BackColor = System.Drawing.Color.Transparent;
            this.labelGradesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGradesReport.Location = new System.Drawing.Point(11, 189);
            this.labelGradesReport.Name = "labelGradesReport";
            this.labelGradesReport.Size = new System.Drawing.Size(133, 20);
            this.labelGradesReport.TabIndex = 90;
            this.labelGradesReport.Text = "Grades Report:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Location = new System.Drawing.Point(18, 60);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 13);
            this.labelSubject.TabIndex = 101;
            this.labelSubject.Text = "Subject name";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(21, 85);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 102;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.labelTeacherName.Location = new System.Drawing.Point(18, 124);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(76, 13);
            this.labelTeacherName.TabIndex = 105;
            this.labelTeacherName.Text = "Teacher name";
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(21, 150);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 106;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(187, 150);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 107;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // UserControl2S_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelGradesReport);
            this.Controls.Add(this.dataGridViewGradesReport);
            this.Name = "UserControl2S_B";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGradesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGradesReport;
        private System.Windows.Forms.Label labelGradesReport;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Button buttonFilter;
    }
}
