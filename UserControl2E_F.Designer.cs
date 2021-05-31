
namespace EducationalCenter
{
    partial class UserControl2E_F
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
            this.labelSubjects = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.Location = new System.Drawing.Point(15, 18);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(84, 20);
            this.labelSubjects.TabIndex = 82;
            this.labelSubjects.Text = "Subjects:";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(305, 56);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 83;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(384, 245);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 84;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnYear,
            this.ColumnTeacherName,
            this.ColumnTeacherID});
            this.dataGridView1.Location = new System.Drawing.Point(19, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 150);
            this.dataGridView1.TabIndex = 86;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Year";
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.ReadOnly = true;
            // 
            // ColumnTeacherName
            // 
            this.ColumnTeacherName.HeaderText = "Teacher name";
            this.ColumnTeacherName.Name = "ColumnTeacherName";
            this.ColumnTeacherName.ReadOnly = true;
            // 
            // ColumnTeacherID
            // 
            this.ColumnTeacherID.HeaderText = "Teacher ID";
            this.ColumnTeacherID.Name = "ColumnTeacherID";
            this.ColumnTeacherID.ReadOnly = true;
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(183, 245);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 87;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 229);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 88;
            this.labelName.Text = "Name";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(22, 275);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 89;
            this.labelYear.Text = "Year";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(180, 229);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 90;
            this.labelTeacher.Text = "Teacher";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 245);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 92;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(25, 292);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 93;
            // 
            // UserControl2E_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelSubjects);
            this.Name = "UserControl2E_F";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTeacherID;
    }
}
