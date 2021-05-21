
namespace EducationalCenter
{
    partial class Form2E_A
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBookLessons = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.comboBoxSlot = new System.Windows.Forms.ComboBox();
            this.labelSlot = new System.Windows.Forms.Label();
            this.textBoxOldSlot = new System.Windows.Forms.TextBox();
            this.labelOldSlot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(26, 48);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 5;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(494, 24);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(64, 20);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStudentID,
            this.ColumnTeacher,
            this.ColumnSubject,
            this.ColumnRoom,
            this.ColumnSlot});
            this.dataGridView1.Location = new System.Drawing.Point(29, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 130);
            this.dataGridView1.TabIndex = 7;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.HeaderText = "Student ID";
            this.ColumnStudentID.Name = "ColumnStudentID";
            // 
            // ColumnTeacher
            // 
            this.ColumnTeacher.HeaderText = "Teacher";
            this.ColumnTeacher.Name = "ColumnTeacher";
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            // 
            // ColumnRoom
            // 
            this.ColumnRoom.HeaderText = "Room";
            this.ColumnRoom.Name = "ColumnRoom";
            // 
            // ColumnSlot
            // 
            this.ColumnSlot.HeaderText = "Slot";
            this.ColumnSlot.Name = "ColumnSlot";
            this.ColumnSlot.ReadOnly = true;
            // 
            // labelBookLessons
            // 
            this.labelBookLessons.AutoSize = true;
            this.labelBookLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelBookLessons.Location = new System.Drawing.Point(26, 98);
            this.labelBookLessons.Name = "labelBookLessons";
            this.labelBookLessons.Size = new System.Drawing.Size(84, 15);
            this.labelBookLessons.TabIndex = 8;
            this.labelBookLessons.Text = "Book Lessons:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(12, 302);
            this.textBoxStudentID.MaxLength = 15;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 9;
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(12, 358);
            this.textBoxTeacher.MaxLength = 15;
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacher.TabIndex = 10;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(144, 301);
            this.textBoxSubject.MaxLength = 15;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubject.TabIndex = 11;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(447, 299);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 13;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(447, 355);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(9, 286);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 15;
            this.labelStudentID.Text = "Student ID";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(13, 339);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 16;
            this.labelTeacher.Text = "Teacher";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(144, 284);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 17;
            this.labelSubject.Text = "Subject";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(308, 117);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 19;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // comboBoxSlot
            // 
            this.comboBoxSlot.FormattingEnabled = true;
            this.comboBoxSlot.Location = new System.Drawing.Point(273, 300);
            this.comboBoxSlot.Name = "comboBoxSlot";
            this.comboBoxSlot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSlot.TabIndex = 20;
            // 
            // labelSlot
            // 
            this.labelSlot.AutoSize = true;
            this.labelSlot.Location = new System.Drawing.Point(273, 284);
            this.labelSlot.Name = "labelSlot";
            this.labelSlot.Size = new System.Drawing.Size(64, 13);
            this.labelSlot.TabIndex = 21;
            this.labelSlot.Text = "Choose Slot";
            // 
            // textBoxOldSlot
            // 
            this.textBoxOldSlot.Location = new System.Drawing.Point(144, 357);
            this.textBoxOldSlot.MaxLength = 15;
            this.textBoxOldSlot.Name = "textBoxOldSlot";
            this.textBoxOldSlot.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldSlot.TabIndex = 22;
            // 
            // labelOldSlot
            // 
            this.labelOldSlot.AutoSize = true;
            this.labelOldSlot.Location = new System.Drawing.Point(144, 341);
            this.labelOldSlot.Name = "labelOldSlot";
            this.labelOldSlot.Size = new System.Drawing.Size(97, 13);
            this.labelOldSlot.TabIndex = 23;
            this.labelOldSlot.Text = "Old Slot for Update";
            // 
            // Form2E_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelOldSlot);
            this.Controls.Add(this.textBoxOldSlot);
            this.Controls.Add(this.labelSlot);
            this.Controls.Add(this.comboBoxSlot);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelBookLessons);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2E_A";
            this.Text = "Form2E_A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBookLessons;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSlot;
        private System.Windows.Forms.ComboBox comboBoxSlot;
        private System.Windows.Forms.Label labelSlot;
        private System.Windows.Forms.TextBox textBoxOldSlot;
        private System.Windows.Forms.Label labelOldSlot;
    }
}