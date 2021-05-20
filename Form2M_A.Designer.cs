
namespace EducationalCenter
{
    partial class Form2M_A
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(30, 37);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(63, 15);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(468, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelEmployees
            // 
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployees.Location = new System.Drawing.Point(30, 83);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(69, 15);
            this.labelEmployees.TabIndex = 3;
            this.labelEmployees.Text = "Employees:";
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
            // Form2M_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2M_A";
            this.Text = "Form2M_A";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationalID;
        private System.Windows.Forms.Label labelEmployees;
    }
}