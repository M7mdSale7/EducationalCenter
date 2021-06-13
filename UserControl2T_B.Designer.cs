
namespace EducationalCenter
{
    partial class UserControl2T_B
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
            this.dataGridViewTeacherStudents = new System.Windows.Forms.DataGridView();
            this.labelStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeacherStudents
            // 
            this.dataGridViewTeacherStudents.AllowUserToAddRows = false;
            this.dataGridViewTeacherStudents.AllowUserToDeleteRows = false;
            this.dataGridViewTeacherStudents.AllowUserToOrderColumns = true;
            this.dataGridViewTeacherStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherStudents.Location = new System.Drawing.Point(24, 91);
            this.dataGridViewTeacherStudents.Name = "dataGridViewTeacherStudents";
            this.dataGridViewTeacherStudents.ReadOnly = true;
            this.dataGridViewTeacherStudents.RowTemplate.Height = 25;
            this.dataGridViewTeacherStudents.Size = new System.Drawing.Size(542, 130);
            this.dataGridViewTeacherStudents.TabIndex = 2;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.BackColor = System.Drawing.Color.Transparent;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelStudents.Location = new System.Drawing.Point(20, 54);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(87, 20);
            this.labelStudents.TabIndex = 43;
            this.labelStudents.Text = "Students:";
            // 
            // UserControl2T_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.dataGridViewTeacherStudents);
            this.Name = "UserControl2T_B";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeacherStudents;
        private System.Windows.Forms.Label labelStudents;
    }
}
