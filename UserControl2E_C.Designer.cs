
namespace EducationalCenter
{
    partial class UserControl2E_C
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStudyYear = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownStudyYear = new System.Windows.Forms.NumericUpDown();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.numericUpDownYearFilter = new System.Windows.Forms.NumericUpDown();
            this.labelFilterYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudyYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(439, 150);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudents_CellMouseDoubleClick);
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(297, 61);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 43;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(312, 258);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 60;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.BackColor = System.Drawing.Color.Transparent;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudents.Location = new System.Drawing.Point(8, 54);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(87, 20);
            this.labelStudents.TabIndex = 62;
            this.labelStudents.Text = "Students:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 241);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 63;
            this.labelName.Text = "Name";
            // 
            // labelStudyYear
            // 
            this.labelStudyYear.AutoSize = true;
            this.labelStudyYear.Location = new System.Drawing.Point(147, 241);
            this.labelStudyYear.Name = "labelStudyYear";
            this.labelStudyYear.Size = new System.Drawing.Size(59, 13);
            this.labelStudyYear.TabIndex = 65;
            this.labelStudyYear.Text = "Study Year";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(9, 290);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 66;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(9, 258);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 67;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(9, 306);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 70;
            // 
            // numericUpDownStudyYear
            // 
            this.numericUpDownStudyYear.Location = new System.Drawing.Point(150, 261);
            this.numericUpDownStudyYear.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownStudyYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStudyYear.Name = "numericUpDownStudyYear";
            this.numericUpDownStudyYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStudyYear.TabIndex = 71;
            this.numericUpDownStudyYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(481, 351);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 98;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(167, 354);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 110;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.BackColor = System.Drawing.Color.Transparent;
            this.labelTeacherName.Location = new System.Drawing.Point(164, 338);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(76, 13);
            this.labelTeacherName.TabIndex = 109;
            this.labelTeacherName.Text = "Teacher name";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(8, 354);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 108;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Location = new System.Drawing.Point(8, 338);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 13);
            this.labelSubject.TabIndex = 107;
            this.labelSubject.Text = "Subject name";
            // 
            // numericUpDownYearFilter
            // 
            this.numericUpDownYearFilter.Location = new System.Drawing.Point(336, 354);
            this.numericUpDownYearFilter.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownYearFilter.Name = "numericUpDownYearFilter";
            this.numericUpDownYearFilter.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYearFilter.TabIndex = 112;
            // 
            // labelFilterYear
            // 
            this.labelFilterYear.AutoSize = true;
            this.labelFilterYear.Location = new System.Drawing.Point(333, 334);
            this.labelFilterYear.Name = "labelFilterYear";
            this.labelFilterYear.Size = new System.Drawing.Size(59, 13);
            this.labelFilterYear.TabIndex = 111;
            this.labelFilterYear.Text = "Study Year";
            // 
            // UserControl2E_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownYearFilter);
            this.Controls.Add(this.labelFilterYear);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.numericUpDownStudyYear);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelStudyYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "UserControl2E_C";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudyYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStudyYear;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownStudyYear;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.NumericUpDown numericUpDownYearFilter;
        private System.Windows.Forms.Label labelFilterYear;
    }
}
