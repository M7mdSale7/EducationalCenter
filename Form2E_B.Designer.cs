
namespace EducationalCenter
{
    partial class Form2E_B
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
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBookRooms = new System.Windows.Forms.Label();
            this.label_Room = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.label_DateAndTime = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDateAndTime = new System.Windows.Forms.TextBox();
            this.textBox_Teacher = new System.Windows.Forms.TextBox();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelOldDateTime = new System.Windows.Forms.Label();
            this.textBoxOldDateTime = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelOldRoom = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(21, 62);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(55, 13);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "Welcome,";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(409, 25);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(64, 20);
            this.buttonLogOut.TabIndex = 7;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeacher,
            this.ColumnSubject,
            this.ColumnRoom,
            this.ColumnDateTime,
            this.ColumnType});
            this.dataGridView1.Location = new System.Drawing.Point(24, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 130);
            this.dataGridView1.TabIndex = 8;
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
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Date&Time";
            this.ColumnDateTime.Name = "ColumnDateTime";
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            // 
            // labelBookRooms
            // 
            this.labelBookRooms.AutoSize = true;
            this.labelBookRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelBookRooms.Location = new System.Drawing.Point(24, 108);
            this.labelBookRooms.Name = "labelBookRooms";
            this.labelBookRooms.Size = new System.Drawing.Size(80, 15);
            this.labelBookRooms.TabIndex = 9;
            this.labelBookRooms.Text = "Book Rooms:";
            // 
            // label_Room
            // 
            this.label_Room.AutoSize = true;
            this.label_Room.Location = new System.Drawing.Point(285, 282);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(35, 13);
            this.label_Room.TabIndex = 33;
            this.label_Room.Text = "Room";
            this.label_Room.Click += new System.EventHandler(this.labelSlot_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(156, 337);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 31;
            this.labelType.Text = "Type";
            this.labelType.Click += new System.EventHandler(this.labelRoom_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(156, 282);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 30;
            this.labelSubject.Text = "Subject";
            this.labelSubject.Click += new System.EventHandler(this.labelSubject_Click);
            // 
            // label_DateAndTime
            // 
            this.label_DateAndTime.AutoSize = true;
            this.label_DateAndTime.Location = new System.Drawing.Point(25, 337);
            this.label_DateAndTime.Name = "label_DateAndTime";
            this.label_DateAndTime.Size = new System.Drawing.Size(78, 13);
            this.label_DateAndTime.TabIndex = 29;
            this.label_DateAndTime.Text = "Date And Time";
            this.label_DateAndTime.Click += new System.EventHandler(this.labelTeacher_Click);
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(21, 284);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 28;
            this.labelTeacher.Text = "Teacher";
            this.labelTeacher.Click += new System.EventHandler(this.labelStudentID_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(507, 352);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(507, 323);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 26;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(156, 299);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubject.TabIndex = 24;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // textBoxDateAndTime
            // 
            this.textBoxDateAndTime.Location = new System.Drawing.Point(24, 356);
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateAndTime.TabIndex = 23;
            this.textBoxDateAndTime.TextChanged += new System.EventHandler(this.textBoxTeacher_TextChanged);
            // 
            // textBox_Teacher
            // 
            this.textBox_Teacher.Location = new System.Drawing.Point(24, 300);
            this.textBox_Teacher.Name = "textBox_Teacher";
            this.textBox_Teacher.Size = new System.Drawing.Size(100, 20);
            this.textBox_Teacher.TabIndex = 22;
            this.textBox_Teacher.TextChanged += new System.EventHandler(this.textBoxStudentID_TextChanged);
            // 
            // textBox_Room
            // 
            this.textBox_Room.Location = new System.Drawing.Point(288, 297);
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(100, 20);
            this.textBox_Room.TabIndex = 34;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(156, 354);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 35;
            // 
            // labelOldDateTime
            // 
            this.labelOldDateTime.AutoSize = true;
            this.labelOldDateTime.Location = new System.Drawing.Point(288, 337);
            this.labelOldDateTime.Name = "labelOldDateTime";
            this.labelOldDateTime.Size = new System.Drawing.Size(125, 13);
            this.labelOldDateTime.TabIndex = 36;
            this.labelOldDateTime.Text = "Old Date&Time for Update";
            // 
            // textBoxOldDateTime
            // 
            this.textBoxOldDateTime.Location = new System.Drawing.Point(291, 355);
            this.textBoxOldDateTime.Name = "textBoxOldDateTime";
            this.textBoxOldDateTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldDateTime.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 38;
            // 
            // labelOldRoom
            // 
            this.labelOldRoom.AutoSize = true;
            this.labelOldRoom.Location = new System.Drawing.Point(406, 282);
            this.labelOldRoom.Name = "labelOldRoom";
            this.labelOldRoom.Size = new System.Drawing.Size(107, 13);
            this.labelOldRoom.TabIndex = 39;
            this.labelOldRoom.Text = "Old Room for Update";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(406, 117);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 40;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // Form2E_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelOldRoom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxOldDateTime);
            this.Controls.Add(this.labelOldDateTime);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBox_Room);
            this.Controls.Add(this.label_Room);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.label_DateAndTime);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxDateAndTime);
            this.Controls.Add(this.textBox_Teacher);
            this.Controls.Add(this.labelBookRooms);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2E_B";
            this.Text = "Form2E_B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Label labelBookRooms;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label label_DateAndTime;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDateAndTime;
        private System.Windows.Forms.TextBox textBox_Teacher;
        private System.Windows.Forms.TextBox textBox_Room;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelOldDateTime;
        private System.Windows.Forms.TextBox textBoxOldDateTime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelOldRoom;
        private System.Windows.Forms.Label labelDelete;
    }
}