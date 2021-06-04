
namespace EducationalCenter
{
    partial class UserControl2E_D
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.comboBoxStudentID = new System.Windows.Forms.ComboBox();
            this.dataGridViewParents = new System.Windows.Forms.DataGridView();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelParents = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxFilterStudentID = new System.Windows.Forms.ComboBox();
            this.labelFilterStudentID = new System.Windows.Forms.Label();
            this.comboBoxFilterName = new System.Windows.Forms.ComboBox();
            this.labelFilterName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 267);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(12, 320);
            this.textBoxPhoneNumber.MaxLength = 11;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 1;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(358, 263);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 71;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 248);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 73;
            this.labelName.Text = "Name";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(170, 248);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 74;
            this.labelStudentID.Text = "Student ID";
            // 
            // comboBoxStudentID
            // 
            this.comboBoxStudentID.FormattingEnabled = true;
            this.comboBoxStudentID.Location = new System.Drawing.Point(173, 265);
            this.comboBoxStudentID.Name = "comboBoxStudentID";
            this.comboBoxStudentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudentID.TabIndex = 75;
            // 
            // dataGridViewParents
            // 
            this.dataGridViewParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParents.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewParents.Name = "dataGridViewParents";
            this.dataGridViewParents.ReadOnly = true;
            this.dataGridViewParents.Size = new System.Drawing.Size(540, 150);
            this.dataGridViewParents.TabIndex = 76;
            this.dataGridViewParents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewParents_CellMouseDoubleClick);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 301);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.labelPhoneNumber.TabIndex = 77;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(398, 69);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 78;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // labelParents
            // 
            this.labelParents.AutoSize = true;
            this.labelParents.BackColor = System.Drawing.Color.Transparent;
            this.labelParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParents.Location = new System.Drawing.Point(11, 50);
            this.labelParents.Name = "labelParents";
            this.labelParents.Size = new System.Drawing.Size(76, 20);
            this.labelParents.TabIndex = 79;
            this.labelParents.Text = "Parents:";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFilter.Location = new System.Drawing.Point(358, 363);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 99;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxFilterStudentID
            // 
            this.comboBoxFilterStudentID.FormattingEnabled = true;
            this.comboBoxFilterStudentID.Location = new System.Drawing.Point(173, 365);
            this.comboBoxFilterStudentID.Name = "comboBoxFilterStudentID";
            this.comboBoxFilterStudentID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterStudentID.TabIndex = 101;
            // 
            // labelFilterStudentID
            // 
            this.labelFilterStudentID.AutoSize = true;
            this.labelFilterStudentID.Location = new System.Drawing.Point(170, 348);
            this.labelFilterStudentID.Name = "labelFilterStudentID";
            this.labelFilterStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelFilterStudentID.TabIndex = 100;
            this.labelFilterStudentID.Text = "Student ID";
            // 
            // comboBoxFilterName
            // 
            this.comboBoxFilterName.FormattingEnabled = true;
            this.comboBoxFilterName.Location = new System.Drawing.Point(12, 365);
            this.comboBoxFilterName.Name = "comboBoxFilterName";
            this.comboBoxFilterName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterName.TabIndex = 103;
            // 
            // labelFilterName
            // 
            this.labelFilterName.AutoSize = true;
            this.labelFilterName.Location = new System.Drawing.Point(12, 348);
            this.labelFilterName.Name = "labelFilterName";
            this.labelFilterName.Size = new System.Drawing.Size(35, 13);
            this.labelFilterName.TabIndex = 102;
            this.labelFilterName.Text = "Name";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(12, 14);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 104;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UserControl2E_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxFilterName);
            this.Controls.Add(this.labelFilterName);
            this.Controls.Add(this.comboBoxFilterStudentID);
            this.Controls.Add(this.labelFilterStudentID);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelParents);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.dataGridViewParents);
            this.Controls.Add(this.comboBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Name = "UserControl2E_D";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.DataGridView dataGridViewParents;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelParents;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterStudentID;
        private System.Windows.Forms.Label labelFilterStudentID;
        private System.Windows.Forms.ComboBox comboBoxFilterName;
        private System.Windows.Forms.Label labelFilterName;
        private System.Windows.Forms.Button buttonBack;
    }
}
