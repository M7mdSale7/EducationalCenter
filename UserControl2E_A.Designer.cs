
namespace EducationalCenter
{
    partial class UserControl2E_A
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
            this.labelBookLessonsExams = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelSlot = new System.Windows.Forms.Label();
            this.comboBoxSlot = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxStudentID = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookLessonsExams
            // 
            this.labelBookLessonsExams.AutoSize = true;
            this.labelBookLessonsExams.BackColor = System.Drawing.Color.Transparent;
            this.labelBookLessonsExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelBookLessonsExams.Location = new System.Drawing.Point(11, 54);
            this.labelBookLessonsExams.Name = "labelBookLessonsExams";
            this.labelBookLessonsExams.Size = new System.Drawing.Size(220, 20);
            this.labelBookLessonsExams.TabIndex = 9;
            this.labelBookLessonsExams.Text = "Book Lessons and Exams:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 130);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(11, 243);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 16;
            this.labelStudentID.Text = "Student ID";
            // 
            // labelSlot
            // 
            this.labelSlot.AutoSize = true;
            this.labelSlot.Location = new System.Drawing.Point(157, 307);
            this.labelSlot.Name = "labelSlot";
            this.labelSlot.Size = new System.Drawing.Size(64, 13);
            this.labelSlot.TabIndex = 25;
            this.labelSlot.Text = "Choose Slot";
            // 
            // comboBoxSlot
            // 
            this.comboBoxSlot.FormattingEnabled = true;
            this.comboBoxSlot.Location = new System.Drawing.Point(160, 332);
            this.comboBoxSlot.Name = "comboBoxSlot";
            this.comboBoxSlot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSlot.TabIndex = 24;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(157, 241);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 23;
            this.labelSubject.Text = "Subject";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(300, 243);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 27;
            this.labelTeacher.Text = "Teacher";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(463, 332);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 30;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(303, 268);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 42;
            this.comboBoxTeacher.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeacher_SelectedIndexChanged);
            // 
            // buttonPrice
            // 
            this.buttonPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrice.Location = new System.Drawing.Point(463, 265);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(75, 23);
            this.buttonPrice.TabIndex = 47;
            this.buttonPrice.Text = "Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(160, 266);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 48;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(15, 334);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 46;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 309);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 45;
            this.labelType.Text = "Type";
            // 
            // comboBoxStudentID
            // 
            this.comboBoxStudentID.FormattingEnabled = true;
            this.comboBoxStudentID.Location = new System.Drawing.Point(14, 268);
            this.comboBoxStudentID.Name = "comboBoxStudentID";
            this.comboBoxStudentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudentID.TabIndex = 49;
            this.comboBoxStudentID.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentID_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(529, 58);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(28, 26);
            this.buttonDelete.TabIndex = 111;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl2E_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxStudentID);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelSlot);
            this.Controls.Add(this.comboBoxSlot);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelBookLessonsExams);
            this.Name = "UserControl2E_A";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookLessonsExams;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelSlot;
        private System.Windows.Forms.ComboBox comboBoxSlot;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.Button buttonDelete;
    }
}
