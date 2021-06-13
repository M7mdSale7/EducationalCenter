
namespace EducationalCenter
{
    partial class UserControl2E_I
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
            this.labelStudy = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.dataGridViewStudies = new System.Windows.Forms.DataGridView();
            this.comboBoxStudentID = new System.Windows.Forms.ComboBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxFilterSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterTeacher = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilterStudentID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudies)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudy
            // 
            this.labelStudy.AutoSize = true;
            this.labelStudy.BackColor = System.Drawing.Color.Transparent;
            this.labelStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudy.Location = new System.Drawing.Point(22, 55);
            this.labelStudy.Name = "labelStudy";
            this.labelStudy.Size = new System.Drawing.Size(60, 20);
            this.labelStudy.TabIndex = 10;
            this.labelStudy.Text = "Study:";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(366, 77);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 108;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // dataGridViewStudies
            // 
            this.dataGridViewStudies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudies.Location = new System.Drawing.Point(26, 93);
            this.dataGridViewStudies.Name = "dataGridViewStudies";
            this.dataGridViewStudies.Size = new System.Drawing.Size(494, 171);
            this.dataGridViewStudies.TabIndex = 109;
            this.dataGridViewStudies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStudies_CellMouseDoubleClick);
            // 
            // comboBoxStudentID
            // 
            this.comboBoxStudentID.FormattingEnabled = true;
            this.comboBoxStudentID.Location = new System.Drawing.Point(26, 303);
            this.comboBoxStudentID.Name = "comboBoxStudentID";
            this.comboBoxStudentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudentID.TabIndex = 111;
            this.comboBoxStudentID.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentID_SelectedIndexChanged);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(23, 287);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 110;
            this.labelStudentID.Text = "Student ID";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(477, 301);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 112;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(168, 303);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 116;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(320, 303);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 115;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(317, 287);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 114;
            this.labelTeacher.Text = "Teacher";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(165, 287);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 113;
            this.labelSubject.Text = "Subject";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(477, 352);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 117;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxFilterSubject
            // 
            this.comboBoxFilterSubject.FormattingEnabled = true;
            this.comboBoxFilterSubject.Location = new System.Drawing.Point(168, 354);
            this.comboBoxFilterSubject.Name = "comboBoxFilterSubject";
            this.comboBoxFilterSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterSubject.TabIndex = 123;
            // 
            // comboBoxFilterTeacher
            // 
            this.comboBoxFilterTeacher.FormattingEnabled = true;
            this.comboBoxFilterTeacher.Location = new System.Drawing.Point(320, 354);
            this.comboBoxFilterTeacher.Name = "comboBoxFilterTeacher";
            this.comboBoxFilterTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterTeacher.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "Subject";
            // 
            // comboBoxFilterStudentID
            // 
            this.comboBoxFilterStudentID.FormattingEnabled = true;
            this.comboBoxFilterStudentID.Location = new System.Drawing.Point(26, 354);
            this.comboBoxFilterStudentID.Name = "comboBoxFilterStudentID";
            this.comboBoxFilterStudentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterStudentID.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Student ID";
            // 
            // UserControl2E_I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxFilterSubject);
            this.Controls.Add(this.comboBoxFilterTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFilterStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.comboBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.dataGridViewStudies);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelStudy);
            this.Name = "UserControl2E_I";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudy;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.DataGridView dataGridViewStudies;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterSubject;
        private System.Windows.Forms.ComboBox comboBoxFilterTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilterStudentID;
        private System.Windows.Forms.Label label3;
    }
}
