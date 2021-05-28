
namespace EducationalCenter
{
    partial class UserControl2M_A
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxNID = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNationalID = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnPhoneNumber,
            this.ColumnAddress,
            this.ColumnSalary,
            this.ColumnNationalID});
            this.dataGridView1.Location = new System.Drawing.Point(17, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(542, 130);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Phone Number";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Salary";
            this.ColumnSalary.Name = "ColumnSalary";
            // 
            // ColumnNationalID
            // 
            this.ColumnNationalID.HeaderText = "National ID";
            this.ColumnNationalID.Name = "ColumnNationalID";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelDelete.Location = new System.Drawing.Point(405, 69);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(154, 13);
            this.labelDelete.TabIndex = 43;
            this.labelDelete.Text = "Double click on a row to delete";
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelEmployees.Location = new System.Drawing.Point(13, 35);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(101, 20);
            this.labelEmployees.TabIndex = 42;
            this.labelEmployees.Text = "Employees:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(325, 264);
            this.textBoxAddress.MaxLength = 15;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 51;
            // 
            // textBoxNID
            // 
            this.textBoxNID.Location = new System.Drawing.Point(177, 320);
            this.textBoxNID.MaxLength = 15;
            this.textBoxNID.Name = "textBoxNID";
            this.textBoxNID.Size = new System.Drawing.Size(100, 20);
            this.textBoxNID.TabIndex = 50;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(177, 263);
            this.textBoxPhoneNumber.MaxLength = 15;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 49;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(29, 320);
            this.textBoxSalary.MaxLength = 15;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 48;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(29, 264);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 47;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(339, 246);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 56;
            this.labelAddress.Text = "Address";
            // 
            // labelNationalID
            // 
            this.labelNationalID.AutoSize = true;
            this.labelNationalID.Location = new System.Drawing.Point(177, 301);
            this.labelNationalID.Name = "labelNationalID";
            this.labelNationalID.Size = new System.Drawing.Size(60, 13);
            this.labelNationalID.TabIndex = 55;
            this.labelNationalID.Text = "National ID";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(177, 246);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 54;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(30, 301);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 53;
            this.labelSalary.Text = "Salary";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 248);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Location = new System.Drawing.Point(484, 306);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 83;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInsert.Location = new System.Drawing.Point(484, 260);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 82;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // UserControl2M_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EducationalCenter.Properties.Resources.Background;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNationalID);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxNID);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2M_A";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(600, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationalID;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxNID;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNationalID;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
    }
}
