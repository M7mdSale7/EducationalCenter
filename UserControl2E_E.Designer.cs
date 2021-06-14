
namespace EducationalCenter
{
    partial class UserControl2E_E
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
            this.labelTeachers = new System.Windows.Forms.Label();
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNationalID = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNationalID = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelTeacherID = new System.Windows.Forms.Label();
            this.buttonTA = new System.Windows.Forms.Button();
            this.comboBoxTeacherID = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.BackColor = System.Drawing.Color.Transparent;
            this.labelTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeachers.Location = new System.Drawing.Point(20, 57);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(88, 20);
            this.labelTeachers.TabIndex = 81;
            this.labelTeachers.Text = "Teachers:";
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(21, 92);
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(342, 150);
            this.dataGridViewTeachers.TabIndex = 82;
            this.dataGridViewTeachers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTeachers_CellMouseDoubleClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 261);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 83;
            this.labelName.Text = "Name";
            // 
            // labelNationalID
            // 
            this.labelNationalID.AutoSize = true;
            this.labelNationalID.Location = new System.Drawing.Point(142, 261);
            this.labelNationalID.Name = "labelNationalID";
            this.labelNationalID.Size = new System.Drawing.Size(60, 13);
            this.labelNationalID.TabIndex = 84;
            this.labelNationalID.Text = "National ID";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(260, 261);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 85;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 278);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 86;
            // 
            // textBoxNationalID
            // 
            this.textBoxNationalID.Location = new System.Drawing.Point(145, 278);
            this.textBoxNationalID.MaxLength = 14;
            this.textBoxNationalID.Name = "textBoxNationalID";
            this.textBoxNationalID.Size = new System.Drawing.Size(100, 20);
            this.textBoxNationalID.TabIndex = 87;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(263, 278);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 88;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(389, 278);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 89;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelTeacherID
            // 
            this.labelTeacherID.AutoSize = true;
            this.labelTeacherID.BackColor = System.Drawing.Color.Transparent;
            this.labelTeacherID.Location = new System.Drawing.Point(386, 76);
            this.labelTeacherID.Name = "labelTeacherID";
            this.labelTeacherID.Size = new System.Drawing.Size(61, 13);
            this.labelTeacherID.TabIndex = 91;
            this.labelTeacherID.Text = "Teacher ID";
            // 
            // buttonTA
            // 
            this.buttonTA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTA.Location = new System.Drawing.Point(389, 138);
            this.buttonTA.Name = "buttonTA";
            this.buttonTA.Size = new System.Drawing.Size(102, 35);
            this.buttonTA.TabIndex = 92;
            this.buttonTA.Text = "View Teaching Assistants";
            this.buttonTA.UseVisualStyleBackColor = true;
            this.buttonTA.Click += new System.EventHandler(this.buttonTA_Click);
            // 
            // comboBoxTeacherID
            // 
            this.comboBoxTeacherID.FormattingEnabled = true;
            this.comboBoxTeacherID.Location = new System.Drawing.Point(389, 92);
            this.comboBoxTeacherID.Name = "comboBoxTeacherID";
            this.comboBoxTeacherID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacherID.TabIndex = 93;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(170, 322);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 100;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(21, 324);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 110;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Location = new System.Drawing.Point(21, 308);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(72, 13);
            this.labelSubject.TabIndex = 109;
            this.labelSubject.Text = "Subject name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(335, 60);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(28, 26);
            this.buttonDelete.TabIndex = 111;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // UserControl2E_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.comboBoxTeacherID);
            this.Controls.Add(this.buttonTA);
            this.Controls.Add(this.labelTeacherID);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxNationalID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelNationalID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Controls.Add(this.labelTeachers);
            this.Name = "UserControl2E_E";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeachers;
        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNationalID;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNationalID;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelTeacherID;
        private System.Windows.Forms.Button buttonTA;
        private System.Windows.Forms.ComboBox comboBoxTeacherID;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button buttonDelete;
    }
}
