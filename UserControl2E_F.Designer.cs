
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
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilterTeacher = new System.Windows.Forms.ComboBox();
            this.numericUpDownFilterYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.comboBoxFilterSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.Location = new System.Drawing.Point(18, 56);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(84, 20);
            this.labelSubjects.TabIndex = 82;
            this.labelSubjects.Text = "Subjects:";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(305, 63);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 83;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(183, 292);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 84;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(19, 79);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.ReadOnly = true;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(440, 150);
            this.dataGridViewSubjects.TabIndex = 86;
            this.dataGridViewSubjects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSubjects_CellMouseDoubleClick);
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(183, 252);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeacher.TabIndex = 87;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 236);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 88;
            this.labelName.Text = "Name";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(19, 279);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 89;
            this.labelYear.Text = "Year";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(180, 236);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 90;
            this.labelTeacher.Text = "Teacher";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(22, 252);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 92;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(22, 295);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYear.TabIndex = 93;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Teacher";
            // 
            // comboBoxFilterTeacher
            // 
            this.comboBoxFilterTeacher.FormattingEnabled = true;
            this.comboBoxFilterTeacher.Location = new System.Drawing.Point(183, 336);
            this.comboBoxFilterTeacher.Name = "comboBoxFilterTeacher";
            this.comboBoxFilterTeacher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterTeacher.TabIndex = 94;
            // 
            // numericUpDownFilterYear
            // 
            this.numericUpDownFilterYear.Location = new System.Drawing.Point(22, 336);
            this.numericUpDownFilterYear.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownFilterYear.Name = "numericUpDownFilterYear";
            this.numericUpDownFilterYear.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFilterYear.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Year";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(183, 377);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 101;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(19, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 106;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(19, 363);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 108;
            this.labelSubject.Text = "Subject";
            // 
            // comboBoxFilterSubject
            // 
            this.comboBoxFilterSubject.FormattingEnabled = true;
            this.comboBoxFilterSubject.Location = new System.Drawing.Point(22, 379);
            this.comboBoxFilterSubject.Name = "comboBoxFilterSubject";
            this.comboBoxFilterSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterSubject.TabIndex = 107;
            // 
            // UserControl2E_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.comboBoxFilterSubject);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.numericUpDownFilterYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFilterTeacher);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelSubjects);
            this.Name = "UserControl2E_F";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilterTeacher;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxFilterSubject;
    }
}
