
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
            this.dataGridViewExams = new System.Windows.Forms.DataGridView();
            this.dataGridViewLessons = new System.Windows.Forms.DataGridView();
            this.labelLessons = new System.Windows.Forms.Label();
            this.labelExams = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExams
            // 
            this.dataGridViewExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExams.Location = new System.Drawing.Point(14, 218);
            this.dataGridViewExams.Name = "dataGridViewExams";
            this.dataGridViewExams.ReadOnly = true;
            this.dataGridViewExams.RowTemplate.Height = 25;
            this.dataGridViewExams.Size = new System.Drawing.Size(434, 98);
            this.dataGridViewExams.TabIndex = 3;
            // 
            // dataGridViewLessons
            // 
            this.dataGridViewLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessons.Location = new System.Drawing.Point(13, 83);
            this.dataGridViewLessons.Name = "dataGridViewLessons";
            this.dataGridViewLessons.ReadOnly = true;
            this.dataGridViewLessons.RowTemplate.Height = 25;
            this.dataGridViewLessons.Size = new System.Drawing.Size(435, 90);
            this.dataGridViewLessons.TabIndex = 4;
            // 
            // labelLessons
            // 
            this.labelLessons.AutoSize = true;
            this.labelLessons.BackColor = System.Drawing.Color.Transparent;
            this.labelLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLessons.Location = new System.Drawing.Point(9, 48);
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
            this.labelExams.Location = new System.Drawing.Point(10, 183);
            this.labelExams.Name = "labelExams";
            this.labelExams.Size = new System.Drawing.Size(67, 20);
            this.labelExams.TabIndex = 99;
            this.labelExams.Text = "Exams:";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(342, 352);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 112;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(159, 354);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 111;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.labelTeacherName.Location = new System.Drawing.Point(156, 336);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(76, 13);
            this.labelTeacherName.TabIndex = 110;
            this.labelTeacherName.Text = "Teacher name";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(16, 354);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 109;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Location = new System.Drawing.Point(14, 338);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 13);
            this.labelSubject.TabIndex = 108;
            this.labelSubject.Text = "Subject name";
            // 
            // UserControl2S_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelExams);
            this.Controls.Add(this.labelLessons);
            this.Controls.Add(this.dataGridViewLessons);
            this.Controls.Add(this.dataGridViewExams);
            this.Name = "UserControl2S_A";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExams;
        private System.Windows.Forms.DataGridView dataGridViewLessons;
        private System.Windows.Forms.Label labelLessons;
        private System.Windows.Forms.Label labelExams;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelSubject;
    }
}
