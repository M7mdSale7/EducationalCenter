
namespace EducationalCenter
{
    partial class Form2T_C
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.labelTeachingAssistants = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnID,
            this.ColumnPhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(26, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnPhoneNumber
            // 
            this.ColumnPhoneNumber.HeaderText = "Phone Number";
            this.ColumnPhoneNumber.Name = "ColumnPhoneNumber";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(269, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 50);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // labelTeachingAssistants
            // 
            this.labelTeachingAssistants.AutoSize = true;
            this.labelTeachingAssistants.Location = new System.Drawing.Point(26, 119);
            this.labelTeachingAssistants.Name = "labelTeachingAssistants";
            this.labelTeachingAssistants.Size = new System.Drawing.Size(112, 15);
            this.labelTeachingAssistants.TabIndex = 2;
            this.labelTeachingAssistants.Text = "Teaching Assistants:";
            // 
            // Form2T_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTeachingAssistants);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2T_C";
            this.Text = "Form2T-C";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNumber;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label labelTeachingAssistants;
    }
}