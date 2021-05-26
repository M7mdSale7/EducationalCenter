
namespace EducationalCenter
{
    partial class UserControl2E_B
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
            this.labelBookRooms = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDelete = new System.Windows.Forms.Label();
            this.label_Teacher = new System.Windows.Forms.Label();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.textBox_Room = new System.Windows.Forms.TextBox();
            this.label_Room = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBox_OldRoom = new System.Windows.Forms.TextBox();
            this.label_DateAndTime = new System.Windows.Forms.Label();
            this.textBox_DateAndTime = new System.Windows.Forms.TextBox();
            this.labelOldRoom = new System.Windows.Forms.Label();
            this.textBoxOldDateTime = new System.Windows.Forms.TextBox();
            this.labelOldDateTime = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookRooms
            // 
            this.labelBookRooms.AutoSize = true;
            this.labelBookRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelBookRooms.Location = new System.Drawing.Point(3, 16);
            this.labelBookRooms.Name = "labelBookRooms";
            this.labelBookRooms.Size = new System.Drawing.Size(80, 15);
            this.labelBookRooms.TabIndex = 11;
            this.labelBookRooms.Text = "Book Rooms:";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 130);
            this.dataGridView1.TabIndex = 10;
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
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(368, 45);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 42;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // label_Teacher
            // 
            this.label_Teacher.AutoSize = true;
            this.label_Teacher.Location = new System.Drawing.Point(6, 214);
            this.label_Teacher.Name = "label_Teacher";
            this.label_Teacher.Size = new System.Drawing.Size(47, 13);
            this.label_Teacher.TabIndex = 48;
            this.label_Teacher.Text = "Teacher";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(6, 231);
            this.textBoxTeacher.MaxLength = 15;
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacher.TabIndex = 47;
            // 
            // textBox_Room
            // 
            this.textBox_Room.Location = new System.Drawing.Point(266, 231);
            this.textBox_Room.MaxLength = 15;
            this.textBox_Room.Name = "textBox_Room";
            this.textBox_Room.Size = new System.Drawing.Size(100, 20);
            this.textBox_Room.TabIndex = 46;
            // 
            // label_Room
            // 
            this.label_Room.AutoSize = true;
            this.label_Room.Location = new System.Drawing.Point(263, 216);
            this.label_Room.Name = "label_Room";
            this.label_Room.Size = new System.Drawing.Size(35, 13);
            this.label_Room.TabIndex = 45;
            this.label_Room.Text = "Room";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(134, 216);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 44;
            this.labelSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(134, 233);
            this.textBoxSubject.MaxLength = 15;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubject.TabIndex = 43;
            // 
            // textBox_OldRoom
            // 
            this.textBox_OldRoom.Location = new System.Drawing.Point(386, 230);
            this.textBox_OldRoom.MaxLength = 15;
            this.textBox_OldRoom.Name = "textBox_OldRoom";
            this.textBox_OldRoom.Size = new System.Drawing.Size(100, 20);
            this.textBox_OldRoom.TabIndex = 56;
            // 
            // label_DateAndTime
            // 
            this.label_DateAndTime.AutoSize = true;
            this.label_DateAndTime.Location = new System.Drawing.Point(4, 268);
            this.label_DateAndTime.Name = "label_DateAndTime";
            this.label_DateAndTime.Size = new System.Drawing.Size(78, 13);
            this.label_DateAndTime.TabIndex = 55;
            this.label_DateAndTime.Text = "Date And Time";
            // 
            // textBox_DateAndTime
            // 
            this.textBox_DateAndTime.Location = new System.Drawing.Point(4, 285);
            this.textBox_DateAndTime.MaxLength = 15;
            this.textBox_DateAndTime.Name = "textBox_DateAndTime";
            this.textBox_DateAndTime.Size = new System.Drawing.Size(100, 20);
            this.textBox_DateAndTime.TabIndex = 54;
            // 
            // labelOldRoom
            // 
            this.labelOldRoom.AutoSize = true;
            this.labelOldRoom.Location = new System.Drawing.Point(383, 213);
            this.labelOldRoom.Name = "labelOldRoom";
            this.labelOldRoom.Size = new System.Drawing.Size(107, 13);
            this.labelOldRoom.TabIndex = 53;
            this.labelOldRoom.Text = "Old Room for Update";
            // 
            // textBoxOldDateTime
            // 
            this.textBoxOldDateTime.Location = new System.Drawing.Point(268, 286);
            this.textBoxOldDateTime.MaxLength = 15;
            this.textBoxOldDateTime.Name = "textBoxOldDateTime";
            this.textBoxOldDateTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxOldDateTime.TabIndex = 52;
            // 
            // labelOldDateTime
            // 
            this.labelOldDateTime.AutoSize = true;
            this.labelOldDateTime.Location = new System.Drawing.Point(265, 268);
            this.labelOldDateTime.Name = "labelOldDateTime";
            this.labelOldDateTime.Size = new System.Drawing.Size(125, 13);
            this.labelOldDateTime.TabIndex = 51;
            this.labelOldDateTime.Text = "Old Date&Time for Update";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(133, 285);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 50;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(133, 268);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 49;
            this.labelType.Text = "Type";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(502, 284);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 58;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(502, 229);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 57;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // UserControl2E_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBox_OldRoom);
            this.Controls.Add(this.label_DateAndTime);
            this.Controls.Add(this.textBox_DateAndTime);
            this.Controls.Add(this.labelOldRoom);
            this.Controls.Add(this.textBoxOldDateTime);
            this.Controls.Add(this.labelOldDateTime);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label_Teacher);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.textBox_Room);
            this.Controls.Add(this.label_Room);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelBookRooms);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2E_B";
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookRooms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label label_Teacher;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.TextBox textBox_Room;
        private System.Windows.Forms.Label label_Room;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBox_OldRoom;
        private System.Windows.Forms.Label label_DateAndTime;
        private System.Windows.Forms.TextBox textBox_DateAndTime;
        private System.Windows.Forms.Label labelOldRoom;
        private System.Windows.Forms.TextBox textBoxOldDateTime;
        private System.Windows.Forms.Label labelOldDateTime;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
    }
}
